public abstract class ShapeCreator
{
    public abstract IShape CreateShape(string type);
    
    public void Shape(string shapeType)
    {
        
        if(shapeType == "quadrato" && shapeType != null)
        {
            IShape draw = CreateShape(shapeType);
            draw.Draw();
        }else if(shapeType == "cerchio" && shapeType != null){
            IShape draw = CreateShape(shapeType);
            draw.Draw();
        }else
        {
            Console.WriteLine("Forma non valida");
        }
    }
}