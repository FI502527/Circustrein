using CircusTrein.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Logic
    {
        public Train LogicTrain(List<Animal> animalList)
        {
            Train train = new Train();
            List<Animal> sortedList = animalList.OrderBy(o => o.Size).ToList();
            foreach (Animal animal in sortedList)
            {
                bool animalPlaced = false;
                for (int i = 0; i < train.Wagons.Count; i++)
                {
                    if (train.Wagons[i].TryAddingAnimal(animal))
                    {
                        animalPlaced = true;
                        break;
                    }
                    else
                    {
                        if (i + 1 == train.Wagons.Count)
                        {
                            train.AddWagon();
                            train.Wagons[i + 1].TryAddingAnimal(animal);
                            break;
                        }
                    }
                }
                if (!animalPlaced)
                {
                }

            }
            return train;
        }
    }
}
