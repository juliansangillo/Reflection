#### [JulianSangillo.Reflection](JulianSangillo.Reflection/AssemblyInfo.md 'index')
### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection')

## AssemblyCollection<TEntryPoint> Class

Implementation of [IAssemblyCollection](JulianSangillo.Reflection/IAssemblyCollection/README.md 'JulianSangillo.Reflection.IAssemblyCollection').

```csharp
public class AssemblyCollection<TEntryPoint> :
JulianSangillo.Reflection.IAssemblyCollection,
System.Collections.Generic.IEnumerable<System.Reflection.Assembly>,
System.Collections.IEnumerable
```
#### Type parameters

<a name='JulianSangillo.Reflection.AssemblyCollection_TEntryPoint_.TEntryPoint'></a>

`TEntryPoint`

Type used to get the entry-point assembly. All assemblies are collected by starting with the  
entry-point, collecting its dependencies, and their dependencies. The entry-point type could  
be any type that is defined in the entry-point assembly.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AssemblyCollection<TEntryPoint>

Implements [IAssemblyCollection](JulianSangillo.Reflection/IAssemblyCollection/README.md 'JulianSangillo.Reflection.IAssemblyCollection'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [AssemblyCollection()](JulianSangillo.Reflection/AssemblyCollection_TEntryPoint_/AssemblyCollection()/README.md 'JulianSangillo.Reflection.AssemblyCollection<TEntryPoint>.AssemblyCollection()') | Initializes a new instance of the [AssemblyCollection&lt;TEntryPoint&gt;](JulianSangillo.Reflection/AssemblyCollection_TEntryPoint_/README.md 'JulianSangillo.Reflection.AssemblyCollection<TEntryPoint>') class. Uses<br/>reflection to collect all assemblies starting from the entry-point and initializes. |

| Properties | |
| :--- | :--- |
| [Types](JulianSangillo.Reflection/AssemblyCollection_TEntryPoint_/Types/README.md 'JulianSangillo.Reflection.AssemblyCollection<TEntryPoint>.Types') | Gets instance of [ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection') containing all types in all referenced assemblies. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](JulianSangillo.Reflection/AssemblyCollection_TEntryPoint_/GetEnumerator()/README.md 'JulianSangillo.Reflection.AssemblyCollection<TEntryPoint>.GetEnumerator()') | Returns an enumerator that iterates through the collection. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](JulianSangillo.Reflection/AssemblyCollection_TEntryPoint_/System.Collections.IEnumerable.GetEnumerator()/README.md 'JulianSangillo.Reflection.AssemblyCollection<TEntryPoint>.System.Collections.IEnumerable.GetEnumerator()') | Returns an enumerator that iterates through the collection. |
