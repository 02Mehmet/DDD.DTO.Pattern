using QLTEQ.Domain.SharedKernel;

namespace QLTEQ.Domain.Products
{
    public class ProductPrice
    {
        public MoneyValue Value { get; private set; }

        private ProductPrice()
        {
            
        }
    }
}