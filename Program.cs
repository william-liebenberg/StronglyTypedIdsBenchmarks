using BenchmarkDotNet.Running;
using StronglyTypedIds;

// Note: for clarification on struct vs record struct vs readonly record struct, check out: https://steven-giesel.com/blogPost/2a52cd8d-b3b2-42e4-87e8-d6dc14147ddb

BenchmarkRunner.Run<Benchmarks>();