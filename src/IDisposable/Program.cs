using System;

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
            // ClasseRuim().ClasseRuim("");

            Console.WriteLine("Método indicado");
            Console.WriteLine("----------------------------------");
            // ClasseBom().ClasseBom();
        }
    }

    // public class ClasseRuim
    // {
    //     public string File { get; private set; }
    //     private System.IO.Stream _stream;    
    //     // public ClasseRuim(string filePath) => _stream = File.OpenRead(filePath);
    //     public ClasseRuim (string filePath)
    //     {
    //          _stream = File.OpenRead(filePath); 
    //     }
    // }

    //  public class ClasseBom : IDisposable
    // {
    //     public string File { get; private set; }
    //     private System.IO.Stream _stream;    
    //     // public ClasseRuim(string filePath) => _stream = File.OpenRead(filePath);
    //     public ClasseBom (string filePath)
    //     {
    //          _stream = File.OpenRead(filePath); 
    //     }
    // }
}
