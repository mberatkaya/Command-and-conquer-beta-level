using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_ödev
{
    public class Sovyet : IKışla, IHangar, IJeneratör
    {
        public void HFUNCTİON(string Hfunction = "Hangar hazır")
        {
            Console.WriteLine(Hfunction);
        }
        public void HHP(int Hhp = 2300)
        {
            Console.WriteLine(Hhp);
        }

        public void HLEVEL(int Hlevel = 4)
        {
            Console.WriteLine(Hlevel);
        }

        public void JFUNCTİON(string Jfunction = "Bzzzz")
        {
            Console.WriteLine(Jfunction);
        }

        public void JHP(int Jhp = 1300)
        {
            Console.WriteLine(Jhp);
        }

        public void JLEVEL(int Jlevel = 3)
        {
            Console.WriteLine(Jlevel);
        }

        public void KFUNCTİON(string Kfunction = "Kışla hazır")
        {
            Console.WriteLine(Kfunction);
        }

        public void KHP(int Khp = 1800)
        {
            Console.WriteLine(Khp);
        }

        public void KLEVEL(int Klevel = 3)
        {
            Console.WriteLine(Klevel);
        }
    }
}
