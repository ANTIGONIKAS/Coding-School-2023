using PetShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public  class PetDetail: EntityBase
    {
        public string Breed { get; set; } = null!;
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        //relations 
        public int PetId { get; set; }
        public Pet Pet { get; set; } = null!;  
    }
}
