#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection')

## TypeCollection.InstanceOf(Type) Method

Used when you need instances of all types that are assignable to a given type.

```csharp
public System.Collections.Generic.IEnumerable<object> InstanceOf(System.Type type);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.InstanceOf(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The reference type to target.

Implements [InstanceOf(Type)](JulianSangillo.Reflection/ITypeCollection/InstanceOf(Type)/README.md 'JulianSangillo.Reflection.ITypeCollection.InstanceOf(System.Type)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Collection of new instances of all types that are assignable to the given type.