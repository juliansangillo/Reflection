using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace JulianSangillo.Reflection {
    /// <summary>Implementation of <see cref="ITypeCollection" />.</summary>
    [PublicAPI]
    public class TypeCollection : ITypeCollection {
        private readonly IEnumerable<Type> types;

        /// <summary>Initializes a new instance of the <see cref="TypeCollection"/> class from an enumerable of types.</summary>
        /// <param name="types">The types to initialize the collection with.</param>
        public TypeCollection(IEnumerable<Type> types) {
            this.types = types;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TypeCollection"/> class that uses reflection to collect
        ///     all types in all given assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies to collect types from.</param>
        protected internal TypeCollection(IAssemblyCollection assemblies) {
            types = assemblies.SelectMany(assembly => assembly.GetTypes());
        }

        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<Type> GetEnumerator() {
            return types.GetEnumerator();
        }

        /// <inheritdoc />
        public Type WithName(string name) {
            return types.FirstOrDefault(type => type.Name == name);
        }

        /// <inheritdoc />
        public ITypeCollection AssignableTo<T>(bool interfaces = false, bool abstracts = false)
            where T : class {
            return AssignableTo(typeof(T));
        }

        /// <inheritdoc />
        public ITypeCollection AssignableTo(Type type, bool interfaces = false, bool abstracts = false) {
            return types.Where(t =>
                    (interfaces || !t.IsInterface) &&
                    (abstracts || !t.IsAbstract) &&
                    type.IsAssignableFrom(t))
                .ToTypeCollection();
        }

        /// <inheritdoc />
        public ITypeCollection ImplementsGeneric(Type type, bool interfaces = false, bool abstracts = false) {
            return types.Where(t =>
                    (interfaces || !t.IsInterface) &&
                    (abstracts || !t.IsAbstract) &&
                    t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == type))
                .ToTypeCollection();
        }

        /// <inheritdoc />
        public ITypeCollection HaveAttribute<T>(bool inherit = true, bool interfaces = false, bool abstracts = false)
            where T : Attribute {
            return HaveAttribute(typeof(T));
        }

        /// <inheritdoc />
        public ITypeCollection HaveAttribute(
            Type type,
            bool inherit = true,
            bool interfaces = false,
            bool abstracts = false) {
            return types.Where(t =>
                    (interfaces || !t.IsInterface) &&
                    (abstracts || !t.IsAbstract) &&
                    t.GetCustomAttributes(type, inherit).Length > 0)
                .ToTypeCollection();
        }

        /// <inheritdoc />
        public IEnumerable<T> InstanceOf<T>()
            where T : class {
            return AssignableTo<T>().Select(t => Activator.CreateInstance(t) as T);
        }

        /// <inheritdoc />
        public IEnumerable<object> InstanceOf(Type type) {
            return AssignableTo(type).Select(Activator.CreateInstance);
        }

        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
