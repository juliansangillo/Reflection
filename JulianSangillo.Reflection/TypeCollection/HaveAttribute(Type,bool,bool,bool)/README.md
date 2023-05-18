#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection')

## TypeCollection.HaveAttribute(Type, bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
public JulianSangillo.Reflection.ITypeCollection HaveAttribute(System.Type type, bool inherit=true, bool interfaces=false, bool abstracts=false);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type,bool,bool,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The attribute type to target.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type,bool,bool,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include type's that inherit the attribute; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type,bool,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type,bool,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

Implements [HaveAttribute(Type, bool, bool, bool)](JulianSangillo.Reflection/ITypeCollection/HaveAttribute(Type,bool,bool,bool)/README.md 'JulianSangillo.Reflection.ITypeCollection.HaveAttribute(System.Type, bool, bool, bool)')

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that have the given attribute type.