using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operátorok
{
    class OperatorClass
    {
        int operandus1;
        string operatorhatorozo;
        int operandus2;

        public OperatorClass(int operandus1, string operatorhatorozo, int operandus2)
        {
            this.operandus1 = operandus1;
            this.operatorhatorozo = operatorhatorozo;
            this.operandus2 = operandus2;
        }

        public int Operandus1 { get => operandus1; }
        public string Operatorhatorozo { get => operatorhatorozo; }
        public int Operandus2 { get => operandus2; }


        public static string Meghatarozas(int operandus1, string operatorhatorozo, int operandus2)
        {
            try
            {
                if (operatorhatorozo == "+")
                {
                    return (operandus1 + operandus2).ToString();
                }
                else if (operatorhatorozo == "-")
                {
                    return (operandus1 - operandus2).ToString();
                }
                else if (operatorhatorozo == "*")
                {
                    return (operandus1 * operandus2).ToString();
                }
                else if (operatorhatorozo == "/")
                {
                    return (operandus1 / (double)operandus2).ToString();
                }
                else if (operatorhatorozo == "div")
                {
                    return (operandus1 / operandus2).ToString();
                }
                else if (operatorhatorozo == "mod")
                {
                    return ((double)operandus1 % (double)operandus2).ToString();
                }
                else
                {
                    return "Hibás operátor!";
                }
            }
            catch (Exception)
            {
                return "Egyéb hiba!";
            }
        }
    }
}
