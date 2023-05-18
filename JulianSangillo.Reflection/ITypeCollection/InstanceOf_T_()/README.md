#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')

## ITypeCollection.InstanceOf<T>() Method

Used when you need instances of all types that are assignable to a given type.

```csharp
System.Collections.Generic.IEnumerable<T> InstanceOf<T>()
    where T : class;
```
#### Type parameters

<a name='JulianSangillo.Reflection.ITypeCollection.InstanceOf_T_().T'></a>

`T`

The reference type to target.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](JulianSangillo.Reflection/ITypeCollection/InstanceOf_T_()/README.md#JulianSangillo.Reflection.ITypeCollection.InstanceOf_T_().T 'JulianSangillo.Reflection.ITypeCollection.InstanceOf<T>().T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Collection of new instances of all types that are assignable to T.