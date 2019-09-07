using System;
using System.Collections.Generic;
using System.Text;

namespace LegosInClassExercise.MiniFigures.Parts
{
    class FatHead : Head
    {
        public FatHead()
        {
            Size = HeadSize.Fat;

        }

        public override void Think()
        {
            Console.WriteLine("I wish I wasn't such a fat head");
        }
    }
}
