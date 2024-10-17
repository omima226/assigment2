namespace Vehicle_Control_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car(),
                new Motorcycle(),
                new Truck()
            };
            foreach (var vehicle in vehicles)
            { 
                vehicle.Start();
                Console.WriteLine(vehicle.Describe());
                vehicle.Stop();
                Console.WriteLine();
             };
        }
    }
}
