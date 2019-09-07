using System;
using System.Collections.Generic;
using System.Text;

namespace LegosInClassExercise.MiniFigures.Parts
{
    class YodaHead : Head
    {
        // this only if it is ALWAYS true, else use a private set and set it in the constructor.
        public bool HasEars { get; set; }

        public YodaHead()
        {
            Size = HeadSize.Small;
        }

        public override void Talk()
        {
            Console.WriteLine("Talking head, I am.");
        }

        public override void Think()
        {
            Console.WriteLine("There is no try...");
        }

        public void Battle()
        {
            HasEars = false;
        }


    }
}
