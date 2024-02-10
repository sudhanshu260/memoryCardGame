using System;
using System.Collections.Generic; using System.Linq;
using System.Text;
using System.Threading.Tasks; namespace Area_of_Circle
{
internal class Area_of_Circle_Class
{
double r;
public void getdata(double x)
{
r=x;
}
public void area()
{
double a = 3.14 * r * r;
Console.WriteLine("Area of Circle :"+a);
}
public void circumference()
{
double c = 2 * 3.14 * r;
Console.WriteLine("Circumference of Circle :" + c);
}
class Caller_class
{
static void Main(string[] args)
{
Area_of_Circle_Class ob = new Area_of_Circle_Class(); ob.getdata(7);
ob.area(); ob.circumference(); Console.ReadLine();
}
}

}
}
