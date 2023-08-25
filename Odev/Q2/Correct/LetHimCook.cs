namespace Odev.Q2.Correct
{
    internal class LetHimCook
    {
        IComeFirstAble ComeFirstAble { get; set; }
        public LetHimCook(IComeFirstAble food)
        {
            ComeFirstAble = food;
        }
        public int CookIt()
        {
            switch (ComeFirstAble)
            {
                case Egg: return new CookedEgg().Calorie*3;
                case Chicken: return new CookedChicken().Calorie*5;
            }
            return 0;
        }
    }
}
