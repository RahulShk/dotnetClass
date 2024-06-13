using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarDescription { get; set; }
        public float CarSpeed { get; set; }
        public float CarPrice { get; set; }

        public Car() { }

        public Car(int carId, string carName, string carDescription, float carSpeed, float carPrice)
        {
            this.CarId = carId;
            this.CarName = carName;
            this.CarDescription = carDescription;
            this.CarSpeed = carSpeed;
            this.CarPrice = carPrice;
        }

        public override string ToString()
        {
            return $"CarId: {CarId}\n" +
                $" CarName: {CarName}\n" +
                $" CarDescription: {CarDescription}\n" +
                $" CarSpeed: {CarSpeed} km/h\n" +
                $" CarPrice: ${CarPrice}";
        }
    }
}
