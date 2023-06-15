using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMod
{
    internal class Program:ProtectedModifier
    {
        static void Main(string[] args)
        {
            AccessModifier accessModifier = new AccessModifier();
            accessModifier.Modifer();
            Console.ReadLine();

            PrivateModifier privateModifier = new PrivateModifier();
            privateModifier.demo();
            Console.ReadLine();

            Program program = new Program();
            program.ProtModifier();
            Console.ReadLine();

            InternalModifier internalModifier = new InternalModifier();
            internalModifier.InternMod();
        }
    }
}
