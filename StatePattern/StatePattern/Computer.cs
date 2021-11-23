namespace StatePattern
{
    public class Computer
    {
        private IState _state = new Off();
        public void setState(IState state)
        {
            _state = state;
        }

        public IState getState()
        {
            return _state;
        }
    }
}
