/*
 * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
 * Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
 * Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
 * Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/
namespace Problem_3.Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    class StartProgram
    {
        static void Main(string[] args)
        {
            //Creating some animals
            Kitten kitten = new Kitten(3, "Beki");
            Dog dog = new Dog(10, "REX", "male");
            Tomcat tomcat = new Tomcat(12, "Garfield");
            Cat cat = new Cat(6, "Murcho", "female");
            Frog frog = new Frog(8, "Frogio", "male");
            List<Animal> animals = new List<Animal>();
            animals.Add(kitten);
            animals.Add(tomcat);
            animals.Add(frog);
            animals.Add(dog);
            animals.Add(cat);
            Console.WriteLine("Animals: ");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name + " is " + animal.Age + " years old and is " + animal.Sex);
            }
            int averageAge = Animal.AverageAge(animals);
            Console.WriteLine();
            Console.WriteLine("Average age is: {0}", averageAge);
        }
    }
}
