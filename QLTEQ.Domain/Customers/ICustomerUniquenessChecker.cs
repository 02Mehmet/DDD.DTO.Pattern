namespace QLTEQ.Domain.Customers
{
    public interface ICustomerUniquenessChecker
    {
        bool IsUnique(string customerEmail);
    }
}