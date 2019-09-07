using LegosInClassExercise.MiniFigures;
using LegosInClassExercise.MiniFigures.Parts;
using System;

namespace LegosInClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var minifigure = new MiniFigure();
            minifigure.Head = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = false,
                NumberOfEyes = 3,
            };

            var fatHead = new FatHead();
            fatHead.Talk();
            minifigure.Head.Think();

            switch (minifigure.Head)
            {
                case YodaHead h:
                    h.Battle();
                    break;
            }
        }
    }
}
