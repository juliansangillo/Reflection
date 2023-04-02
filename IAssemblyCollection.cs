using System.Collections.Generic;
using System.Reflection;
using JetBrains.Annotations;

namespace JulianSangillo.Reflection {
    [PublicAPI]
    public interface IAssemblyCollection : IEnumerable<Assembly> {
        ITypeCollection Types { get; }
    }
}
