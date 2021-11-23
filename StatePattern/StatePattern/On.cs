namespace StatePattern
{
    class On : IState
    {
        public void PressPoweButton(Computer computer)
        {
            System.Console.WriteLine("close computer");
            computer.setState(new Off());
        }
    }
}
