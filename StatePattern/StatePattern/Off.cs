namespace StatePattern
{
    class Off : IState
    {
        public void PressPoweButton(Computer computer)
        {
            System.Console.WriteLine("open computer");
            computer.setState(new On());
        }
    }
}
