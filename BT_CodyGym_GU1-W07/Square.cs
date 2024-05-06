public class Square : IColorable
{
    public Square() { }

    public Square(double side) { }

    public Square(double side, string color, bool filled) { }
    public override string ToString()
    {
        return "A Square with side="

                + ", which is a subclass of "
                + base.ToString();
    }

    public void HowToColor()
    {
        System.Console.WriteLine("Square has colored as desired");
    }
}