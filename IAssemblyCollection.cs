using System.Collections.Generic;
using System.Reflection;
using JetBrains.Annotations;

namespace JulianSangillo.Reflection {
    /// <summary>
    ///     Uses the .NET Reflection API to collect all referenced assemblies given an entry assembly. Can return a
    ///     collection of all types in the collection of assemblies.
    /// </summary>
    [PublicAPI]
    public interface IAssemblyCollection : IEnumerable<Assembly> {
        /// <summary>
        ///     Gets instance of <see cref="ITypeCollection" /> containing all types in all referenced assemblies.
        /// </summary>
        ITypeCollection Types { get; }
    }
}
