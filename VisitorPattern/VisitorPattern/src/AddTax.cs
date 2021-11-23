namespace VisitorPattern.src
{
    public class AddTax : IVisitor
    {
        public void Visit(Car car)
        {
            car.setPrice(10000);
        }

        public void Visit(Bike bike)
        {
            bike.setPrice(2000);
        }
    }
}
