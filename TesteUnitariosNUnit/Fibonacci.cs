using System;

public class Fibonacci
{
    public string NumeroFibonacci(int n)
    {
        string numeroDeVolta;
        try
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            numeroDeVolta = a.ToString();
        }
        catch (Exception ex)
        {
            numeroDeVolta = ex.Message;
        }
        return numeroDeVolta;

    }
}