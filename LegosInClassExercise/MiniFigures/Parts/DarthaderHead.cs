using System;
using System.Collections.Generic;
using System.Text;

namespace LegosInClassExercise.MiniFigures.Parts
{
    class DarthaderHead : Head
    {
        public override void Talk()
        {
            Console.WriteLine("KHOOOOH PUUUUUHRR");
            base.Talk();
            Console.WriteLine("KHOOOOH PUUUUUHRR");
        }

        public override void Think()
        {
            Console.WriteLine("Am I your father?");
        }
    }
}
