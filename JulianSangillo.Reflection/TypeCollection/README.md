#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection')

## TypeCollection Class

Implementation of [ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection').

```csharp
public class TypeCollection :
JulianSangillo.Reflection.ITypeCollection,
System.Collections.Generic.IEnumerable<System.Type>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TypeCollection

Implements [ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [TypeCollection(IAssemblyCollection)](JulianSangillo.Reflection/TypeCollection/TypeCollection(IAssemblyCollection)/README.md 'JulianSangillo.Reflection.TypeCollection.TypeCollection(JulianSangillo.Reflection.IAssemblyCollection)') | Initializes a new instance of the [TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection') class that uses reflection to collect<br/>all types in all given assemblies. |
| [TypeCollection(IEnumerable&lt;Type&gt;)](JulianSangillo.Reflection/TypeCollection/TypeCollection(IEnumerable_Type_)/README.md 'JulianSangillo.Reflection.TypeCollection.TypeCollection(System.Collections.Generic.IEnumerable<System.Type>)') | Initializes a new instance of the [TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection') class from an enumerable of types. |

| Methods | |
| :--- | :--- |
| [AssignableTo(Type, bool, bool)](JulianSangillo.Reflection/TypeCollection/AssignableTo(Type,bool,bool)/README.md 'JulianSangillo.Reflection.TypeCollection.AssignableTo(System.Type, bool, bool)') | Used when you need all types whose instances are assignable to a given type. Does not work with<br/>generics whose type params are not known at compile time. For generic interfaces whose type params may<br/>not be known, see ImplementsGeneric. |
| [AssignableTo&lt;T&gt;(bool, bool)](JulianSangillo.Reflection/TypeCollection/AssignableTo_T_(bool,bool)/README.md 'JulianSangillo.Reflection.TypeCollection.AssignableTo<T>(bool, bool)') | Used when you need all types whose instances are assignable to a given type. |
| [GetEnumerator()](JulianSangillo.Reflection/TypeCollection/GetEnumerator()/README.md 'JulianSangillo.Reflection.TypeCollection.GetEnumerator()') | Returns an enumerator that iterates through the collection. |
| [HaveAttribute(Type, bool, bool, bool)](JulianSangillo.Reflection/TypeCollection/HaveAttribute(Type,bool,bool,bool)/README.md 'JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type, bool, bool, bool)') | Used when you need all types that have a specific attribute. |
| [HaveAttribute&lt;T&gt;(bool, bool, bool)](JulianSangillo.Reflection/TypeCollection/HaveAttribute_T_(bool,bool,bool)/README.md 'JulianSangillo.Reflection.TypeCollection.HaveAttribute<T>(bool, bool, bool)') | Used when you need all types that have a specific attribute. |
| [ImplementsGeneric(Type, bool, bool)](JulianSangillo.Reflection/TypeCollection/ImplementsGeneric(Type,bool,bool)/README.md 'JulianSangillo.Reflection.TypeCollection.ImplementsGeneric(System.Type, bool, bool)') | Used when you need all types that implement or inherit a generic interface. Also works when the type<br/>params are not known at compile time. |
| [InstanceOf(Type)](JulianSangillo.Reflection/TypeCollection/InstanceOf(Type)/README.md 'JulianSangillo.Reflection.TypeCollection.InstanceOf(System.Type)') | Used when you need instances of all types that are assignable to a given type. |
| [InstanceOf&lt;T&gt;()](JulianSangillo.Reflection/TypeCollection/InstanceOf_T_()/README.md 'JulianSangillo.Reflection.TypeCollection.InstanceOf<T>()') | Used when you need instances of all types that are assignable to a given type. |
| [WithName(string)](JulianSangillo.Reflection/TypeCollection/WithName(string)/README.md 'JulianSangillo.Reflection.TypeCollection.WithName(string)') | Used when you need the type instance and you know the exact name of the type. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](JulianSangillo.Reflection/TypeCollection/System.Collections.IEnumerable.GetEnumerator()/README.md 'JulianSangillo.Reflection.TypeCollection.System.Collections.IEnumerable.GetEnumerator()') | Returns an enumerator that iterates through the collection. |
