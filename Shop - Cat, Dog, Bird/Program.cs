using Shop___Cat__Dog__Bird.Models.AbstractClasses;
using Shop___Cat__Dog__Bird.Models.DerivedClasses.Animals;
using MyLibrary;

namespace Shop___Cat__Dog__Bird
{

    internal class Program
    {
        
        //  Show that animal need sleep
        public static void ShowSleep()
        {
            Console.Clear();
            Console.SetCursorPosition(55, 16);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Secdiyiniz heyvan yatmalidir!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0,0);
            Thread.Sleep(2000);
        }

        //  Show play with animal
        public static void ShowPlay()
        {
            Console.Clear();
            Console.SetCursorPosition(55, 16);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Siz heyvan ile oynadiniz!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Thread.Sleep(2000);
        }

        //  Show play with animal
        public static void ShowEat()
        {
            Console.Clear();
            Console.SetCursorPosition(55, 16);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Siz heyvani yedizdirdiniz!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Thread.Sleep(2000);
        }

        //  Menu for animal
        public static void MenuAnimal(Animal animal)
        {
            //  Menu options for animal
            List<string> methods = new List<string>() { "Oynamaq", "Yedizdirmek", "Hal hazir ki veziyyeti" };

            //  Play or eat with animal
            do
            {
                byte menuAnimal = Menu.createMenu("Menyudan sechim edin:", methods);
                //  If energy == 0
                if (animal.Energy == 0)
                {
                    Program.ShowSleep();
                    animal.Sleep();
                    break;
                }
                switch (menuAnimal)
                {
                    case 0:
                        animal.Play();
                        Program.ShowPlay();
                        break; 
                    case 1:
                        animal.Eat();
                        Program.ShowEat();
                        break; 
                    case 2:
                        Console.Clear();
                        Console.WriteLine(animal.ToString());
                        Thread.Sleep(5000);
                        break;
                    
                }

            } while (true);
        }
        
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Bird("Papuqay", 2, "Qush", 10, 250, 100),
                new Cat("Tom", 4, "Pishik", 65, 1000, 150),
                new Dog("Alabash", 4, "Pishik", 30, 1500, 200),
                new Fish("Dori", 4, "Pishik", 50, 800, 250),
            };

            //  Nicknames for select from main menu
            List<string> NickNames = new List<string>();
            foreach (var Animal in Animals)
            {
                NickNames.Add(Animal.NickName);
            }

            //  Choose animal
            do
            {
                byte İndexSelectedAnimal = Menu.createMenu("Zehmet olmasa heyvan secin:", NickNames);

                MenuAnimal(Animals[İndexSelectedAnimal]);

            } while (true);

        }
    }
}