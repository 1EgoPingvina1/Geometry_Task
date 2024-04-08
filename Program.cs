using System;

namespace Geometry_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Команды для выполнения------");
            Console.WriteLine("|    Создать треугольник        |\n" +
                              "|    Создать круг               |\n" +
                              "---------------------------------");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "Create triangle":
                    var triangle = new Triangle();
                    Console.Write("Side 1 = ");
                    double side1 = double.Parse(Console.ReadLine());
                    Console.Write("Side 2 = ");
                    double side2 = double.Parse(Console.ReadLine());
                    Console.Write("Side 3 = ");
                    double side3 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("1 - Calculate radius\n" +
                                      "2 - Check triangle (Is right triangle?)");
                    int checker = int.Parse(Console.ReadLine());
                    switch (checker)
                    {
                        case 1:
                            Console.WriteLine($"Triangle area = {triangle.CalculateArea(side1, side2, side3)}");
                            break;

                        case 2:
                            if (!triangle.IsRightTriangle(side1, side2, side3))
                            {
                                Console.WriteLine("Triangle is not right angled");
                            }
                            else 
                                Console.WriteLine("Triangle is right angled");
                            break;
                    }
                    break;
                case "Create circle":
                    var circle = new Circle();
                    Console.WriteLine("Enter radius your circle:");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Radios your his circle {circle.CalculateRadius(radius).ToString()}");
                    break;
            }
        }
    }
}
