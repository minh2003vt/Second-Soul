﻿using BusssinessObject;
using Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ProductRepo
{
    public interface IProductRepo : IGenericRepo<Product>
    {
        Task<List<Product>> SearchProduct(string query, decimal? minPrice, decimal? maxPrice, int? categoryID, string condition, bool? isAvailable, long? sellerID);
    }
}
