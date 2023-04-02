using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace JulianSangillo.Reflection {
    [PublicAPI]
    public interface ITypeCollection : IEnumerable<Type> {
        Type WithName(string name);
        ITypeCollection AssignableTo<T>(bool interfaces = false, bool abstracts = false) where T : class;
        ITypeCollection AssignableTo(Type type, bool interfaces = false, bool abstracts = false);
        ITypeCollection ImplementsGeneric(Type type, bool interfaces = false, bool abstracts = false);

        ITypeCollection HaveAttribute<T>(bool inherit = true, bool interfaces = false, bool abstracts = false)
            where T : Attribute;

        ITypeCollection HaveAttribute(Type type, bool inherit = true, bool interfaces = false, bool abstracts = false);
        IEnumerable<T> InstanceOf<T>() where T : class;
        IEnumerable<object> InstanceOf(Type type);
    }
}
