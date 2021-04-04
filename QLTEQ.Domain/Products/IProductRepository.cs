using QLTEQ.DTOPattern.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLTEQ.Domain.Products
{
    public interface IProductRepository
    {
        List<ProductResponseGet> GetByIds(List<string> ids);

        List<ProductResponseGet> GetAll();
    }
}