namespace Tema2.Models
{
    public class SmallApartment : House
    {
        public SmallApartment(int newArea, Door newDoor) : base(newArea, newDoor)
        {
            if(newArea <= 50)
            {
                area = newArea;
                door = newDoor;
            }
            else
            {
                Console.WriteLine("Area must be less than 50");
                area = 50;
            }
        }

    }
}
