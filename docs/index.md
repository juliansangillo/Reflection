# JulianSangillo.Reflection

Reflection library for parsing .NET assemblies and types

### What's Included?

#### AssemblyCollection

Uses the .NET Reflection API to collect all referenced assemblies given an entry assembly. Can return a collection of
all types in the collection of assemblies.

#### TypeCollection

Collection of types in an assembly or collection of assemblies.

#### ToTypeCollection Extension Method

Converts an enumerable of types into a TypeCollection.
