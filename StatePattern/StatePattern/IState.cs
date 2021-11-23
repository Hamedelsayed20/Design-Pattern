namespace StatePattern
{
    /// <summary>
    /// State is a behavioral design pattern that allows an object to change the behavior when its internal state changes.
    /// </summary>
    public interface IState
    {
        void PressPoweButton(Computer computer);
    }
}
