using NUnit.Framework;
using System;

namespace TestesUnitariosNUnit.Test
{
    [TestFixture]
    public class TrianguloTest
    {
        Random valor = new Random();
        [Test]
        public void ValoresDosTriangulos()
        {
            for (int i = 0; i < 10; i++)
            {
                int primeiroValor = valor.Next(10);
                int segundoValor = valor.Next(10);
                int terceiroValor = valor.Next(10);
                string resultado = new Triangulo().DeterminaTipoTriangulo(primeiroValor, segundoValor, terceiroValor);
            }
        }
        [Test]
        public void SequenciaFibonacci()
        {
            for (int i = 0; i < 10; i++)
            {
                string fibonacci = new Fibonacci().NumeroFibonacci(valor.Next(10));
            }
        }
    }
}