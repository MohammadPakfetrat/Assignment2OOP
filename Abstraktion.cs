
namespace Inlämningsuppgift2
{
    // Abstraktion exemplet 
    // huvudklass abstrakt
    public abstract class User
    {
        public string username;
        public string password;
        public string email;
        // abstrakt metod som måste implementeras i subklassen
        public abstract void Login();

        // subklass som ärver från klassen User 
        public class Account : User
        {
            // implementerar den abstrakta metoden
            public override void Login()
            {
                Console.WriteLine("User logged in with username: " + username);
            }
        }
    }
}
