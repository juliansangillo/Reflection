#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')

## ITypeCollection.HaveAttribute<T>(bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
JulianSangillo.Reflection.ITypeCollection HaveAttribute<T>(bool inherit=true, bool interfaces=false, bool abstracts=false)
    where T : System.Attribute;
```
#### Type parameters

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool).T'></a>

`T`

The attribute type to target.
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include type's that inherit the attribute; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that have the attribute T.