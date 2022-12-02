namespace Tema2.Models
{
    public class Door : Interface
    {
        public string color { get; set; }
        public Door(string color)
        {
            this.color = color;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {this.color}");
        }
    }
}
