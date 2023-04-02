using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using JetBrains.Annotations;

namespace JulianSangillo.Reflection {
    [PublicAPI]
    public class AssemblyCollection<TEntryPoint> : IAssemblyCollection {
        private readonly IEnumerable<Assembly> enumerable;

        public ITypeCollection Types { get; }

        public AssemblyCollection() {
            enumerable = GetAllAssemblies();
            Types = new TypeCollection(this);
        }

        public IEnumerator<Assembly> GetEnumerator() {
            return enumerable.GetEnumerator();
        }

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
