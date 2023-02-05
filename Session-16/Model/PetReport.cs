using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Pet;

namespace Model
{
    public class PetReport
    {
        public PetReport()
        {
            PetReportID= Guid.NewGuid();
        }
        public Guid PetReportID { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public AnimalType AnimalType { get; set; }
        public double TotalSold { get; set; } 

        




    }

}
