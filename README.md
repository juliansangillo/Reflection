# JulianSangillo.Reflection

<div>

<figure><img src="https://img.shields.io/badge/.NET-512BD4?style=plastic&#x26;logo=dotnet&#x26;logoColor=white" alt=".NET"><figcaption></figcaption></figure>

 

<figure><img src="https://img.shields.io/badge/NuGet-004880?style=plastic&#x26;logo=nuget&#x26;logoColor=white" alt="NuGet"><figcaption></figcaption></figure>

 

<figure><img src="https://img.shields.io/badge/C%23-239120?style=plastic&#x26;logo=c-sharp&#x26;logoColor=white" alt="C#"><figcaption></figcaption></figure>

 

<figure><img src="https://img.shields.io/badge/circleci-343434?style=plastic&#x26;logo=circleci&#x26;logoColor=white" alt="CircleCI"><figcaption></figcaption></figure>

 

<figure><img src="https://img.shields.io/github/license/juliansangillo/Reflection?color=blue&#x26;style=plastic" alt="license"><figcaption></figcaption></figure>

 

<figure><img src="https://img.shields.io/github/v/tag/juliansangillo/Reflection?label=latest&#x26;sort=semver&#x26;style=plastic" alt="latest version"><figcaption></figcaption></figure>

</div>

Reflection library for parsing .NET assemblies and types

|          |                                                                                                                                                                                                                                                                                                                                                                                       |
| -------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Stable   | ![stable build](https://img.shields.io/circleci/build/github/juliansangillo/Reflection/main?style=plastic)                                                                                                                                                                                                                                                                            |
| Preview  | ![preview build](https://img.shields.io/circleci/build/github/juliansangillo/Reflection/preview?style=plastic)                                                                                                                                                                                                                                                                        |
| Dev      | ![dev build](https://img.shields.io/circleci/build/github/juliansangillo/Reflection/dev?\&style=plastic)                                                                                                                                                                                                                                                                              |
| Activity | ![downloads](https://img.shields.io/nuget/dt/JulianSangillo.Reflection?style=plastic) ![issues](https://img.shields.io/github/issues/juliansangillo/Reflection?style=plastic) ![pull requests](https://img.shields.io/github/issues-pr/juliansangillo/Reflection?style=plastic) ![last commit](https://img.shields.io/github/last-commit/juliansangillo/Reflection/dev?style=plastic) |

### What's Included?

#### AssemblyCollection

Uses the .NET Reflection API to collect all referenced assemblies given an entry assembly. Can return a collection of all types in the collection of assemblies.

#### TypeCollection

Collection of types in an assembly or collection of assemblies.

#### ToTypeCollection Extension Method

Converts an enumerable of types into a TypeCollection.

### Download

#### PackageReference

```xml
<PackageReference Include="JulianSangillo.Reflection" Version="<Version>" />
```

#### .NET CLI

```bash
dotnet add package JulianSangillo.Reflection --version <Version>
```

#### Package Manager

```
NuGet\Install-Package JulianSangillo.Reflection -Version <Version>
```
