using System.Security.Cryptography.X509Certificates;

namespace Odev.Q2.Correct 
{
    internal class Egg : IComeFirstAble
    {
        public IComeFirstAble Chicken { get; set; }
        public Egg()
        {
            Chicken = new Chicken();
        }
        public IComeFirstAble ComesFirst()
        {
            return Chicken;
        }
    }
}
