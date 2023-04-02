using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace JulianSangillo.Reflection {
    [PublicAPI]
    public class TypeCollection : ITypeCollection {
        private readonly IEnumerable<Type> types;

        public TypeCollection(IEnumerable<Type> types) {
            this.types = types;
        }

        protected internal TypeCollection(IAssemblyCollection assemblies) {
            types = assemblies.SelectMany(assembly => assembly.GetTypes());
        }

        public IEnumerator<Type> GetEnumerator() {
            return types.GetEnumerator();
        }

        public Type WithName(string name) {
            return types.FirstOrDefault(type => type.Name == name);
        }

        public ITypeCollection AssignableTo<T>(bool interfaces = false, bool abstracts = false) where T : class {
            return AssignableTo(typeof(T));
        }

        public ITypeCollection AssignableTo(Type type, bool interfaces = false, bool abstracts = false) {
            return types.Where(t =>
                    (interfaces || !t.IsInterface) &&
                    (abstracts || !t.IsAbstract) &&
                    type.IsAssignableFrom(t))
                .ToTypeCollection();
        }

        public ITypeCollection ImplementsGeneric(Type type, bool interfaces = false, bool abstracts = false) {
            return types.Where(t =>
                    (interfaces || !t.IsInterface) &&
                    (abstracts || !t.IsAbstract) &&
                    t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == type)
                )
                .ToTypeCollection();
        }

        public ITypeCollection HaveAttribute<T>(bool inherit = true, bool interfaces = false, bool abstracts = false)
            where T : Attribute {
            return HaveAttribute(typeof(T));
        }

        public ITypeCollection HaveAttribute(
            Type type,
            bool inherit = true,
            bool interfaces = false,
            bool abstracts = false
        ) {
            return types.Where(t =>
                    (interfaces || !t.IsInterface) &&
                    (abstracts || !t.IsAbstract) &&
                    t.GetCustomAttributes(type, inherit).Length > 0
                )
                .ToTypeCollection();
        }

        public IEnumerable<T> InstanceOf<T>() where T : class {
            return AssignableTo<T>().Select(t => Activator.CreateInstance(t) as T);
        }

        public IEnumerable<object> InstanceOf(Type type) {
            return AssignableTo(type).Select(Activator.CreateInstance);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
