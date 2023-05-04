### [JulianSangillo.Reflection](JulianSangillo.Reflection.md 'JulianSangillo.Reflection')

## AssemblyCollection<TEntryPoint> Class

Implementation of [IAssemblyCollection](JulianSangillo.Reflection.IAssemblyCollection.md 'JulianSangillo.Reflection.IAssemblyCollection').

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

Implements [IAssemblyCollection](JulianSangillo.Reflection.IAssemblyCollection.md 'JulianSangillo.Reflection.IAssemblyCollection'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')
### Constructors

<a name='JulianSangillo.Reflection.AssemblyCollection_TEntryPoint_.AssemblyCollection()'></a>

## AssemblyCollection() Constructor

Initializes a new instance of the [AssemblyCollection&lt;TEntryPoint&gt;](JulianSangillo.Reflection.AssemblyCollection_TEntryPoint_.md 'JulianSangillo.Reflection.AssemblyCollection<TEntryPoint>') class. Uses  
reflection to collect all assemblies starting from the entry-point and initializes.

```csharp
public AssemblyCollection();
```
### Properties

<a name='JulianSangillo.Reflection.AssemblyCollection_TEntryPoint_.Types'></a>

## AssemblyCollection<TEntryPoint>.Types Property

Gets instance of [ITypeCollection](JulianSangillo.Reflection.ITypeCollection.md 'JulianSangillo.Reflection.ITypeCollection') containing all types in all referenced assemblies.

```csharp
public JulianSangillo.Reflection.ITypeCollection Types { get; }
```

Implements [Types](JulianSangillo.Reflection.IAssemblyCollection.md#JulianSangillo.Reflection.IAssemblyCollection.Types 'JulianSangillo.Reflection.IAssemblyCollection.Types')

#### Property Value
[ITypeCollection](JulianSangillo.Reflection.ITypeCollection.md 'JulianSangillo.Reflection.ITypeCollection')
### Methods

<a name='JulianSangillo.Reflection.AssemblyCollection_TEntryPoint_.GetEnumerator()'></a>

## AssemblyCollection<TEntryPoint>.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
public System.Collections.Generic.IEnumerator<System.Reflection.Assembly> GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator that can be used to iterate through the collection.
### Explicit Interface Implementations

<a name='JulianSangillo.Reflection.AssemblyCollection_TEntryPoint_.System.Collections.IEnumerable.GetEnumerator()'></a>

## AssemblyCollection<TEntryPoint>.System.Collections.IEnumerable.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')