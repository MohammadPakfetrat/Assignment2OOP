namespace Inlämningsuppgift2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Här skapar vi ett objekt av klassen Account 
            Account MyAccount = new Account();
            MyAccount.username = "MohammadP"; 
            MyAccount.password = "Abdullah"; 
            MyAccount.email = "MohammadAbdullah";  

            // Här kallar vi på MyAccount metod 
            MyAccount.Login();

            // Här skapar vi ett objekt av klassen person utav den inkapslade klassen Person
            Person MyInfo = new Person("Mohammad");


            //Här kallar vi fram metoder för klassen Bank och BankAccount  
            Bank MyBank = new Bank();
            MyBank.BankInfo(); 

            BankAccount MyBankAccount = new BankAccount(); 
            MyBankAccount.AccountInfo();

        }
       
    }
}
