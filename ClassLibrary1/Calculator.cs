using System;

namespace ClassLibrary1
{
    public class Calculator
    {
        #region private attribute
        private char operateur = ' ';
        private int operande1 = 4;
        private int operande2 = 2;
        private int resultat = 0;
        private int resultat1 = 0;
        private int resultat2 = 0;
        private int resultat3 = 0;
        #endregion private attribute

        void Main(string[] args)
        {
            resultat = additionner(operande1, operande2);
            resultat1 = soustraire(operande1, operande2);
            resultat2 = multiplier(operande1, operande2);
            resultat3 = diviser(operande1, operande2);
            Console.Write(operande1 + "+" + operande2 + "\n");
            Console.WriteLine(resultat);
            Console.Write(operande1 + "-" + operande2 + "\n");
            Console.WriteLine(resultat1);
            Console.Write(operande1 + "*" + operande2 + "\n");
            Console.WriteLine(resultat2);
            Console.Write(operande1 + "/" + operande2 + "\n");
            Console.WriteLine(resultat3);
            Console.ReadLine();
        }

        public int additionner(int op1, int op2)
        {
            return op1 + op2;
        }
        public int soustraire(int op1, int op2)
        {
            return op1 - op2;
        }
        public int multiplier(int op1, int op2)
        {
            return op1 * op2;
        }
        public int diviser(int op1, int op2)
        {
            if (op2 == 0)
            {
                return 0;
            }
            else return op1 / op2;
        }
    }
}
