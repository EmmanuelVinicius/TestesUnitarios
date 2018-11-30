using System;

public class Triangulo
{
    public string DeterminaTipoTriangulo(int a, int b, int c)
    {
        string tipo;
        try
        {
            tipo = "ESCALENO";
            if (a <= 0 || b <= 0 || c <= 0)
                tipo = "INEXISTENTE";
            else if (!((a + b > c) && (a + c > b) && (b + c > a)))
                tipo = "INEXISTENTE";
            else if (a == b)
            {
                tipo = "ISOSCELES";
                if (b == c)
                    tipo = "EQUILATERO";
            }
            else if (b == c || a == c)
                tipo = "ISOSCELES";
        }
        catch (Exception ex)
        {
            tipo = ex.Message;
        }
            return tipo;
    }
}