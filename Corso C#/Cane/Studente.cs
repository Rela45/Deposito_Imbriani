using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Studente
{
    String nome;
    int Matricola;
    double avgVoti;

    public Studente(String nome, int matricola, double avgVoti)
    {
        this.nome = nome;
        this.Matricola = matricola;
        this.avgVoti = avgVoti;
    }

    public String GetNome()
    {
        return nome;
    }

    public int GetMatricola()
    {
        return Matricola;
    }
    
    public double GetAvgVoti()
    {
        return avgVoti;
    }
    
    
}