using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Domain.Repositories;
using Microsoft.Identity.Client;

namespace EShop.Application.Services
{
    public class ProductService : IProductService
    {
        public ProductService(DataContext context)
        {
            Repository = new ProductRepository(context);
        }
        public IProductRepository Repository { get; set; }
    }

    public interface IProductService
    {
        public IProductRepository Repository { get; set; }
    }
}
