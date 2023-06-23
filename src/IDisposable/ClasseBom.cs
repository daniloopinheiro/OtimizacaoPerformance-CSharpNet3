using System;
using System.IO;

namespace IDisposable
{
    public class ClasseBom : System.IDisposable
    {
        Stream _stream;
        
        public void Dispose()
        {
            _stream.Dispose();
        }

        public void MetodoBom(string filePath)
        {
            _stream = File.OpenRead(filePath);
        }

        //linha alternativa
        //public MetodoBom(string filePath) => _stream = File.OpenRead(filePath);
    }
}