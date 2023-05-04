# ITypeCollection

#### [JulianSangillo.Reflection](./)

### ITypeCollection Interface

Collection of types in an assembly or collection of assemblies.

```csharp
public interface ITypeCollection :
System.Collections.Generic.IEnumerable<System.Type>,
System.Collections.IEnumerable
```

Derived\
↳ [TypeCollection](juliansangillo.reflection.typecollection.md)

Implements [System.Collections.Generic.IEnumerable<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable)

#### Methods

### ITypeCollection.AssignableTo(Type, bool, bool) Method

Used when you need all types whose instances are assignable to a given type. Does not work with\
generics whose type params are not known at compile time. For generic interfaces whose type params may\
not be known, see ImplementsGeneric.

```csharp
JulianSangillo.Reflection.ITypeCollection AssignableTo(System.Type type, bool interfaces=false, bool abstracts=false);
```

**Parameters**

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)

The reference type to target.

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include interface types in output; otherwise, false.

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include abstract types in output; otherwise, false.

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that are assignable to the given type.

### ITypeCollection.AssignableTo(bool, bool) Method

Used when you need all types whose instances are assignable to a given type.

```csharp
JulianSangillo.Reflection.ITypeCollection AssignableTo<T>(bool interfaces=false, bool abstracts=false)
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

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that are assignable to T.

### ITypeCollection.HaveAttribute(Type, bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
JulianSangillo.Reflection.ITypeCollection HaveAttribute(System.Type type, bool inherit=true, bool interfaces=false, bool abstracts=false);
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

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that have the given attribute type.

### ITypeCollection.HaveAttribute(bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
JulianSangillo.Reflection.ITypeCollection HaveAttribute<T>(bool inherit=true, bool interfaces=false, bool abstracts=false)
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

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that have the attribute T.

### ITypeCollection.ImplementsGeneric(Type, bool, bool) Method

Used when you need all types that implement or inherit a generic interface. Also works when the type\
params are not known at compile time.

```csharp
JulianSangillo.Reflection.ITypeCollection ImplementsGeneric(System.Type type, bool interfaces=false, bool abstracts=false);
```

**Parameters**

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)

The generic interface to target.

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include interface types in output; otherwise, false.

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean)

true to include abstract types in output; otherwise, false.

**Returns**

[ITypeCollection](juliansangillo.reflection.itypecollection.md)\
The types that implement or inherit the generic interface.

### ITypeCollection.InstanceOf(Type) Method

Used when you need instances of all types that are assignable to a given type.

```csharp
System.Collections.Generic.IEnumerable<object> InstanceOf(System.Type type);
```

**Parameters**

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)

The reference type to target.

**Returns**

[System.Collections.Generic.IEnumerable<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\
Collection of new instances of all types that are assignable to the given type.

### ITypeCollection.InstanceOf() Method

Used when you need instances of all types that are assignable to a given type.

```csharp
System.Collections.Generic.IEnumerable<T> InstanceOf<T>()
    where T : class;
```

**Type parameters**

`T`

The reference type to target.

**Returns**

[System.Collections.Generic.IEnumerable<](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)[T](juliansangillo.reflection.itypecollection.md#JulianSangillo.Reflection.ITypeCollection.InstanceOf\_T\_\(\).T)[>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\
Collection of new instances of all types that are assignable to T.

### ITypeCollection.WithName(string) Method

Used when you need the type instance and you know the exact name of the type.

```csharp
System.Type WithName(string name);
```

**Parameters**

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String)

The name of a type in the referenced assemblies.

**Returns**

[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type)\
The type with the given name.
