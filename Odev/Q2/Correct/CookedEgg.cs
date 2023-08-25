namespace Odev.Q2.Correct
{
    internal class CookedEgg : Food
    {
        public int Calorie { get; set; }
        public CookedEgg() 
        {
            Calorie = new Random().Next(0, 10);
        }
    }
}
