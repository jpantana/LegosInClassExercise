using LegosInClassExercise.MiniFigures;
using LegosInClassExercise.MiniFigures.Parts;
using System;

namespace LegosInClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = false,
                NumberOfEyes = 3,
            };

            var torso = new YetiTorso();

            var legs = new ZombieLegs();
           
            var YodaYetiZombie = new MiniFigure(head, torso, legs);
            YodaYetiZombie.Battle();

            var fatHead = new FatHead();
            var pirateTorso = new PirateTorso(HandType.Hook);
            var centaurLegs = new CentaurLegs();

            var fathEadedCentaurPirate = new MiniFigure(fatHead, pirateTorso, centaurLegs);
            fathEadedCentaurPirate.Battle();

        }
    }
}
