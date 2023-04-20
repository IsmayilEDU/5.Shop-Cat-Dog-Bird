using Shop___Cat__Dog__Bird.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop___Cat__Dog__Bird.Models
{
    internal class PetShop
    {
        //  Animals
        private List<Animal> _animals;
        public List<Animal> Animals 
        { 
            get { return _animals; }
            set
            {
                //  Check empty value
                if (value.Count != 0)
                {
                    _animals = value;
                }
            }
        }

        //  Show animals
        public void ShowAnimals()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        //  Remove by nickname
        public void RemoveByNickname(string nickname) 
        {
            foreach (var animal in _animals)
            {
                if (animal.NickName == nickname)
                {
                    _animals.Remove(animal);
                }
            }
        }

        //  Add animal to list
        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }
        
    }
}
