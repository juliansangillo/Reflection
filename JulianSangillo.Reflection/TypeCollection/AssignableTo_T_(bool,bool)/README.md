#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection')

## TypeCollection.AssignableTo<T>(bool, bool) Method

Used when you need all types whose instances are assignable to a given type.

```csharp
public JulianSangillo.Reflection.ITypeCollection AssignableTo<T>(bool interfaces=false, bool abstracts=false)
    where T : class;
```
#### Type parameters

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo_T_(bool,bool).T'></a>

`T`

The reference type to target.
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo_T_(bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo_T_(bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

Implements [AssignableTo&lt;T&gt;(bool, bool)](JulianSangillo.Reflection/ITypeCollection/AssignableTo_T_(bool,bool)/README.md 'JulianSangillo.Reflection.ITypeCollection.AssignableTo<T>(bool, bool)')

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that are assignable to T.