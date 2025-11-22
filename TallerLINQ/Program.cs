using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> Num = new List<int> {1, 2, 3, 4,5,6,7,8,9,10};
        var Multiplode2 = from numero in Num
                             where numero % 2 == 0 
                             select numero;
        Console.WriteLine("Números Multiplo de 2:");
        foreach(var numero in Multiplode2)
        {
            Console.WriteLine(numero);
        }
    }
}
