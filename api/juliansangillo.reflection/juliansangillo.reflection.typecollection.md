# TypeCollection

#### [JulianSangillo.Reflection](./)

### TypeCollection Class

Implementation of [ITypeCollection](juliansangillo.reflection.itypecollection.md).

```csharp
public class TypeCollection :
JulianSangillo.Reflection.ITypeCollection,
System.Collections.Generic.IEnumerable<System.Type>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object)  TypeCollection

Implements [ITypeCollection](juliansangillo.reflection.itypecollection.md), [System.Collections.Generic.IEnumerable<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable)

#### Constructors

### TypeCollection(IAssemblyCollection) Constructor

Initializes a new instance of the [TypeCollection](juliansangillo.reflection.typecollection.md) class that uses reflection to collect\
all types in all given assemblies.

```csharp
protected internal TypeCollection(JulianSangillo.Reflection.IAssemblyCollection assemblies);
```

**Parameters**

`assemblies` [IAssemblyCollection](juliansangillo.reflection.iassemblycollection.md)

The assemblies to collect types from.

### TypeCollection(IEnumerable) Constructor

Initializes a new instance of the [TypeCollection](juliansangillo.reflection.typecollection.md) class from an enumerable of types.

```csharp
public TypeCollection(System.Collections.Generic.IEnumerable<System.Type> types);
```

**Parameters**

`types` [System.Collections.Generic.IEnumerable<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)

The types to initialize the collection with.

#### Methods

### TypeCollection.AssignableTo(Type, bool, bool) Method

Used when you need all types whose instances are assignable to a given type. Does not work with\
generics whose type params are not known at compile time. For generic interfaces whose type params may\
not be known, see ImplementsGeneric.

```csharp
public JulianSangillo.Reflection.ITypeCollection AssignableTo(System.Type type, bool interfaces=false, bool abstracts=false);
```

**Parameters**

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)

The reference type to target.

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include interface types in output; otherwise, false.

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include abstract types in output; otherwise, false.

Implements [AssignableTo(Type, bool, bool)](juliansangillo.reflection.itypecollection.md#JulianSangillo.Reflection.ITypeCollection.AssignableTo\(System.Type,bool,bool\))

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that are assignable to the given type.

### TypeCollection.AssignableTo(bool, bool) Method

Used when you need all types whose instances are assignable to a given type.

```csharp
public JulianSangillo.Reflection.ITypeCollection AssignableTo<T>(bool interfaces=false, bool abstracts=false)
    where T : class;
```

**Type parameters**

`T`

The reference type to target.

**Parameters**

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include interface types in output; otherwise, false.

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include abstract types in output; otherwise, false.

Implements [AssignableTo\<T>(bool, bool)](juliansangillo.reflection.itypecollection.md#JulianSangillo.Reflection.ITypeCollection.AssignableTo\_T\_\(bool,bool\))

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that are assignable to T.

### TypeCollection.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
public System.Collections.Generic.IEnumerator<System.Type> GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator)

**Returns**

[System.Collections.Generic.IEnumerator<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1)[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1)\
An enumerator that can be used to iterate through the collection.

### TypeCollection.HaveAttribute(Type, bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
public JulianSangillo.Reflection.ITypeCollection HaveAttribute(System.Type type, bool inherit=true, bool interfaces=false, bool abstracts=false);
```

**Parameters**

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)

The attribute type to target.

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include type's that inherit the attribute; otherwise, false.

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include interface types in output; otherwise, false.

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include abstract types in output; otherwise, false.

Implements [HaveAttribute(Type, bool, bool, bool)](juliansangillo.reflection.itypecollection.md#JulianSangillo.Reflection.ITypeCollection.HaveAttribute\(System.Type,bool,bool,bool\))

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that have the given attribute type.

### TypeCollection.HaveAttribute(bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
public JulianSangillo.Reflection.ITypeCollection HaveAttribute<T>(bool inherit=true, bool interfaces=false, bool abstracts=false)
    where T : System.Attribute;
```

**Type parameters**

`T`

The attribute type to target.

**Parameters**

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include type's that inherit the attribute; otherwise, false.

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include interface types in output; otherwise, false.

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include abstract types in output; otherwise, false.

Implements [HaveAttribute\<T>(bool, bool, bool)](juliansangillo.reflection.itypecollection.md#JulianSangillo.Reflection.ITypeCollection.HaveAttribute\_T\_\(bool,bool,bool\))

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that have the attribute T.

### TypeCollection.ImplementsGeneric(Type, bool, bool) Method

Used when you need all types that implement or inherit a generic interface. Also works when the type\
params are not known at compile time.

```csharp
public JulianSangillo.Reflection.ITypeCollection ImplementsGeneric(System.Type type, bool interfaces=false, bool abstracts=false);
```

**Parameters**

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)

The generic interface to target.

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include interface types in output; otherwise, false.

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include abstract types in output; otherwise, false.

Implements [ImplementsGeneric(Type, bool, bool)](juliansangillo.reflection.itypecollection.md#JulianSangillo.Reflection.ITypeCollection.ImplementsGeneric\(System.Type,bool,bool\))

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that implement or inherit the generic interface.

### TypeCollection.InstanceOf(Type) Method

Used when you need instances of all types that are assignable to a given type.

```csharp
public System.Collections.Generic.IEnumerable<object> InstanceOf(System.Type type);
```

**Parameters**

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)

The reference type to target.

Implements [InstanceOf(Type)](juliansangillo.reflection.itypecollection.md#JulianSangillo.Reflection.ITypeCollection.InstanceOf\(System.Type\))

**Returns**

[System.Collections.Generic.IEnumerable<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\
Collection of new instances of all types that are assignable to the given type.

### TypeCollection.InstanceOf() Method

Used when you need instances of all types that are assignable to a given type.

```csharp
public System.Collections.Generic.IEnumerable<T> InstanceOf<T>()
    where T : class;
```

**Type parameters**

`T`

The reference type to target.

Implements [InstanceOf\<T>()](juliansangillo.reflection.itypecollection.md#JulianSangillo.Reflection.ITypeCollection.InstanceOf\_T\_\(\))

**Returns**

[System.Collections.Generic.IEnumerable<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)[T](juliansangillo.reflection.typecollection.md#JulianSangillo.Reflection.TypeCollection.InstanceOf\_T\_\(\).T)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\
Collection of new instances of all types that are assignable to T.

### TypeCollection.WithName(string) Method

Used when you need the type instance and you know the exact name of the type.

```csharp
public System.Type WithName(string name);
```

**Parameters**

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String)

The name of a type in the referenced assemblies.

Implements [WithName(string)](juliansangillo.reflection.itypecollection.md#JulianSangillo.Reflection.ITypeCollection.WithName\(string\))

**Returns**

[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)\
The type with the given name.

#### Explicit Interface Implementations

### TypeCollection.System.Collections.IEnumerable.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator)
