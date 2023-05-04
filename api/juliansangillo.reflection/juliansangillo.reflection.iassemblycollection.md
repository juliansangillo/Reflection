# IAssemblyCollection

#### [JulianSangillo.Reflection](./)

### IAssemblyCollection Interface

Uses the .NET Reflection API to collect all referenced assemblies given an entry assembly. Can return a\
collection of all types in the collection of assemblies.

```csharp
public interface IAssemblyCollection :
System.Collections.Generic.IEnumerable<System.Reflection.Assembly>,
System.Collections.IEnumerable
```

Derived\
↳ [AssemblyCollection\<TEntryPoint>](juliansangillo.reflection.assemblycollection\_tentrypoint\_.md)

Implements [System.Collections.Generic.IEnumerable<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable)

#### Properties

### IAssemblyCollection.Types Property

Gets instance of [ITypeCollection](juliansangillo.reflection.itypecollection.md) containing all types in all referenced assemblies.

```csharp
JulianSangillo.Reflection.ITypeCollection Types { get; }
```

**Property Value**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)
