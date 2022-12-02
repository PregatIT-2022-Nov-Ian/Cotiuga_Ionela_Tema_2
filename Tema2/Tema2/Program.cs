using Tema2.Models;


Door door = new Door("brown");
SmallApartment smallApartment = new SmallApartment(50, door);
Person person = new Person("Ionela", smallApartment);
person.ShowData();
