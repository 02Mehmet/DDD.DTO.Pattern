using QLTEQ.Domain.Products;
using QLTEQ.DTOPattern.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTEQ.Infrastructure.Domain.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly postgrecontext _context;
        public ProductRepository(postgrecontext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<ProductResponseGet> GetByIds(List<string> ids)
        {
            return this._context.Products.Select(a => new ProductResponseGet()
            {
                Id = a.Id,
                Name = a.Name,
                Quantity = a.Quantity
            }).Where(x => ids.Contains(x.Id)).ToList();
        }

        public List<ProductResponseGet> GetAll()
        {
            var deneme = this._context.Products.ToList();
            return this._context.Products.Select(a => new ProductResponseGet()
            {
                Id = a.Id,
                Name = a.Name,
                Quantity = a.Quantity
            }).ToList();
        }
    }
}
