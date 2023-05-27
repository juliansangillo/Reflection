### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection')

## ITypeCollection Interface

Collection of types in an assembly or collection of assemblies.

```csharp
public interface ITypeCollection :
System.Collections.Generic.IEnumerable<System.Type>,
System.Collections.IEnumerable
```

Derived  
&#8627; [TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection')

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')
### Methods

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo(System.Type,bool,bool)'></a>

## ITypeCollection.AssignableTo(Type, bool, bool) Method

Used when you need all types whose instances are assignable to a given type. Does not work with  
generics whose type params are not known at compile time. For generic interfaces whose type params may  
not be known, see ImplementsGeneric.

```csharp
JulianSangillo.Reflection.ITypeCollection AssignableTo(System.Type type, bool interfaces=false, bool abstracts=false);
```
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo(System.Type,bool,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The reference type to target.

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo(System.Type,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo(System.Type,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that are assignable to the given type.

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo_T_(bool,bool)'></a>

## ITypeCollection.AssignableTo<T>(bool, bool) Method

Used when you need all types whose instances are assignable to a given type.

```csharp
JulianSangillo.Reflection.ITypeCollection AssignableTo<T>(bool interfaces=false, bool abstracts=false)
    where T : class;
```
#### Type parameters

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo_T_(bool,bool).T'></a>

`T`

The reference type to target.
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo_T_(bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.AssignableTo_T_(bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that are assignable to T.

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute(System.Type,bool,bool,bool)'></a>

## ITypeCollection.HaveAttribute(Type, bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
JulianSangillo.Reflection.ITypeCollection HaveAttribute(System.Type type, bool inherit=true, bool interfaces=false, bool abstracts=false);
```
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute(System.Type,bool,bool,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The attribute type to target.

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute(System.Type,bool,bool,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include type's that inherit the attribute; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute(System.Type,bool,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute(System.Type,bool,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that have the given attribute type.

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool)'></a>

## ITypeCollection.HaveAttribute<T>(bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
JulianSangillo.Reflection.ITypeCollection HaveAttribute<T>(bool inherit=true, bool interfaces=false, bool abstracts=false)
    where T : System.Attribute;
```
#### Type parameters

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool).T'></a>

`T`

The attribute type to target.
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include type's that inherit the attribute; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that have the attribute T.

<a name='JulianSangillo.Reflection.ITypeCollection.ImplementsGeneric(System.Type,bool,bool)'></a>

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

<a name='JulianSangillo.Reflection.ITypeCollection.InstanceOf(System.Type)'></a>

## ITypeCollection.InstanceOf(Type) Method

Used when you need instances of all types that are assignable to a given type.

```csharp
System.Collections.Generic.IEnumerable<object> InstanceOf(System.Type type);
```
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.InstanceOf(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The reference type to target.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Collection of new instances of all types that are assignable to the given type.

<a name='JulianSangillo.Reflection.ITypeCollection.InstanceOf_T_()'></a>

## ITypeCollection.InstanceOf<T>() Method

Used when you need instances of all types that are assignable to a given type.

```csharp
System.Collections.Generic.IEnumerable<T> InstanceOf<T>()
    where T : class;
```
#### Type parameters

<a name='JulianSangillo.Reflection.ITypeCollection.InstanceOf_T_().T'></a>

`T`

The reference type to target.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](JulianSangillo.Reflection/ITypeCollection/README.md#JulianSangillo.Reflection.ITypeCollection.InstanceOf_T_().T 'JulianSangillo.Reflection.ITypeCollection.InstanceOf<T>().T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Collection of new instances of all types that are assignable to T.

<a name='JulianSangillo.Reflection.ITypeCollection.WithName(string)'></a>

## ITypeCollection.WithName(string) Method

Used when you need the type instance and you know the exact name of the type.

```csharp
System.Type WithName(string name);
```
#### Parameters

<a name='JulianSangillo.Reflection.ITypeCollection.WithName(string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of a type in the referenced assemblies.

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type with the given name.