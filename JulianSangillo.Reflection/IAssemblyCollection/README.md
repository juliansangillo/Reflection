#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection')

## IAssemblyCollection Interface

Uses the .NET Reflection API to collect all referenced assemblies given an entry assembly. Can return a  
collection of all types in the collection of assemblies.

```csharp
public interface IAssemblyCollection :
System.Collections.Generic.IEnumerable<System.Reflection.Assembly>,
System.Collections.IEnumerable
```

Derived  
&#8627; [AssemblyCollection&lt;TEntryPoint&gt;](JulianSangillo.Reflection/AssemblyCollection_TEntryPoint_/README.md 'JulianSangillo.Reflection.AssemblyCollection<TEntryPoint>')

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Properties | |
| :--- | :--- |
| [Types](JulianSangillo.Reflection/IAssemblyCollection/Types/README.md 'JulianSangillo.Reflection.IAssemblyCollection.Types') | Gets instance of [ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection') containing all types in all referenced assemblies. |
