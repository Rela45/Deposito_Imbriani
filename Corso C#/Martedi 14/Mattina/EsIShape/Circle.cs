class Circle : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        return new ConcreteCircle();
    }
}