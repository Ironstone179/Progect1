using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
 
public class Program
 
{
 	
public static void Main(string[] args)
 		
{
 		
double y, z;
 	
int x;
 	
Console.WriteLine("Input n:");
 	
x = Convert.ToInt32(Console.ReadLine());
 	
z=System.Math.Pow(0.5, x);
 		
y=0.5*(z-1)/(0.5-1);
 		
Console.WriteLine(y);
  	
Console.ReadKey();
 	
}
 
}

}