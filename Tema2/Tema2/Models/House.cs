namespace Tema2.Models
{
    public abstract class House : Interface
    {
        public double area { get; set; }
        public Door door;
        public House(int area)
        {
            this.area = area;
        }

        public House(int area, Door door)
        {
            this.area = area;
            this.door = door;
        }

        public Door GetDoor()
        {
            return this.door;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {this.area} m2");
        }
    }
}
