namespace Course_OOP.S4.S4_Constructors_Inheritiance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is begin initialized {0}",registrationNumber);
        }
    }
}
