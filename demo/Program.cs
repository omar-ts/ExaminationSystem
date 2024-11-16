using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Principle principle = new Principle();
            principle.choice();
        }
    }
}
