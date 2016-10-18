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
 		
int y,x;
 	
x=10;
 	
while (x<=99)
 	
{
  		
y=x%10;
  	
if (y==3)
  	
{
  		
Console.WriteLine(x);
  		
}
  			
x=x+1;
  		
}
  		
Console.ReadKey();
 	
}
 	
}

}