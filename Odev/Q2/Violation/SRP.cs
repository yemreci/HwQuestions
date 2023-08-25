namespace Odev.Q2.Violation
{
    internal class SRP
    {
        public Chicken ComesFirst(Egg egg)
        {
            return egg.Chicken;
        }
        public Egg ComesFirst(Chicken chicken)
        {
            return chicken.Egg;
        }
        public IFood CookedFirst(Chicken chicken)
        {
            return new CookedChicken();
        }
        public IFood CookedFirst(Egg egg)
        {
            return new CookedEgg();
        }
        public int AteFirst(CookedEgg egg)
        {
            return egg.Calorie * 3;
        }
        public int AteFirst(CookedChicken chicken)
        {
            return chicken.Calorie * 5;
        }
    }
}
