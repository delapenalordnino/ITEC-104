using System;  
public class ITEC104_ACTIVITY4_DELAPEÑA 
{  
    public static void Main(string[] args)  
{  
    int[] arr = new int[5]; 
    int i;  
       Console.Write("\n\nSample OUTPUT:\n");
       Console.Write("==ARRAYS==\n");	
  
    Console.Write("Input 5 elements in the array:\n");  
    for(i=0; i<5; i++)  
    {  
	    Console.Write("Enter element[{0}]: ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());  		
    }  
  
    Console.Write("\nODD NUMBERS: ");
    for (i = 0; i < 5; i++)
    {
    if (arr[i] % 2 == 1)
        Console.Write("{0} ", arr[i]);
    }
    Console.Write("\nEVEN NUMBERS: ");
    for (i = 0; i < 5; i++)
    {
    if (arr[i] % 2 == 0)
        Console.Write("{0} ", arr[i]);
    }	
  }
}
