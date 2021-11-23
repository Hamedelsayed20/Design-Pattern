namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // if computer is off and pressed on button 
            Computer computer = new Computer ();
            IState state1 = new Off();
            state1.PressPoweButton(computer);

            // if computer is opened and pressed off button 
            Computer computer2 = new Computer();
            IState state2 = new On();
            state2.PressPoweButton(computer2);
            System.Console.WriteLine();
        }
    }
}
