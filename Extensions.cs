using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace JulianSangillo.Reflection {
    [PublicAPI]
    public static class Extensions {
        public static ITypeCollection ToTypeCollection(this IEnumerable<Type> @this) {
            return new TypeCollection(@this);
        }
    }
}
