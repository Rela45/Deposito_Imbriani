using System.Diagnostics;

public interface MonoBehaviour
{
    enum TipoNemico { };
}


public class Nemico : MonoBehaviour
{
    public enum TipoNemico { Zombie, Robot, Fantasma }

    private TipoNemico tipo;

    public void Start()
    {
        switch (tipo)
        {
            case TipoNemico.Zombie:
                Console.WriteLine($"questo è uno zombie");
                break;
            case TipoNemico.Fantasma:
                Console.WriteLine($"questo è un fantasma");
                break;
            case TipoNemico.Robot:
                Console.WriteLine($"questo è uno robot");
                break;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var enemy = new Nemico();
        enemy.Start();
    }
}
