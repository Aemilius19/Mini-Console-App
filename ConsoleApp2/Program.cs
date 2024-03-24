
namespace ConsoleApp2 { 


using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            Console.WriteLine("Hello, customer!");
            Notebook yeninote = new Notebook("lenovo", "lnovo ideapad3 fast gaming and designing note", 1, 900, 16, 1024);
            yeninote.getfullInfo();

        }
    }
    public class Product
    {
        string Name;
        string Description;
        public int Count = 1;
        bool lsStock = true;
        double Price;
        public Product(string name, string description, int count, double price)
        {
            Name = name;
            Description = description;
            Count = count;
            Price = price;
        }
        public void Sale()
        {
            for (int i = 0; i < Count; i++)
            {
                lsStock = true;
                if (lsStock == true)
                {
                    Console.WriteLine($"hal hazirda {Name} nottebooku satiwda var");
                    showfullData();
                }

                else
                {
                    Console.WriteLine($"Hal hazirda{Name} adli mexsul qurtarib");
                    showfullData();
                }
            }
        }
        public void showfullData()
        {
            Console.WriteLine($"{Name}  {Description}  {Price} azn");
        }
    }

    public class Notebook : Product
    {
        byte Ram = 16;
        int Storage = 1024;
        public Notebook(string name, string description, int count, double price) : base(name, description, count, price)
        {

        }

        public Notebook(string name, string description, int count, double price, byte ram, int storage) : base(name, description, count, price)
        {
            Storage = storage;
            Ram = ram;
        }
        public void getfullInfo()
        {
            Sale();
            Console.WriteLine($"\nthis notebook defaut ram is{Ram}gb and default storage is {Storage} gb");

        }
    }
} }
