using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop___Cat__Dog__Bird.Models.AbstractClasses
{
    //  Fields of Animal ( with full property)
    internal abstract partial class Animal
    {
        //  NickName
        private string _nickname;
        public string NickName 
        { 
            get { return _nickname; }
                 
            set
            {
                //  Length of nickname should be MIN 3 symbols
                if (value.Length >= 3)
                {
                    _nickname = value;
                }

                //  Otherwise (ERROR)
                else
                {
                    throw new Exception(" Length of nickname should be MIN 3 symbols!");
                }
            }
        }

        //  Age
        private byte _age;
        public byte Age
        {
            get { return _age; }
            set
            {
                //  Age never been negative number
                if (value >= 0)
                {
                    _age= value;    
                }

                //  Otherwise
                else
                {
                    throw new Exception("Age never been negative number!");
                }
            }
        }

        //  Gender
        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set
            {
                //  Length of gender should be MIN 3 symbols
                if (value.Length >= 3)
                {
                    _gender = value;
                }

                //  Otherwise (ERROR)
                else
                {
                    throw new Exception(" Length of gender should be MIN 3 symbols!");
                }
            }
        }

        //  Energy
        private byte _energy;
        public byte Energy 
        {
            get { return _energy; }
            set
            {
                //  Energy shoul be more than 0 and less than 100
                if (value >= 0 && value <= 100)
                {
                    _energy = value;
                }

                //  Otherwise
                else
                {
                    throw new Exception("Energy shoul be more than 0 and less than 100!");
                }
            }
        }

        //  Price
        private int _price;
        public int Price 
        { 
            get { return _price; }
            set
            {
                //  Price should be only positive number
                if (value > 0)
                {
                    _price = value;
                }

                //  Otherwise
                else
                {
                    throw new Exception("Price should be only positive number!");
                }
            }
        }

        //  MealQuantity ( with gr)
        private short _mealQuantity;
        public short MealQuantity 
        { 
            get { return _mealQuantity; }
            set
            {
                //  MealQuantity should be more than 0 and less than 1000
                if (value > 0 && value < 1000)
                {
                    _mealQuantity = value;
                }

                //  Otherwise
                else
                {
                    throw new Exception("MealQuantity should be more than 0 and less than 1000!");
                }
            }
        }

    }

    //  Methods of Animal
    internal abstract partial class Animal
    {
        //  Constructor with parametres
        public Animal(string nickname, byte age, string gender,
            byte energy, int price, short mealQuantity)
        {
            NickName = nickname;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
        }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Play();

        public override string ToString()
        {
            return $"Nickname: {NickName}\nAge: {Age}\nGender: {Gender}\nEnergy: {Energy} %\nPrice: {Price} AZN\nMealQuantity: {MealQuantity} gr\n";
        }
    }
}
