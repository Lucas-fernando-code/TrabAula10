using System;
using System.Collections.Generic;

namespace TrabAula10
{
class Programa
{
    static void Main(string[] args)
    {
      string c ="Circulo";
      string r ="Retangulo";
      string l = "Losango";

        Circulo circ = new Circulo(2.0);
      
        Retangulo reta1 = new Retangulo(2.0,20);

        Losango lol = new Losango(16,12);

        Dictionary<Figuras,string> lista = new Dictionary<Figuras,string>();
        lista.Add(reta1,r);
        lista.Add(circ,c);
        lista.Add(lol,l);
        Console.WriteLine("=========================");
        foreach(KeyValuePair<Figuras,string> a in lista){
          Console.WriteLine("Figura: {0}",a.Value);
          Console.WriteLine("Área:\t\t{0:0.0}", a.Key.Area);
        Console.WriteLine("Perímetro\t{0:0.0}",a.Key.Perimetro);
        Console.WriteLine("=========================");
        }
    }
}
}
