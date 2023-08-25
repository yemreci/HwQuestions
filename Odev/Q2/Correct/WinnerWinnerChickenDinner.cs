namespace Odev.Q2.Correct
{
    internal class WinnerWinnerChickenDinner
    {
        public IComeFirstAble Winner { get; set; }
        WinnerWinnerChickenDinner(IComeFirstAble winner)
        {
            Winner = winner;
        }
        public void WonTheRace()
        {
            Console.WriteLine(Winner.GetType);
        }
    }
}
