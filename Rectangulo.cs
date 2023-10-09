namespace _P2_2_Figuras;

public class Rectangulo : Figura
{
    protected double _base;
    protected double _altura;

    // Constructor
    public Rectangulo(double basee, double altura)
    {
        this._base = basee;
        this._altura = altura;
    }

    public override double GetArea()
    {
        return this._base * this._altura;
    }

    public override string ToString()
    {
        return $"""
        ______________________________________
        FIGURA RECTÁNGULO
        Base: {this._base}
        Altura: {this._altura}
        Area: {this.GetArea()}
        Color: [A=255, R=50, G=20, B=34]
        """;

    }
}

