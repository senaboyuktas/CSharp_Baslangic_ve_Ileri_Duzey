using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class DegiskenlerinDavranislari
    {
        static void Main(string[] args)
        {
            string degiskenVal1 = "Sena Boyuktaş";
            string degiskenVal2 = "Hamza Boyuktaş";

            degiskenVal1 = degiskenVal2;
            degiskenVal2 = "Zeynep Boyuktaş";
        }
    }
}
