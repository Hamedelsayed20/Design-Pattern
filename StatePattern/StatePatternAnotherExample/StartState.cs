using System;

namespace StatePatternAnotherExample
{
    class StartState : IState
    {
        public void doAction(Movie movie)
        {
            Console.WriteLine("In start state");
            movie.setState(this);
        }
    }
}
