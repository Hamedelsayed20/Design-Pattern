namespace StatePatternAnotherExample
{
    class Movie
    {
        IState _state = null;
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
