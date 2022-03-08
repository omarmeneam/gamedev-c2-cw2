using System;

namespace c2_cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "The Witcher";
            string superpower1 = "Mind Control";
            string superpower2 = "Object Manipulation";
            int height = 200;
            int age = 1000;
            float speed = 200;

            Console.WriteLine("My name is {0}, My superpowers are {1}, {2}, MY height is {3}, My age is {4} and My speed is {5}", characterName, superpower1, superpower2, height,
                age, speed);


            string heroName = "SpiderMan";
            string heroSuperPower1 = "Super Speed";
            string heroSuperPower2 = "Super Senses";
            int heroHeight = 170;
            int age2 = 18;

            
           Console.WriteLine("My name is {0}, My superpowers are {1}, {2}, MY height is {3} and My age is {4}", heroName, heroSuperPower1, heroSuperPower2, heroHeight,
               age2);


            void ageDifference()
            {
                if (age > age2)
                {
                    Console.WriteLine(characterName + " is greater than " + heroName);
                }

                else if (age < age2)
                {
                    Console.WriteLine(heroName + " is younger than " + characterName);
                }

                else
                {
                    Console.WriteLine("They are the same age");
                }
                
            }
             ageDifference();
        }
    }
}