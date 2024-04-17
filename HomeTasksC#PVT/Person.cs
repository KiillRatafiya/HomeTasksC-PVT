
namespace HomeTasksC_PVT
{
    public abstract class Person
    {
        public string Adress { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string FavouriteFilm { get; set; }

        public abstract int GetYear();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Person info: {Name} {Age} {Mail} {FavouriteFilm}");

        }
    }
}
