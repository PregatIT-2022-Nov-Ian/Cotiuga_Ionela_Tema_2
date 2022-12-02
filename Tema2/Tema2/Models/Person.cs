

namespace Tema2.Models
{
    public class Person : Interface
    {
        string name;
        House house; 

        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a person, my name is {this.name}");
            this.house.ShowData();
            this.house.GetDoor().ShowData(); 
        }

    }
}
