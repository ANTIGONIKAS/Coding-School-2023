﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public interface IEntityBase
    {
        int Id { get; set; }
    }
    public class EntityBase
    {
        public int Id { get; set; }
    }
}
