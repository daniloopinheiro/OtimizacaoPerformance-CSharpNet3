using System.IO;

namespace IDisposable
{
    public class ClassRuim
    {
        Stream _stream;

        public void MetodoRuim(string filePath)
        {
            _stream = File.OpenRead(filePath);
        }
        // linha alternativa
        // public ClasseRuim(string filePath) => _stream = File.OpenRead(filePath);
    }
}