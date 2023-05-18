#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')

## ITypeCollection.InstanceOf(Type) Method

Used when you need instances of all types that are assignable to a given type.

```csharp
System.Collections.Generic.IEnumerable<object> InstanceOf(System.Type type);
```
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.InstanceOf(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The reference type to target.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Collection of new instances of all types that are assignable to the given type.