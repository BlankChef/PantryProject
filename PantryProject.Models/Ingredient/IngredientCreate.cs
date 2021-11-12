﻿using PantryProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantryProject.Models.Ingredient
{

    public class IngredientCreate
    {
        public string Name { get; set; }
        public IngredientType TypeOfIngredient { get; set; }
    }
}
