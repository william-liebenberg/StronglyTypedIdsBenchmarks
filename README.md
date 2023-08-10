# StronglyTypedIds

This repo shows how we can use various coding constructs to implement Strongly Typed IDs and also to compare how each technique performs.

Here is a sample run from BenchmarkDotNet:

```
// * Summary *

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22631.2129)
12th Gen Intel Core i9-12900HK, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.100-preview.6.23330.14
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


|                              Method |     Mean |    Error |   StdDev |    Gen0 | Allocated |
|------------------------------------ |---------:|---------:|---------:|--------:|----------:|
|               StructStronglyTypedId | 15.24 us | 0.300 us | 0.334 us |       - |      64 B |
| ReadonlyRecordStructStronglyTypedId | 15.38 us | 0.294 us | 0.302 us |       - |      64 B |
|               RecordStronglyTypedId | 31.48 us | 0.628 us | 0.901 us | 25.4517 |  320064 B |
|                ClassStronglyTypedId | 32.81 us | 0.645 us | 1.096 us | 25.4517 |  320064 B |
```