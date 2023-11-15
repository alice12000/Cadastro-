using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace cadastrodefuncionario
{
    internal class Validacao
    {
        public static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += (cpf[i] - '0') * (10 - i);
            }
            int primeiroDigito = 11 - (soma % 11);

            if (primeiroDigito >= 10)
            {
                primeiroDigito = 0;
            }

            if (primeiroDigito != cpf[9] - '0')
            {
                return false;
            }

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += (cpf[i] - '0') * (11 - i);
            }
            int segundoDigito = 11 - (soma % 11);
            if (segundoDigito >= 10)
            {
                segundoDigito = 0;
            }

            return segundoDigito == cpf[10] - '0';
        }

        public static bool ValidarEmail(string email)
        {
            bool verificarEmail = email.Contains("@") && email.Contains(".com");

            if(verificarEmail == true)
            {
                return true;
            }

            return false;
        }
    }
}
