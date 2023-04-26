public class RedShapeDecorator : ShapeDecorator 
{
    public RedShapeDecorator(Shape shape):base(shape)
    {

    }
  
    public override void Draw()
    {
        shape.Draw();
        SetRedBorder(shape);
    }
    private void SetRedBorder(Shape shape)
    {
        Console.WriteLine("Border Color Red");
    }
}