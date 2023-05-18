#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')

## ITypeCollection.AssignableTo<T>(bool, bool) Method

Used when you need all types whose instances are assignable to a given type.

```csharp
JulianSangillo.Reflection.ITypeCollection AssignableTo<T>(bool interfaces=false, bool abstracts=false)
    where T : class;
```
#### Type parameters

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo_T_(bool,bool).T'></a>

`T`

The reference type to target.
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo_T_(bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo_T_(bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that are assignable to T.