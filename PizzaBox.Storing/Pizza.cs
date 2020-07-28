﻿using System;
using System.Collections.Generic;
using PizzaBox.Housing.Models;

namespace PizzaBox.Storing
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int PizzaId { get; set; }
        public int CrustId { get; set; }
        public int SizeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual Crust Crust { get; set; }
        public virtual Size Size { get; set; }
        public virtual ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}