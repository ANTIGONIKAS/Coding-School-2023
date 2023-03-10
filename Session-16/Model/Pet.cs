//using DevExpress.XtraScheduler.Outlook.Native;
using Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pet:IEntityBase 
    {
        public Pet()
        {
            PetID = Guid.NewGuid();
           
        }


        public enum AnimalType
        {
            Bird,
            Cat,
            Dog
        }

        public enum AnimalStatus
        {
            OK,
            UNHEALTHY,
            RECOVERING
        }

        public Guid PetID { get; set; }

        //Relations
 
        public string Breed { get; set; } = null!;
        public AnimalType PetType { get; set; }
        public AnimalStatus PetStatus { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }

        //Relations
        public TransactionLine TransactionLine { get; set; } = null!;
        public Guid TransactionID { get; set; }










    }


}




        
        
    


