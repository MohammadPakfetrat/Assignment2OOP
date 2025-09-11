namespace Inlämningsuppgift2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Här skapar vi ett objekt av klassen Account 
            Account MyAccount = new Account();
            MyAccount.username = "Mohammad"; 
            MyAccount.password = "Abdullah"; 
            MyAccount.email = "MohammadAbdullah";  

            // Här kallar vi på MyAccount metod 
            MyAccount.Login(); 
        }
    }
}
