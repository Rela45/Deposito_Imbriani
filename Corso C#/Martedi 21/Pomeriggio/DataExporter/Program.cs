#region Interfaces

public interface IDataExporter{
    string Format(Data data);
}


#endregion

#region Data
public class Data
{
    public string Name { get; set; }
    public int Value { get; set; }
}
#endregion
#region ConcreteFormats

public class JSONFormat : IDataExporter
{
    public string Format(Data data)
    {
        return $"{data.Name}{data.Value} in formato JSON";
    }
}


public class XMLFormat : IDataExporter
{
    public string Format(Data data)
    {
        return $"<{data.Name}>  <{data.Value}>";
    }
}

#endregion

#region DataExporter 
public class DataExporter
{
    public void Export(Data data, IDataExporter formatter) //method injection
    {
        Console.WriteLine(formatter.Format(data));
    }
}

#endregion




#region MAIN 
class Program
{
    static void Main(string[] args)
    {
        // bool continua = true;

        // string input = Console.ReadLine();
        // switch (input)
        // {
        //     case "":
        // }
        var Data = new Data { Name = "documento ", Value = 2 };

        var exporter = new DataExporter();

        // Export in formato JSON
        exporter.Export(Data, new JSONFormat());

        // Export in formato XML
        exporter.Export(Data, new XMLFormat());
        
    }
}

#endregion