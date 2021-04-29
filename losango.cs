using System;

namespace TrabAula10
{
public class Losango : Figuras 
{
    private double _lado; 
    private double _diagona1;
    private double _diagona2;
    public double  Lado
    {
        
        get
        {
            return this._lado;
        }
        
        set
        {
          value =  this._lado = Math.Sqrt(Math.Pow(this.Diagona1/2,2) + Math.Pow(this.Diagona2/2,2));
            if (value <= 0)
            {
                Console.WriteLine("resposta errada");
            }
            else
            {
                this._lado = value;
                this.AtualizarPerimetro();
            }
        }
    } 
    public double Diagona1
    {
        
        get
        {
            return this._diagona1;
        }
        
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("resposta errada");
            }
            else
            {
                this._diagona1 = value;
                this.AtualizarPerimetro();
                this.AtualizarArea();
            }
        }
    }public double Diagona2
    {
        
        get
        {
            return this._diagona2;
        }
        
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("resposta errada");
            }
            else
            {
                this._diagona2 = value;
                this.AtualizarArea();
            }
        }
    }
    public Losango(double _diagona1,double _diagona2)
    {
       
        this.Diagona1 = _diagona1;
        this.Diagona2 = _diagona2;
        this.Lado = _lado;
    }
    private void AtualizarArea()
    {
        this._area = (this._diagona1 * this._diagona2) / 2;
    }
    private void AtualizarPerimetro()
    {
        this._perimetro = 4 *this.Lado;
    }
}
}