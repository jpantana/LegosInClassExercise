using System;

namespace LegosInClassExercise.MiniFigures.Parts
{
    abstract class Head
    {
        public int NumberOfEyes { get; set; }
        public string EyeColor { get; set; }
        public bool HasNose { get; set; }
        public string HairColor { get; set; }
        public bool MouthIsOpen { get; set; }
        public HeadSize Size { get; protected set; }

        public virtual void Talk()
        {
            Console.WriteLine("I'm a talkinghead");
        }

        public abstract void Think();
    }
}
