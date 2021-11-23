namespace StatePatternAnotherExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie();
            IState state1 = new StartState();
            state1.doAction(movie1);
            System.Console.WriteLine("Current state of the movie: " + movie1.getState().ToString());
            IState state2 = new StopState();
            state2.doAction(movie1);
            System.Console.WriteLine("Current state of the movie: " + movie1.getState().ToString());
        }
    }
}
