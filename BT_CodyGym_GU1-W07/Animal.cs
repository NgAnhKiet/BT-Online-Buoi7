public abstract class Animal
{
    public abstract string makeSound();
}

public class Tiger : Animal
{
    public override string makeSound()
    {
        return "Tiger: roarrrrr";
    }
}
public class Chicken : Animal, Edible
{
    public override string makeSound()
    {
        return "Chicken: cluck-cluck!";
    }
    public string HowToEat()
    {
        return "could be fried";
    }
}
public abstract class Fruit : Edible
{
    public abstract string HowToEat();
}
public class Apple : Fruit
{
    public override string HowToEat()
    {
        return "Apple could be slided";
    }
}
public class Orange : Fruit
{
    public override string HowToEat()
    {
        return "Orange could be juiced";
    }
}
public interface Edible
{
    public string HowToEat();
}