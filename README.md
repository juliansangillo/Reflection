# JulianSangillo.Reflection

![stable](https://img.shields.io/circleci/build/github/juliansangillo/Reflection/main?label=stable&style=plastic&token=0b65d58eac53981b0a7f23471be9115c08b278f0)
![preview](https://img.shields.io/circleci/build/github/juliansangillo/Reflection/preview?label=preview&style=plastic&token=0b65d58eac53981b0a7f23471be9115c08b278f0)
![dev](https://img.shields.io/circleci/build/github/juliansangillo/Reflection/dev?label=dev&style=plastic&token=0b65d58eac53981b0a7f23471be9115c08b278f0)  
![downloads](https://img.shields.io/nuget/dt/JulianSangillo.Reflection?style=plastic)
![issues](https://img.shields.io/github/issues/juliansangillo/Reflection?style=plastic)
![last commit](https://img.shields.io/github/last-commit/juliansangillo/Reflection/dev?style=plastic)
![license](https://img.shields.io/github/license/juliansangillo/Reflection?color=blue&style=plastic)

Reflection library for parsing .NET assemblies and types

### What's Included?

#### AssemblyCollection

Uses the .NET Reflection API to collect all referenced assemblies given an entry assembly. Can return a collection of
all types in the collection of assemblies.

#### TypeCollection

Collection of types in an assembly or collection of assemblies.

#### ToTypeCollection Extension Method

Converts an enumerable of types into a TypeCollection.
