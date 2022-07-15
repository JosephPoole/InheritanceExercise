using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird();
            bird1.AnimalName = "Jerry";
            bird1.numOfEyes = 2;
            bird1.numOfLegs = 2;
            bird1.yearsOld = 3;
            bird1.typeOfBird = "Bluejay";
            bird1.canItFly = "yes";
            bird1.birdCall = "caw caw caw";
            bird1.wingsClipped = "no";
            Console.WriteLine($" My pet's name is {bird1.AnimalName}.\n" +
                $"{bird1.AnimalName} is a {bird1.typeOfBird}.\n" +
                $"He has {bird1.numOfEyes} and {bird1.numOfLegs}.\n" +
                $"{bird1.AnimalName} is {bird1.yearsOld} years old.\n" +
                $"People ask me if I clipped his wings, {bird1.wingsClipped},\n" +
                $"or if he can fly, {bird1.canItFly}, of course.\n" +
                $"{bird1.AnimalName}.makes the {bird1.birdCall}\n" +
                $"sound when he's hungry.");
            Console.WriteLine();
            Console.WriteLine();
            Reptile reptile1 = new Reptile();
            reptile1.AnimalName = "Bob";
            reptile1.numOfEyes = 2;
            reptile1.numOfLegs = 4;
            reptile1.yearsOld = 5;
            reptile1.numberOfLungs = 1;
            reptile1.colorOfScales = "green";
            reptile1.prefferedTemp = 70;
            reptile1.Diet = "omnivore";
            Console.WriteLine($"My pet's name is {reptile1.AnimalName}.\n" +
                $"{reptile1.AnimalName} is in Iguana!\n" +
                $"He has {reptile1.numOfEyes} eyes,{reptile1.numOfLegs} legs,\n" +
                $"and {reptile1.numberOfLungs} lungs!\n" +
                $"{reptile1.AnimalName} is {reptile1.yearsOld} years old.\n" +
                $"He has {reptile1.colorOfScales} skin or Scales.\n" +
                $"He likes it {reptile1.prefferedTemp} degrees in his tank.\n" +
                $"He is an {reptile1.Diet}, so he eats whatever.");
            Console.WriteLine();
        }
    }
}
