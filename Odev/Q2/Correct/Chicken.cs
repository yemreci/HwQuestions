namespace Odev.Q2.Correct
{
    internal class Chicken : IComeFirstAble
    {
        public IComeFirstAble Egg { get; set; }
        public Chicken()
        {
            Egg = new Egg();
        }
        public IComeFirstAble ComesFirst()
        {
            return Egg;
        }
    }
}
