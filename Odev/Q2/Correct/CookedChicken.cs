namespace Odev.Q2.Correct
{
    internal class CookedChicken : Food
    {
        public int Calorie { get; set; }
        public CookedChicken()
        {
            Calorie = new Random().Next(10,20);
        }
    }
}
