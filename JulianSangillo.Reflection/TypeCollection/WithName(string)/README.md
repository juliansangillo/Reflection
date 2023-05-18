#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection')

## TypeCollection.WithName(string) Method

Used when you need the type instance and you know the exact name of the type.

```csharp
public System.Type WithName(string name);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.WithName(string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of a type in the referenced assemblies.

Implements [WithName(string)](JulianSangillo.Reflection/ITypeCollection/WithName(string)/README.md 'JulianSangillo.Reflection.ITypeCollection.WithName(string)')

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type with the given name.