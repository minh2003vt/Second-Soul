﻿using BusssinessObject;
using Repo.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.PaymentRepo
{
    public interface IPaymentRepo : IGenericRepo<Payment>
    {
    }
}