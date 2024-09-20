﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Animal
    {
        public int Id { get; private set; }
        public Type Type { get; private set; }
        public Size Size { get; private set; }
        public Animal() { }
        public void SetDetails(int id, Type type, Size size)
        {
            Id = id;
            Type = type;
            Size = size;
        }
        public bool SafetyCheck(List<Animal> animalList)
        {
            if (!animalList.Any()) return true;
            foreach (Animal animal in animalList)
            {
                if ((animal.Type == Type.Carnivore && Type == Type.Carnivore) ||
                   (animal.Type == Type.Carnivore && animal.Size >= Size) ||
                   (Type == Type.Carnivore && Size >= animal.Size))
                    return false;

            }
            return true;
        }
        public int GetPoints()
        {
            return (int)Size;
        }
        public override string ToString()
        {
            return $"Id: {Id} - Size: {Size} - Type: {Type}";
        }
    }
}
