namespace Animal
{
    using System;

    class Program
    {

        static void Main()
        {
            Dog[] dogs =
        {
            new Dog( 3, "Dog1", 'f'),
            new Dog( 1, "Dog2", 'm'),
            new Dog( 5, "Dog3", 'm'),
        };

            Frog[] frogs =
        {
            new Frog( 3, "Frog1", 'f'),
            new Frog( 8, "Frog2", 'm'),
            new Frog( 8, "Frog3", 'm'),
        };
        
            Cat[] cats =
        {
            new Kitten( 25, "Cat1"),
            new TomCat( 3, "Cat2"),
            new Kitten( 1, "Cat3"),
        };

            dogs[2].IdentifyAnimal();
            cats[1].IdentifyAnimal();
            frogs[2].ProduceSound();

            Console.WriteLine("Average age of dogs {0:f}", Animal.Average(dogs));
            Console.WriteLine("Average age of frogs {0:f}", Animal.Average(frogs));
            Console.WriteLine("Average age of cats {0:f}",  Animal.Average(cats));

        }
    }
}
