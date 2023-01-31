//using DevExpress.XtraScheduler.Outlook.Native;
using EF.Session_16.Model;
using F.Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Session_16.Model
{
    public class Pet
    {
        public Pet()
        {
            PetID = Guid.NewGuid();
        }



        public Guid PetID { get; set; }
        public string Breed { get; set; } = null!;
        public AnimalTypeEnum AnimalType { get; set; }
        public PetStatusEnum Status { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
        public PetFood PetFood { get; set; }

        public Transaction Transaction { get; set; } = null!;
        public Guid TransactionID { get; set; }

        public Pet(Guid petID, string breed, AnimalTypeEnum animalType, PetStatusEnum status, double price, double cost)
        {
            PetID = petID;
            Breed = breed;
            AnimalType = animalType;
            Status = status;
            Price = price;
            Cost = cost;
        }

        public enum AnimalTypeEnum
        {
            Bird,
            Cat,
            Dog,
            None
        }

        //switch (AnimalType)
        //   {

        //       case AnimalTypeEnum.Cat:
        //           Price = 100;
        //           break;
        //       case AnimalTypeEnum.Dog:
        //           Price = 120;
        //           break;
        //       case AnimalTypeEnum.Bird:
        //           Price = 200;
        //           break;


        //   }
        public enum PetStatusEnum
        {
            OK,
            Unhealthy,
            Recovering
        }
        public string AnimalBreed
        {
            get
            {
                return String.Format("{0} {1}", AnimalType, Breed);
            }
        }




    }

           
        }




        
        
    


