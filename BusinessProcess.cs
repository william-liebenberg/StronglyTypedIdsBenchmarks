namespace StronglyTypedIds;

public class BusinessProcess
{
    public UserId ProcessUser(UserId id) => id;
    public ProductId ProcessProduct(ProductId id) => id;
    public CustomerId ProcessCustomer(CustomerId id) => id;
    public PersonId ProcessPerson(PersonId id) => id;
}