using System;
using System.IO;

namespace IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utilizando a interface IDisposable");
            Console.WriteLine("==================================");

            Console.WriteLine("Método não indicado");
            Console.WriteLine("----------------------------------");
            new ClassRuim().MetodoRuim("");

            Console.WriteLine("Método indicado");
            Console.WriteLine("----------------------------------");
            new ClasseBom().MetodoBom("");
        }
    }
}