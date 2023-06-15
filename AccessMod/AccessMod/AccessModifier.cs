using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMod
{
    //Acesss Modifier are the keywords which specifies the accessibility or scope of a variable or a function.
    //it will control the visibility of a class.
    public class AccessModifier
    {
        //Public Modifier allow a part of a program in the same assembly or a different assembly to access the type and 
        public void Modifer()
        {
            Console.WriteLine("This is Public Modifier");
        }

        //Private Modifier it resticate other program part from accessing its members.
        private void PrivModifier()
        {
            Console.WriteLine("This is a Private Modifier");
            
        }
        public void demo()
        {
            PrivModifier();
        }

        //Protected Modifier allows the code withiin the same class and inherited class and its member.
        protected void ProtModifier()
        {
            Console.WriteLine("This is a Protected Modifier");
            
        }
    }
}
