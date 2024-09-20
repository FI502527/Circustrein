using CircusTrein;
using CircusTrein.Classes;

namespace Unit_Tests
{
    [TestClass]
    public class Scenarios
    {
        [TestMethod]
        public void Scenario1()
        {
            //Arrange
            Animal animal1 = new Animal();
            animal1.SetDetails(1, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal2 = new Animal();
            animal2.SetDetails(2, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal3 = new Animal();
            animal3.SetDetails(3, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal4 = new Animal();
            animal4.SetDetails(4, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal5 = new Animal();
            animal5.SetDetails(5, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal6 = new Animal();
            animal6.SetDetails(6, CircusTrein.Classes.Type.Herbivore, Size.Medium);

            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            Logic logic = new Logic();
            Train train = new Train();

            //Act
            train = logic.LogicTrain(animals);

            //Assert
            Assert.AreEqual(2, train.Wagons.Count);
        }
        [TestMethod]
        public void Scenario2()
        {
            //Arrange
            Animal animal1 = new Animal();
            animal1.SetDetails(1, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal2 = new Animal();
            animal2.SetDetails(2, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal3 = new Animal();
            animal3.SetDetails(3, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal4 = new Animal();
            animal4.SetDetails(4, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal5 = new Animal();
            animal5.SetDetails(5, CircusTrein.Classes.Type.Herbivore, Size.Small);
            Animal animal6 = new Animal();
            animal6.SetDetails(6, CircusTrein.Classes.Type.Herbivore, Size.Small);
            Animal animal7 = new Animal();
            animal7.SetDetails(7, CircusTrein.Classes.Type.Herbivore, Size.Small);
            Animal animal8 = new Animal();
            animal8.SetDetails(8, CircusTrein.Classes.Type.Herbivore, Size.Small);
            Animal animal9 = new Animal();
            animal9.SetDetails(9, CircusTrein.Classes.Type.Herbivore, Size.Small);

            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
            animals.Add(animal9);
            Logic logic = new Logic();
            Train train = new Train();

            //Act
            train = logic.LogicTrain(animals);

            //Assert
            Assert.AreEqual(2, train.Wagons.Count);
        }
        [TestMethod]
        public void Scenario3()
        {
            //Arrange
            Animal animal1 = new Animal();
            animal1.SetDetails(1, CircusTrein.Classes.Type.Carnivore, Size.Large);
            Animal animal2 = new Animal();
            animal2.SetDetails(2, CircusTrein.Classes.Type.Carnivore, Size.Medium);
            Animal animal3 = new Animal();
            animal3.SetDetails(3, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal4 = new Animal();
            animal4.SetDetails(4, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal5 = new Animal();
            animal5.SetDetails(5, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal6 = new Animal();
            animal6.SetDetails(6, CircusTrein.Classes.Type.Herbivore, Size.Small);

            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            Logic logic = new Logic();
            Train train = new Train();

            //Act
            train = logic.LogicTrain(animals);

            //Assert
            Assert.AreEqual(4, train.Wagons.Count);
        }
        [TestMethod]
        public void Scenario4()
        {
            //Arrange
            Animal animal1 = new Animal();
            animal1.SetDetails(1, CircusTrein.Classes.Type.Carnivore, Size.Large);
            Animal animal2 = new Animal();
            animal2.SetDetails(2, CircusTrein.Classes.Type.Carnivore, Size.Large);
            Animal animal3 = new Animal();
            animal3.SetDetails(3, CircusTrein.Classes.Type.Carnivore, Size.Medium);
            Animal animal4 = new Animal();
            animal4.SetDetails(4, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal5 = new Animal();
            animal5.SetDetails(5, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal6 = new Animal();
            animal6.SetDetails(6, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal7 = new Animal();
            animal7.SetDetails(7, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal8 = new Animal();
            animal8.SetDetails(8, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal9 = new Animal();
            animal9.SetDetails(9, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal10 = new Animal();
            animal10.SetDetails(10, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal11 = new Animal();
            animal11.SetDetails(11, CircusTrein.Classes.Type.Herbivore, Size.Small);

            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
            animals.Add(animal9);
            animals.Add(animal10);
            animals.Add(animal11);
            Logic logic = new Logic();
            Train train = new Train();

            //Act
            train = logic.LogicTrain(animals);

            //Assert
            Assert.AreEqual(5, train.Wagons.Count);
        }
        [TestMethod]
        public void Scenario5()
        {
            //Arrange
            Animal animal1 = new Animal();
            animal1.SetDetails(1, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal2 = new Animal();
            animal2.SetDetails(2, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal3 = new Animal();
            animal3.SetDetails(3, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal4 = new Animal();
            animal4.SetDetails(4, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal5 = new Animal();
            animal5.SetDetails(5, CircusTrein.Classes.Type.Herbivore, Size.Small);

            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            Logic logic = new Logic();
            Train train = new Train();

            //Act
            train = logic.LogicTrain(animals);

            //Assert
            Assert.AreEqual(2, train.Wagons.Count);
        }
        [TestMethod]
        public void Scenario6()
        {
            //Arrange
            Animal animal1 = new Animal();
            animal1.SetDetails(1, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal2 = new Animal();
            animal2.SetDetails(2, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal3 = new Animal();
            animal3.SetDetails(3, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal4 = new Animal();
            animal4.SetDetails(4, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal5 = new Animal();
            animal5.SetDetails(5, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal6 = new Animal();
            animal6.SetDetails(6, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal7 = new Animal();
            animal7.SetDetails(7, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal8 = new Animal();
            animal8.SetDetails(8, CircusTrein.Classes.Type.Herbivore, Size.Medium);

            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
            Logic logic = new Logic();
            Train train = new Train();

            //Act
            train = logic.LogicTrain(animals);

            //Assert
            Assert.AreEqual(3, train.Wagons.Count);
        }
        [TestMethod]
        public void Scenario7()
        {
            //Arrange
            Animal animal1 = new Animal();
            animal1.SetDetails(1, CircusTrein.Classes.Type.Carnivore, Size.Large);
            Animal animal2 = new Animal();
            animal2.SetDetails(2, CircusTrein.Classes.Type.Carnivore, Size.Large);
            Animal animal3 = new Animal();
            animal3.SetDetails(3, CircusTrein.Classes.Type.Carnivore, Size.Large);
            Animal animal4 = new Animal();
            animal4.SetDetails(4, CircusTrein.Classes.Type.Carnivore, Size.Medium);
            Animal animal5 = new Animal();
            animal5.SetDetails(5, CircusTrein.Classes.Type.Carnivore, Size.Medium);
            Animal animal6 = new Animal();
            animal6.SetDetails(6, CircusTrein.Classes.Type.Carnivore, Size.Medium);
            Animal animal7 = new Animal();
            animal7.SetDetails(7, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal8 = new Animal();
            animal8.SetDetails(8, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal9 = new Animal();
            animal9.SetDetails(9, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal10 = new Animal();
            animal10.SetDetails(10, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal11 = new Animal();
            animal11.SetDetails(11, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal12 = new Animal();
            animal12.SetDetails(12, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal13 = new Animal();
            animal13.SetDetails(13, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal14 = new Animal();
            animal14.SetDetails(14, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal15 = new Animal();
            animal15.SetDetails(15, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal16 = new Animal();
            animal16.SetDetails(16, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal17 = new Animal();
            animal17.SetDetails(17, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal18 = new Animal();
            animal18.SetDetails(18, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal19 = new Animal();
            animal19.SetDetails(19, CircusTrein.Classes.Type.Herbivore, Size.Large);
            Animal animal20 = new Animal();
            animal20.SetDetails(20, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal21 = new Animal();
            animal21.SetDetails(21, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal22 = new Animal();
            animal22.SetDetails(22, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal23 = new Animal();
            animal23.SetDetails(23, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal24 = new Animal();
            animal24.SetDetails(24, CircusTrein.Classes.Type.Herbivore, Size.Medium);


            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
            animals.Add(animal9);
            animals.Add(animal10);
            animals.Add(animal11);
            animals.Add(animal12);
            animals.Add(animal13);
            animals.Add(animal14);
            animals.Add(animal15);
            animals.Add(animal16);
            animals.Add(animal17);
            animals.Add(animal18);
            animals.Add(animal19);
            animals.Add(animal20);
            animals.Add(animal21);
            animals.Add(animal22);
            animals.Add(animal23);
            animals.Add(animal24);
            Logic logic = new Logic();
            Train train = new Train();

            //Act
            train = logic.LogicTrain(animals);

            //Assert
            Assert.AreEqual(13, train.Wagons.Count);
        }
    }
}