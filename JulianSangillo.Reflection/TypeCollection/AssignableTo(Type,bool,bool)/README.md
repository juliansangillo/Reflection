#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection').[TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection')

## TypeCollection.AssignableTo(Type, bool, bool) Method

Used when you need all types whose instances are assignable to a given type. Does not work with  
generics whose type params are not known at compile time. For generic interfaces whose type params may  
not be known, see ImplementsGeneric.

```csharp
public JulianSangillo.Reflection.ITypeCollection AssignableTo(System.Type type, bool interfaces=false, bool abstracts=false);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo(System.Type,bool,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The reference type to target.

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo(System.Type,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo(System.Type,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

Implements [AssignableTo(Type, bool, bool)](JulianSangillo.Reflection/ITypeCollection/AssignableTo(Type,bool,bool)/README.md 'JulianSangillo.Reflection.ITypeCollection.AssignableTo(System.Type, bool, bool)')

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that are assignable to the given type.