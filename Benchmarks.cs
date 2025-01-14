using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace StronglyTypedIds;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class Benchmarks
{
    private List<Guid> _generatedGuids = new();
    private BusinessProcess _businessProcess = new();

    [GlobalSetup]
    public void Setup()
    {
        _generatedGuids = Enumerable
            .Range(0, 10000)
            .Select(i => Guid.NewGuid())
            .ToList();
    }

    [Benchmark]
    public void RecordId()
    {
        _generatedGuids.ForEach(x => _businessProcess.ProcessProduct(new ProductId(x)));
    }

    [Benchmark]
    public void SealedRecordId()
    {
        _generatedGuids.ForEach(x => _businessProcess.ProcessLineItem(new LineItemId(x)));
    }

    [Benchmark]
    public void ReadonlyRecordStructId()
    {
        _generatedGuids.ForEach(x => _businessProcess.ProcessUser(new UserId(x)));
    }

    [Benchmark]
    public void StructId()
    {
        _generatedGuids.ForEach(x => _businessProcess.ProcessCustomer(new CustomerId(x)));
    }

    [Benchmark]
    public void ClassId()
    {
        _generatedGuids.ForEach(x => _businessProcess.ProcessPerson(new PersonId(x)));
    }

    [Benchmark]
    public void VogenId()
    {
        _generatedGuids.ForEach(x => _businessProcess.ProcessOrder(OrderId.From(x)));
    }
}
