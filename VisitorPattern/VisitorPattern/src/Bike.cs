namespace VisitorPattern.src
{
    public class Bike:IProduct
    {
        private double Price;
        public double getPrice()
        {
            return Price;
        }

        public void setPrice(double price)
        {
            this.Price = price;
        }

        public void accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
