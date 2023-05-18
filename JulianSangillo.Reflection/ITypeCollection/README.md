#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection')

## ITypeCollection Interface

Collection of types in an assembly or collection of assemblies.

```csharp
public interface ITypeCollection :
System.Collections.Generic.IEnumerable<System.Type>,
System.Collections.IEnumerable
```

Derived  
&#8627; [TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection')

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Methods | |
| :--- | :--- |
| [AssignableTo(Type, bool, bool)](JulianSangillo.Reflection/ITypeCollection/AssignableTo(Type,bool,bool)/README.md 'JulianSangillo.Reflection.ITypeCollection.AssignableTo(System.Type, bool, bool)') | Used when you need all types whose instances are assignable to a given type. Does not work with<br/>generics whose type params are not known at compile time. For generic interfaces whose type params may<br/>not be known, see ImplementsGeneric. |
| [AssignableTo&lt;T&gt;(bool, bool)](JulianSangillo.Reflection/ITypeCollection/AssignableTo_T_(bool,bool)/README.md 'JulianSangillo.Reflection.ITypeCollection.AssignableTo<T>(bool, bool)') | Used when you need all types whose instances are assignable to a given type. |
| [HaveAttribute(Type, bool, bool, bool)](JulianSangillo.Reflection/ITypeCollection/HaveAttribute(Type,bool,bool,bool)/README.md 'JulianSangillo.Reflection.ITypeCollection.HaveAttribute(System.Type, bool, bool, bool)') | Used when you need all types that have a specific attribute. |
| [HaveAttribute&lt;T&gt;(bool, bool, bool)](JulianSangillo.Reflection/ITypeCollection/HaveAttribute_T_(bool,bool,bool)/README.md 'JulianSangillo.Reflection.ITypeCollection.HaveAttribute<T>(bool, bool, bool)') | Used when you need all types that have a specific attribute. |
| [ImplementsGeneric(Type, bool, bool)](JulianSangillo.Reflection/ITypeCollection/ImplementsGeneric(Type,bool,bool)/README.md 'JulianSangillo.Reflection.ITypeCollection.ImplementsGeneric(System.Type, bool, bool)') | Used when you need all types that implement or inherit a generic interface. Also works when the type<br/>params are not known at compile time. |
| [InstanceOf(Type)](JulianSangillo.Reflection/ITypeCollection/InstanceOf(Type)/README.md 'JulianSangillo.Reflection.ITypeCollection.InstanceOf(System.Type)') | Used when you need instances of all types that are assignable to a given type. |
| [InstanceOf&lt;T&gt;()](JulianSangillo.Reflection/ITypeCollection/InstanceOf_T_()/README.md 'JulianSangillo.Reflection.ITypeCollection.InstanceOf<T>()') | Used when you need instances of all types that are assignable to a given type. |
| [WithName(string)](JulianSangillo.Reflection/ITypeCollection/WithName(string)/README.md 'JulianSangillo.Reflection.ITypeCollection.WithName(string)') | Used when you need the type instance and you know the exact name of the type. |
