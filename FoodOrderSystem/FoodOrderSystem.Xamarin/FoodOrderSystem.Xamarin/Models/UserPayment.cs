﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrderSystem.Xamarin.Models
{
    public class UserPayment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CVC { get; set; }
    }
}
