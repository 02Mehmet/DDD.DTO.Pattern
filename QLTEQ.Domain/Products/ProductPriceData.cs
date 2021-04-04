using QLTEQ.Domain.SeedWork;
using QLTEQ.Domain.SharedKernel;

namespace QLTEQ.Domain.Products
{
    public class ProductPriceData : ValueObject1
    {
        public ProductPriceData(ProductId productId, MoneyValue price)
        {
            ProductId = productId;
            Price = price;
        }

        public ProductId ProductId { get; }

        public MoneyValue Price { get; }
    }
}