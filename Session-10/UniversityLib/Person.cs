﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{

    public class Person
    {
      
        
       


        //properties
        public Guid ID { get;set; }
        public string? Name { get;set; }
        public int Age { get;set; } 

        public Person()
        {

        }

        public Person(Guid id, string name, int age)
            {
                ID = id;
                Name = name;
                Age = age;

            }
            //methods
            public void GetName()
            {

            }
            public void SetName(string name)
            {
            }

        }


    }
