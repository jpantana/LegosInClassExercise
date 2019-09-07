using LegosInClassExercise.MiniFigures.Parts;

namespace LegosInClassExercise.MiniFigures
{
    class MiniFigure
    {
        readonly Head _head;
        readonly Torso _torso;
        readonly Legs _legs;

        public MiniFigure(Head head, Torso torso, Legs legs)
        {
            _head = head;
            _torso = torso;
            _legs = legs;
        }

        public void Battle()
        {
            _legs.Walk();
            _head.Talk();
            _torso.Flex();
            _torso.Fight();
            _legs.Kick();
        }

    }
}
