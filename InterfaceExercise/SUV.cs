using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int NumberOfSeats { get; set; }
        public bool CanOffRoad { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasTint { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public bool IsPublic { get; set; }

        public void DisplayDetails()
        {
            throw new NotImplementedException();
        }
    }
}
