using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Vehicle
{
    class Vehicle : IComparable<Vehicle>
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string TehnicalData { get; set; }
        public string OtherCharacteristics { get; set; }
        public string PlateNumber { get; set; }
        public string DateOfRegistration { get; set; }
        public string Owner { get; set; }
        public string LastCheckOut { get; set; }

        public Vehicle(int id, string type, string brand, string tehnicalData, string otherCharacteristics,
            string plateNumber,
            string dateOfRegistration, string owner, string lastCheckOut)
        {
            Id = id;
            Type = type;
            Brand = brand;
            TehnicalData = tehnicalData;
            OtherCharacteristics = otherCharacteristics;
            PlateNumber = plateNumber;
            DateOfRegistration = dateOfRegistration;
            Owner = owner;
            LastCheckOut = lastCheckOut;
        }

        public Vehicle()
        {
        }

        public int CompareTo(Vehicle other)
        {
            return this.Type.CompareTo(other.Type);
        }

        public override string ToString()
        {
            return Id + ", " + Type + " , " + Brand + " , " + TehnicalData + " , " + OtherCharacteristics +
                   " , " +
                   PlateNumber + " , " + DateOfRegistration + " , " + Owner + " , " + LastCheckOut;
        }
    }
}