﻿using PetShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class PetFoodDetail:EntityBase
    {
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        //relations
        public int PetFoodId { get; set; }
        public PetFood PetFood { get; set; } = null!;
    }
}
