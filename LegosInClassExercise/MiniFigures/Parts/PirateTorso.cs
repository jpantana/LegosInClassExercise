using System;
using System.Collections.Generic;
using System.Text;

namespace LegosInClassExercise.MiniFigures.Parts
{
    class PirateTorso : Torso
    {
        public string Shirt { get; set; }
        public int NumberOfArms { get; set; }
        public HandType HandType { get; set; }
        public override bool ChestHair => true;
        
        public PirateTorso(HandType handType)
        {
            HandType = HandType;
            Shirt = "Froothy with ruffles";
        }

        public override void Flex()
        {
            Console.WriteLine("The pirate torso flexed swashbucklingly");
        }

        public override void Fight()
        {
            Console.WriteLine("Waves sword around");
        }
    }

    enum HandType
    {
        Regular,
        Hook,
        None
    }
}
