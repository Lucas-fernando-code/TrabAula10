using System;

namespace TrabAula10
{
public class Retangulo : Figuras 
{
    private double _largura; 
    private double _altura;
    public double Largura 
    {
        
        get
        {
            return this._largura;
        }
        
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("resposta errada");
            }
            else
            {
                this._largura = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();
            }
        }
    } 
    public double Altura
    {
        
        get
        {
            return this._altura;
        }
        
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("resposta errada");
            }
            else
            {
                this._altura = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();
            }
        }
    }
    public Retangulo(double _largura,double _altura)
    {
       
        this.Largura = _largura;
        this.Altura = _altura;
    }
    private void AtualizarArea()
    {
        this._area = this._largura * this._altura;
    }
    private void AtualizarPerimetro()
    {
        this._perimetro = 2 *(this._largura + this._altura);
    }
}
}