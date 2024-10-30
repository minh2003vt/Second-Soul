﻿using BusssinessObject;
using Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ReviewRepo
{
    public class ReviewRepo : GenericRepo<Review>, IReviewRepo
    {
        public ReviewRepo(SecondSoulShopContext context) : base(context)
        {
        }
    }
}
