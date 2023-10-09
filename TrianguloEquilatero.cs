namespace _P2_2_Figuras;

public class TrianguloEquilatero : Figura
{
    protected double _lado;
    protected double _altura;

    //Constructor
    public TrianguloEquilatero(double lado, double altura)
    {
        this._lado = lado;
        this._altura = altura;
    }

    public override double GetArea()
    {
        return (this._lado * this._altura) / 2;
    }

    public override string ToString()
    {
        return $"""
        ______________________________________
        FIGURA TRIANGULO EQUILÁTERO
        Lado: {this._lado}
        Altura: {this._altura}
        Area: {this.GetArea()}
        Color: [A=255, R=50, G=20, B=34]
        """;

    }
}