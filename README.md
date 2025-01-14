# StronglyTypedIds

This repo shows how we can use various coding constructs to implement Strongly Typed IDs and also to compare how each technique performs.

Here is a sample run from BenchmarkDotNet:

```text
// * Summary *

BenchmarkDotNet v0.13.7, macOS 15.2 (24C101) [Darwin 24.2.0]
Apple M4 Pro, 1 CPU, 14 logical and 14 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 9.0.0 (9.0.24.52809), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.0 (9.0.24.52809), Arm64 RyuJIT AdvSIMD


|                 Method |      Mean |     Error |    StdDev |    Gen0 | Allocated |
|----------------------- |----------:|----------:|----------:|--------:|----------:|
| ReadonlyRecordStructId |  6.347 us | 0.0150 us | 0.0140 us |  0.0076 |      64 B |
|               StructId |  6.378 us | 0.0224 us | 0.0209 us |  0.0076 |      64 B |
|                VogenId |  6.452 us | 0.0161 us | 0.0150 us |  0.0076 |      64 B |
|               RecordId | 28.931 us | 0.1578 us | 0.1399 us | 38.2385 |  320064 B |
|         SealedRecordId | 29.340 us | 0.0758 us | 0.0709 us | 38.2385 |  320064 B |
|                ClassId | 29.952 us | 0.3570 us | 0.3340 us | 38.2385 |  320064 B |
```
