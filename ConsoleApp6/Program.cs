/ var p1 = new PointRecord(10, 20);
//var p2 = p1 with { x = 10 };

//Console.WriteLine(p1);
//Console.WriteLine(p2);
//record class PointRecord(int x, int y);



////////////
//Employee manager = new Employee();
//manager.Name = "Губка Боб";
//manager.Age = 20;
//manager.Position = "Менеджер";

//public class Person // Отец
//{
//    public string Name { get; set; }
//    public int Age { get; set;}


//    public Person(string name)
//    {
//        Name = name;
//        Console.WriteLine("конструктор Person сработвл");
//    }

//    public void Greet()
//    {
//        Console.WriteLine($"Меня зовут {Name}");
//    }
//}

//public class Employee : Person // Сын
//{
//    public string Position { get; set; }

//    public Employee(string name, string position) : base(name) )
//    {
//        Position = position;
//        Console.WriteLine("конструктор Person сработвл");
//    }

//    public void Work()
//    {
//        Console.WriteLine($"Я работаю на должности {Position}");
//    }
//}

List<Shape> shapes = new List<Shape>();
shapes.Add(new Shape());
shapes.Add(new Circle());
shapes.Add(new Rectagle());

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Рисую");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Рисую окружность");
    }
}

public class Rectagle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Рисую прямоугольник")
