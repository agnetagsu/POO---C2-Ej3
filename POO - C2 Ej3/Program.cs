using System;

namespace POO___C2_Ej3
{
    class Operaciones
    {
        private int operando1;
        private int operando2;

        public Operaciones(int operando1, int operando2)
        {
            this.operando1 = operando1;
            this.operando2 = operando2;
        }
        public void printOperandos()
        {
            System.Console.WriteLine("operando1: {0}\noperando2: {1}", this.operando1, this.operando2);
        }

        public int Operando1
        {
            get { return operando1; }
        }
        public int Operando2
        {
            get { return operando2; }
        }

        public int Suma()
        {
            return this.operando1 + this.operando2;
        }
        public int Resta()
        {
            return this.operando1 - this.operando2;
        }
        public int Multiplicacion()
        {
            return this.operando1 * this.operando2;
        }
        public int Division()
        {
            return this.operando1 / this.operando2;
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Operaciones A1 = new Operaciones(18, 6);
            A1.printOperandos();
            System.Console.WriteLine("La Suma es:{0}\nLa Resta es: {1}\nLa Multiplicación es: {2}\nLa División es: {3}", A1.Suma(), A1.Resta(), A1.Multiplicacion(), A1.Division());

        }
    }
}
