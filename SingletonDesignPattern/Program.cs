

using DecoratorDesignPattern;

namespace SingletonDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICar bmwCar1 = new MarutiCar();
            bmwCar1.Manufacture();
            Console.WriteLine(bmwCar1 + "\n");
            DiselCarDecorator carWithDieselEngine = new DiselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();
            ICar bmwCar2 = new MarutiCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
            Console.ReadKey();

            Console.ReadKey();

        }

    }
}