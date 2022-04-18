namespace Course_OOP.S4.S4_Constructors_Inheritiance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initializing");
        //}

        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initializing{0}",this._registrationNumber);
        }
    }
}
