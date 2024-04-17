
namespace HomeTasksC_PVT
{
    internal class Customer : Person
    {
        public string Address { get; set; }

        public Customer(string name, int age, string mail, string favouriteFilm, string adress)
        {
            Name = name;
            Age = age;
            Mail = mail;
            FavouriteFilm = favouriteFilm;
            Adress = adress;
        }
        public override int GetYear()
        {
            return DateTime.Now.Year - Age;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Address: {Address}");
        }

        public void DisplayFavouriteFilm()
        {
            Console.WriteLine($"Favourite film is {FavouriteFilm}");
        }
    }
}
