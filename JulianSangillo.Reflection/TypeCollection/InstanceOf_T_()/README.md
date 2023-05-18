#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection')

## TypeCollection.InstanceOf<T>() Method

Used when you need instances of all types that are assignable to a given type.

```csharp
public System.Collections.Generic.IEnumerable<T> InstanceOf<T>()
    where T : class;
```
#### Type parameters

<a name='JulianSangillo.Reflection.TypeCollection.InstanceOf_T_().T'></a>

`T`

The reference type to target.

Implements [InstanceOf&lt;T&gt;()](JulianSangillo.Reflection/ITypeCollection/InstanceOf_T_()/README.md 'JulianSangillo.Reflection.ITypeCollection.InstanceOf<T>()')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](JulianSangillo.Reflection/TypeCollection/InstanceOf_T_()/README.md#JulianSangillo.Reflection.TypeCollection.InstanceOf_T_().T 'JulianSangillo.Reflection.TypeCollection.InstanceOf<T>().T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Collection of new instances of all types that are assignable to T.