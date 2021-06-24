using System;

namespace c__1
{
    class Program
    {
        static void Main(string[] args)
        {
           int i,n; 
           float a=0;


    int v=int.Parse(Console.ReadLine());
	for (i=1;i<=v;i++) 
	{ 
       Console.Write("Number-{0} :",i); 
       n= int.Parse(Console.ReadLine());	
        a=a+n;
        	 
	} 
    float z=a/v;
    Console.WriteLine(z);
        }
    }
}

