using System;

namespace ExerciciosSecao2
{
    class Retangulo
    {
        public double largura;
        public double altura;
        public double area()
        {
            return largura * altura;
        }

        public double perimetro()
        {
            return largura + altura + largura + altura;
        }

        public double diagonal ()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }
       
    }
}
