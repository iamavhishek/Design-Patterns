public abstract class ShapeDecorator : Shape
{
    protected Shape shape;
    public ShapeDecorator(Shape shape)
    {
        this.shape = shape;
    }
    public virtual void Draw()
    {
        shape.Draw();
    }
}