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
    using System.Linq;

    public class Animal : ISound
    {

        public int Age { get; set; }
        public string Name { get; set; }
        private string sex;

        public Animal(int inputAge, string inputName, string inputSex)
        {
            this.Age = inputAge;
            this.Name = inputName;
            this.Sex = inputSex;
        }

        public string Sex
        {
            get { return this.sex; }
            set
            {
                
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentException("Sex must be male or female!");
                }
                else
                {
                    this.sex = value;
                }
            }
        }

        public static int AverageAge(List<Animal> animals)
        {
            int averageAge;
            var result = animals.Average(animal => animal.Age);
            averageAge = (int) result;
            return averageAge;
        }

        public virtual void Sound()
        {
            Console.WriteLine("MRRRR");
        }
    }
}