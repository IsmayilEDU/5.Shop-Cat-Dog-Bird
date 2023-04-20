using Shop___Cat__Dog__Bird.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop___Cat__Dog__Bird.Models.DerivedClasses.Animals
{
    internal class Dog : Animal
    {
        //  Constructor with parametres
        public Dog(string nickname, byte age, string gender,
            byte energy, int price, short mealQuantity)
            : base(nickname, age, gender, energy, price, mealQuantity) { }

        //  Method Eat
        public override void Eat()
        {
            //  Check energy limit
            if (Energy + 10 > 100)
            {
                Energy = 100;
            }
            else
            {
                Price += 10;
                Energy += 10;
            }
        }
        //  Method Sleep
        public override void Sleep()
        {
            //  Check energy limit
            if (Energy + 50 > 100)
            {
                Energy = 100;
            }
            else
            {
                Energy += 50;
            }
        }

        //  Method Play
        public override void Play()
        {
            //  Check energy limit
            if (Energy - 10 < 0)
            {
                Energy = 0;
            }
            else
            {
                Energy -= 10;
            }
        }

        //  Method ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
