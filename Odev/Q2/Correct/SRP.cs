namespace Odev.Q2.Correct
{
    internal class SRP
    {
        public void Open()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Q2\Correct\SRP.txt")))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while opening the file: " + e.Message);
            }
        }
    }
}
