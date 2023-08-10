namespace StronglyTypedIds;

public class PersonId
{
    public PersonId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public bool Equals(PersonId other)
    {
        return Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is PersonId other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}
