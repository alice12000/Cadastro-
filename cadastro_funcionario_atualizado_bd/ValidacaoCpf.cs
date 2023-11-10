using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel;

namespace cadastro_funcionario_atualizado_bd
{
    public static class ValidacaoCpf
    {
        public static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");
            int soma;
            int soma2;
            int calculo;
            int resto2;
            int calculo2;
            //tirando os pontos e traços do cpf:

            //verificando se o cpf tem diferente de 11 posições
                int zero = Convert.ToInt32(Convert.ToString(cpf[0])) * 10;
                int um = Convert.ToInt32(Convert.ToString(cpf[1])) * 9;
                int dois = Convert.ToInt32(Convert.ToString(cpf[2])) * 8;
                int tres = Convert.ToInt32(Convert.ToString(cpf[3])) * 7;
                int quatro = Convert.ToInt32(Convert.ToString(cpf[4])) * 6;
                int cinco = Convert.ToInt32(Convert.ToString(cpf[5])) * 5;
                int seis = Convert.ToInt32(Convert.ToString(cpf[6])) * 4;
                int sete = Convert.ToInt32(Convert.ToString(cpf[7])) * 3;
                int oito = Convert.ToInt32(Convert.ToString(cpf[8])) * 2;
                int primeirodigito = Convert.ToInt32(Convert.ToString(cpf[9]));
                int segundodigito = Convert.ToInt32(Convert.ToString(cpf[10]));

                soma = zero + um + dois + tres + quatro + cinco + seis + sete + oito;
                int restoDivisao = soma % 11;

                if (restoDivisao < 2)
                {
                    if (primeirodigito != 0)
                    {
                        //o digito tem que ser igual 0, então return false se diferente
                        return false;
                    }

                }

                else
                {
                    calculo = 11 - (restoDivisao);
                    if (primeirodigito != calculo)
                    {
                        return false;

                    }

                }

                //recebendo cada posição do cpf e armazenando e multiplicando na sua variavel.
                int zero2 = Convert.ToInt32(Convert.ToString(cpf[0])) * 11;
                int um2 = Convert.ToInt32(Convert.ToString(cpf[1])) * 10;
                int dois2 = Convert.ToInt32(Convert.ToString(cpf[2])) * 9;
                int tres2 = Convert.ToInt32(Convert.ToString(cpf[3])) * 8;
                int quatro2 = Convert.ToInt32(Convert.ToString(cpf[4])) * 7;
                int cinco2 = Convert.ToInt32(Convert.ToString(cpf[5])) * 6;
                int seis2 = Convert.ToInt32(Convert.ToString(cpf[6])) * 5;
                int sete2 = Convert.ToInt32(Convert.ToString(cpf[7])) * 4;
                int oito2 = Convert.ToInt32(Convert.ToString(cpf[8])) * 3;
                int nove = Convert.ToInt32(Convert.ToString(cpf[9])) * 2;

                soma2 = zero2 + um2 + dois2 + tres2 + quatro2 + cinco2 + seis2 + sete2 + oito2 + nove;
                resto2 = soma2 % 11;

                if (resto2 < 2)
                {
                    if (segundodigito != 0)
                    {
                        return false;

                    }

                }

                else
                {
                    calculo2 = 11 - (resto2);
                    if (segundodigito != calculo2)
                    {
                        return false;

                    }

                }

                return true;
            }

    }

}