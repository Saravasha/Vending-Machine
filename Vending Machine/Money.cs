namespace Vending_Machine
{
    public class Money
    {
        public string? Denominator = Console.ReadLine();
        private int[] MoneyDenominations = new[]
        {
            1,
            5,
            10,
            20,
            50,
            100,
            500,
            1000
        };
            
    public void Validator()
    {
            while (true)
            {
            if (Denominator.Equals(MoneyDenominations)) {
                Console.WriteLine("Money Input, Valid - Proceeding...");
               
            }

            }
            {
    }



}
