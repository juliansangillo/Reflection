using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using JetBrains.Annotations;

namespace JulianSangillo.Reflection {
    /// <summary>Implementation of <see cref="IAssemblyCollection" />.</summary>
    /// <typeparam name="TEntryPoint">
    ///     Type used to get the entry-point assembly. All assemblies are collected by starting with the
    ///     entry-point, collecting its dependencies, and their dependencies. The entry-point type could
    ///     be any type that is defined in the entry-point assembly.
    /// </typeparam>
    [PublicAPI]
    public class AssemblyCollection<TEntryPoint> : IAssemblyCollection {
        private readonly IEnumerable<Assembly> enumerable;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AssemblyCollection{TEntryPoint}"/> class. Uses
        ///     reflection to collect all assemblies starting from the entry-point and initializes.
        /// </summary>
        public AssemblyCollection() {
            enumerable = GetAllAssemblies();
            Types = new TypeCollection(this);
        }

        /// <inheritdoc />
        public ITypeCollection Types { get; }

        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<Assembly> GetEnumerator() {
            return enumerable.GetEnumerator();
        }

        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        private static IEnumerable<Assembly> GetAllAssemblies() {
            ISet<string> assemblySet = new HashSet<string>();
            Queue<Assembly> next = new Queue<Assembly>();

            next.Enqueue(Assembly.GetAssembly(typeof(TEntryPoint)));

            do {
                Assembly asm = next.Dequeue();

                yield return asm;

                foreach (AssemblyName reference in asm.GetReferencedAssemblies())
                    if (assemblySet.Add(reference.FullName))
                        next.Enqueue(Assembly.Load(reference));
            } while (next.Count > 0);
        }
    }
}
