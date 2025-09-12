
namespace Inlämningsuppgift2
{
    // Inkapsling metoden
    public class Person
    { // detta är private attribut för klassen Person som skyddar för resten av världen
        private string firstName; 
        

        // vi skapar ett objekt av klassen Person, vi måste secifiera värde för alla attribut
        public Person(string MyInfo)
        { 
            firstname = MyInfo;
        }
        // detta är public metod för att komma åt private attribut för klassen Person
        public string firstname 
            { 
            get { return firstName; } 
            set { firstName = value; }
        }
        

    }
}
