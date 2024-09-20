using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Wagon
    {
        private List<Animal> animals;
        public IReadOnlyList<Animal> Animals { get { return animals; } }
        
        public int Points { get; private set; }
        public Wagon() 
        {
            Points = 0;
            animals = new List<Animal> { };
        }
        public bool TryAddingAnimal(Animal animal)
        {
            bool isThereSpace = IsThereSpace(animal.GetPoints());
            bool IsItSafe = animal.SafetyCheck(animals);
            
            if (!isThereSpace || !IsItSafe)
                return false;
      
            animals.Add(animal);
            Points += animal.GetPoints();
            return true;
            
        }
        public bool IsThereSpace( int animalPoints)
        {
            return Points + animalPoints <= 10;
        }
    }
}
