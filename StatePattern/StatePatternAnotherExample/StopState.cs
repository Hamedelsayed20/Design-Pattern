using System;

namespace StatePatternAnotherExample
{
    class StopState : IState
    {
        public void doAction(Movie movie)
        {
            Console.WriteLine("In stop state");
            movie.setState(this);
        }
    }
}
