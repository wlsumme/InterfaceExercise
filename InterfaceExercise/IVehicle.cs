﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; } 

        public bool HasTint { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }

        public void DisplayDetails();

    }
}
