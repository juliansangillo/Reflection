### [JulianSangillo.Reflection](JulianSangillo.Reflection/README.md 'JulianSangillo.Reflection')

## TypeCollection Class

Implementation of [ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection').

```csharp
public class TypeCollection :
JulianSangillo.Reflection.ITypeCollection,
System.Collections.Generic.IEnumerable<System.Type>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TypeCollection

Implements [ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')
### Constructors

<a name='JulianSangillo.Reflection.TypeCollection.TypeCollection(JulianSangillo.Reflection.IAssemblyCollection)'></a>

## TypeCollection(IAssemblyCollection) Constructor

Initializes a new instance of the [TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection') class that uses reflection to collect  
all types in all given assemblies.

```csharp
protected internal TypeCollection(JulianSangillo.Reflection.IAssemblyCollection assemblies);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.TypeCollection(JulianSangillo.Reflection.IAssemblyCollection).assemblies'></a>

`assemblies` [IAssemblyCollection](JulianSangillo.Reflection/IAssemblyCollection/README.md 'JulianSangillo.Reflection.IAssemblyCollection')

The assemblies to collect types from.

<a name='JulianSangillo.Reflection.TypeCollection.TypeCollection(System.Collections.Generic.IEnumerable_System.Type_)'></a>

## TypeCollection(IEnumerable<Type>) Constructor

Initializes a new instance of the [TypeCollection](JulianSangillo.Reflection/TypeCollection/README.md 'JulianSangillo.Reflection.TypeCollection') class from an enumerable of types.

```csharp
public TypeCollection(System.Collections.Generic.IEnumerable<System.Type> types);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.TypeCollection(System.Collections.Generic.IEnumerable_System.Type_).types'></a>

`types` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The types to initialize the collection with.
### Methods

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo(System.Type,bool,bool)'></a>

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

Implements [AssignableTo(Type, bool, bool)](JulianSangillo.Reflection/ITypeCollection/README.md#JulianSangillo.Reflection.ITypeCollection.AssignableTo(System.Type,bool,bool) 'JulianSangillo.Reflection.ITypeCollection.AssignableTo(System.Type, bool, bool)')

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that are assignable to the given type.

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo_T_(bool,bool)'></a>

## TypeCollection.AssignableTo<T>(bool, bool) Method

Used when you need all types whose instances are assignable to a given type.

```csharp
public JulianSangillo.Reflection.ITypeCollection AssignableTo<T>(bool interfaces=false, bool abstracts=false)
    where T : class;
```
#### Type parameters

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo_T_(bool,bool).T'></a>

`T`

The reference type to target.
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo_T_(bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.AssignableTo_T_(bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

Implements [AssignableTo&lt;T&gt;(bool, bool)](JulianSangillo.Reflection/ITypeCollection/README.md#JulianSangillo.Reflection.ITypeCollection.AssignableTo_T_(bool,bool) 'JulianSangillo.Reflection.ITypeCollection.AssignableTo<T>(bool, bool)')

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that are assignable to T.

<a name='JulianSangillo.Reflection.TypeCollection.GetEnumerator()'></a>

## TypeCollection.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
public System.Collections.Generic.IEnumerator<System.Type> GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator that can be used to iterate through the collection.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type,bool,bool,bool)'></a>

## TypeCollection.HaveAttribute(Type, bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
public JulianSangillo.Reflection.ITypeCollection HaveAttribute(System.Type type, bool inherit=true, bool interfaces=false, bool abstracts=false);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type,bool,bool,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The attribute type to target.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type,bool,bool,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include type's that inherit the attribute; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type,bool,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute(System.Type,bool,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

Implements [HaveAttribute(Type, bool, bool, bool)](JulianSangillo.Reflection/ITypeCollection/README.md#JulianSangillo.Reflection.ITypeCollection.HaveAttribute(System.Type,bool,bool,bool) 'JulianSangillo.Reflection.ITypeCollection.HaveAttribute(System.Type, bool, bool, bool)')

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that have the given attribute type.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute_T_(bool,bool,bool)'></a>

## TypeCollection.HaveAttribute<T>(bool, bool, bool) Method

Used when you need all types that have a specific attribute.

```csharp
public JulianSangillo.Reflection.ITypeCollection HaveAttribute<T>(bool inherit=true, bool interfaces=false, bool abstracts=false)
    where T : System.Attribute;
```
#### Type parameters

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute_T_(bool,bool,bool).T'></a>

`T`

The attribute type to target.
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute_T_(bool,bool,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include type's that inherit the attribute; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute_T_(bool,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.HaveAttribute_T_(bool,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

Implements [HaveAttribute&lt;T&gt;(bool, bool, bool)](JulianSangillo.Reflection/ITypeCollection/README.md#JulianSangillo.Reflection.ITypeCollection.HaveAttribute_T_(bool,bool,bool) 'JulianSangillo.Reflection.ITypeCollection.HaveAttribute<T>(bool, bool, bool)')

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that have the attribute T.

<a name='JulianSangillo.Reflection.TypeCollection.ImplementsGeneric(System.Type,bool,bool)'></a>

## TypeCollection.ImplementsGeneric(Type, bool, bool) Method

Used when you need all types that implement or inherit a generic interface. Also works when the type  
params are not known at compile time.

```csharp
public JulianSangillo.Reflection.ITypeCollection ImplementsGeneric(System.Type type, bool interfaces=false, bool abstracts=false);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.ImplementsGeneric(System.Type,bool,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The generic interface to target.

<a name='JulianSangillo.Reflection.TypeCollection.ImplementsGeneric(System.Type,bool,bool).interfaces'></a>

`interfaces` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include interface types in output; otherwise, false.

<a name='JulianSangillo.Reflection.TypeCollection.ImplementsGeneric(System.Type,bool,bool).abstracts'></a>

`abstracts` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true to include abstract types in output; otherwise, false.

Implements [ImplementsGeneric(Type, bool, bool)](JulianSangillo.Reflection/ITypeCollection/README.md#JulianSangillo.Reflection.ITypeCollection.ImplementsGeneric(System.Type,bool,bool) 'JulianSangillo.Reflection.ITypeCollection.ImplementsGeneric(System.Type, bool, bool)')

#### Returns
[ITypeCollection](JulianSangillo.Reflection/ITypeCollection/README.md 'JulianSangillo.Reflection.ITypeCollection')  
The types that implement or inherit the generic interface.

<a name='JulianSangillo.Reflection.TypeCollection.InstanceOf(System.Type)'></a>

## TypeCollection.InstanceOf(Type) Method

Used when you need instances of all types that are assignable to a given type.

```csharp
public System.Collections.Generic.IEnumerable<object> InstanceOf(System.Type type);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.InstanceOf(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The reference type to target.

Implements [InstanceOf(Type)](JulianSangillo.Reflection/ITypeCollection/README.md#JulianSangillo.Reflection.ITypeCollection.InstanceOf(System.Type) 'JulianSangillo.Reflection.ITypeCollection.InstanceOf(System.Type)')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Collection of new instances of all types that are assignable to the given type.

<a name='JulianSangillo.Reflection.TypeCollection.InstanceOf_T_()'></a>

## TypeCollection.InstanceOf<T>() Method

Used when you need instances of all types that are assignable to a given type.

```csharp
public System.Collections.Generic.IEnumerable<T> InstanceOf<T>()
    where T : class;
```
#### Type parameters

<a name='JulianSangillo.Reflection.TypeCollection.InstanceOf_T_().T'></a>

`T`

The reference type to target.

Implements [InstanceOf&lt;T&gt;()](JulianSangillo.Reflection/ITypeCollection/README.md#JulianSangillo.Reflection.ITypeCollection.InstanceOf_T_() 'JulianSangillo.Reflection.ITypeCollection.InstanceOf<T>()')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](JulianSangillo.Reflection/TypeCollection/README.md#JulianSangillo.Reflection.TypeCollection.InstanceOf_T_().T 'JulianSangillo.Reflection.TypeCollection.InstanceOf<T>().T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Collection of new instances of all types that are assignable to T.

<a name='JulianSangillo.Reflection.TypeCollection.WithName(string)'></a>

## TypeCollection.WithName(string) Method

Used when you need the type instance and you know the exact name of the type.

```csharp
public System.Type WithName(string name);
```
#### Parameters

<a name='JulianSangillo.Reflection.TypeCollection.WithName(string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of a type in the referenced assemblies.

Implements [WithName(string)](JulianSangillo.Reflection/ITypeCollection/README.md#JulianSangillo.Reflection.ITypeCollection.WithName(string) 'JulianSangillo.Reflection.ITypeCollection.WithName(string)')

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type with the given name.
### Explicit Interface Implementations

<a name='JulianSangillo.Reflection.TypeCollection.System.Collections.IEnumerable.GetEnumerator()'></a>

## TypeCollection.System.Collections.IEnumerable.GetEnumerator() Method

Returns an enumerator that iterates through the collection.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')