namespace VisitorPattern.src
{
    public interface IProduct
    {
        public void setPrice(double price);
        public double getPrice();
        void accept(IVisitor visitor);
    }
}
