//katsetasin ja enam-vähem tuli õige :)))

Cat newCat = new Cat ("Garfield", "ginger");

Console.WriteLine($"{newCat.Name} wants a rub on its belly.");

while (newCat.BellyFull = < 1)
{
    newCat.Sleep();
}

newCat.Name();
newCat.ShowCatData();


class Cat
{
    private string _name;
    private int _color;
    private int _bellyFull;
    public Cat(string name, string color)
    {
        _name = Name;
        _color = color;
        _bellyFull = 10;
        Console.WriteLine($"A {color} cat {name} has been created.");

    }

    public string Name
    {
        get { return _name; }
    }
    public int BellyFull()
    {
        Get{ return _bellyFull; }
    }

    public void Sleep()
    {

        _bellyFull--;
        Console.WriteLine($"{_name} says Meow!");

    }
    public void ShowCatData()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Level of hungriness: {_bellyFull}");

    }



}

