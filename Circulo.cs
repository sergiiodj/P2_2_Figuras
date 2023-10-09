namespace _P2_2_Figuras;

public class Circulo : Figura
{
    protected double _radio;

    //Constructor
    public Circulo(double radio) => this._radio = radio;

    public override double GetArea()
    {
        return Math.PI * (this._radio * this._radio);
    }

    public override string ToString()
    {
        return $"""
        ______________________________________
        FIGURA CÍRCULO
        Radio: {this._radio}
        Area: {this.GetArea()}
        Color: [A=255, R=50, G=20, B=34]
        """;

    }
}