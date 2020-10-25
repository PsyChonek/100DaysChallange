using System;

namespace _15.Day
{
    class Program
    {
        public static void Main(string[] args)
        {
            int big = 1;
            int medium = 1;
            int small = 0;
            int[] cars = {1, 2, 3, 1};

            ParkingSystem obj = new ParkingSystem(big, medium, small);

            foreach (int carType in cars)
            {
                Console.WriteLine(obj.AddCar(carType));
            }
        }
    }

    public class ParkingSystem
    {
        int[] p;
    public ParkingSystem(int big, int medium, int small)
        {
        p = new int[] { big, medium, small };
        }

        public bool AddCar(int carType)
        {
            return --p[carType - 1] >= 0; 
        }
    }

    /**
     * Your ParkingSystem object will be instantiated and called as such:
     * ParkingSystem obj = new ParkingSystem(big, medium, small);
     * bool param_1 = obj.AddCar(carType);
     */
}
