class Square : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        return new ConcreteSquare();
    }
}