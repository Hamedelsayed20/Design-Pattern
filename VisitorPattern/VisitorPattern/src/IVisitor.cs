namespace VisitorPattern.src
{
    public interface IVisitor
    {
        void Visit(Car car);
        void Visit(Bike bike);
    }
}
