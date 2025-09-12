

namespace Inlämningsuppgift2
{
    // Polymorphism exemplet 

    // huvudklass
    public class customer
    {
        public string name;
        public string email;

        public virtual void CustomerInfo()
        {
            Console.WriteLine("This is a customer.");
        }
        // subklass som ärver från klassen customer och vi vill ha en egen version av metoden CustomerInfo 

        public class BankCard : customer
        {

            public override void CustomerInfo()
            {
                Console.WriteLine("This is a Card.");
            }
            public class Banknumber : customer
            {

                public override void CustomerInfo()
                {
                    Console.WriteLine("This is a Banknumber.");
                }
            }
        }
    }
}
