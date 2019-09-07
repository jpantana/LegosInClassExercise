using LegosInClassExercise.MiniFigures.Parts;

namespace LegosInClassExercise.MiniFigures
{
    class MiniFigure
    {
        public Head Head { get; set; }

        public Torso Torso { get; set; }

        public void Battle()
        {
            Head.Talk();
            System.Console.WriteLine("hi");
            Torso.Flex();
            Torso.Fight();
        }

    }
}
