#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')

## ITypeCollection.ImplementsGeneric(Type, bool, bool) Method

Used when you need all types that implement or inherit a generic interface. Also works when the type  
params are not known at compile time.

```csharp
JulianSangillo.Reflection.ITypeCollection ImplementsGeneric(System.Type type, bool interfaces=false, bool abstracts=false);
```
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.ImplementsGeneric(System.Type,bool,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The generic interface to target.

<a name='JulianSangillo.Reflection.ITypeCollection.ImplementsGeneric(System.Type,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.ImplementsGeneric(System.Type,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that implement or inherit the generic interface.