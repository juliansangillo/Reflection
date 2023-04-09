using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace JulianSangillo.Reflection {
    [PublicAPI]
    public static class Extensions {
        /// <summary>Converts an enumerable of types into a <see cref="ITypeCollection" />.</summary>
        /// <param name="this">The types to convert.</param>
        /// <returns>The type collection.</returns>
        public static ITypeCollection ToTypeCollection(this IEnumerable<Type> @this) {
            return new TypeCollection(@this);
        }
    }
}
