# AssemblyCollection\_TEntryPoint\_

#### [JulianSangillo.Reflection](./)

### AssemblyCollection Class

Implementation of [IAssemblyCollection](juliansangillo.reflection.iassemblycollection.md).

```csharp
public class AssemblyCollection<TEntryPoint> :
JulianSangillo.Reflection.IAssemblyCollection,
System.Collections.Generic.IEnumerable<System.Reflection.Assembly>,
System.Collections.IEnumerable
```

**Type parameters**

`TEntryPoint`

Type used to get the entry-point assembly. All assemblies are collected by starting with the\
entry-point, collecting its dependencies, and their dependencies. The entry-point type could\
be any type that is defined in the entry-point assembly.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object)  AssemblyCollection

Implements [IAssemblyCollection](juliansangillo.reflection.iassemblycollection.md), [System.Collections.Generic.IEnumerable<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable)

#### Constructors

### AssemblyCollection() Constructor

Initializes a new instance of the [AssemblyCollection\<TEntryPoint>](juliansangillo.reflection.assemblycollection\_tentrypoint\_.md) class. Uses\
reflection to collect all assemblies starting from the entry-point and initializes.

```csharp
public AssemblyCollection();
```

#### Properties

### AssemblyCollection.Types Property

Gets instance of [ITypeCollection](juliansangillo.reflection.itypecollection.md) containing all types in all referenced assemblies.

```csharp
public JulianSangillo.Reflection.ITypeCollection Types { get; }
```

Implements [Types](juliansangillo.reflection.iassemblycollection.md#JulianSangillo.Reflection.IAssemblyCollection.Types)

**Property Value**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)

#### Methods

### AssemblyCollection.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
public System.Collections.Generic.IEnumerator<System.Reflection.Assembly> GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator)

**Returns**

[System.Collections.Generic.IEnumerator<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1)[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1)\
An enumerator that can be used to iterate through the collection.

#### Explicit Interface Implementations

### AssemblyCollection.System.Collections.IEnumerable.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator)
