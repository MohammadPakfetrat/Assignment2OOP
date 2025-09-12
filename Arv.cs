

namespace Inlämningsuppgift2
{
    // Arv Metoden 
    public class Bank 
    {
        // dessa är attribut för klassen Bank 
        public string bankName; 
        public string bankAddress;

        // detta är metod för klassen Bank
        public void BankInfo()
        {
            Console.WriteLine("Welcome to our bank.");
        }
    }
    // subbklass som ärver från klassen Bank
    public class  BankAccount : Bank
    {
        // dessa är attribut för klassen BankAccount som ärver från klassen Bank
        public string accountPassword; 
        public string accountName;
        // detta är metod för klassen BankAccount som ärver från klassen Bank
        public void AccountInfo()
        {
            Console.WriteLine("This is your bank account.");
        }
    }
}
