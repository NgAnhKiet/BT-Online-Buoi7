internal class Program
{
    private static void Main(string[] args)
    {
        Animal[] animals = new Animal[2];
        animals[0] = new Tiger();
        animals[1] = new Chicken();

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.makeSound());

            if (animal is Chicken)
            {
                Edible edibler = (Chicken)animal;
                Console.WriteLine(edibler.HowToEat());
            }
        }

        Fruit[] fruits = new Fruit[2];
        fruits[0] = new Orange();
        fruits[1] = new Apple();
        foreach (Fruit fruit in fruits)
        {
            Console.WriteLine(fruit.HowToEat());
        }

        static void Main(string[] args)
        {
            ComperableCircle[] circles = new ComperableCircle[3];
            circles[0] = new ComperableCircle(3.6);
            circles[1] = new ComperableCircle();
            circles[2] = new ComperableCircle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }
        }
    }
}