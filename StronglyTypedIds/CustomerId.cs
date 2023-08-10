namespace StronglyTypedIds;

public struct CustomerId
{
    public CustomerId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public bool Equals(CustomerId other)
    {
        return Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is CustomerId other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}
