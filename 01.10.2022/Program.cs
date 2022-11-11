using _01._10._2022;

//Rectangle rectangle = new Rectangle()
//{
//    Name = "s",
//    Width = 3,
//    Height = 3,
//};



IFigure circle = new Circle()
{
   Radius=2
};
Console.WriteLine(circle.GetArea());
IFigure rectangle = new Rectangle()
{
    Width=2,
    Height=5
};
Console.WriteLine(rectangle.GetArea());
Console.WriteLine(rectangle.GetPerimetr());