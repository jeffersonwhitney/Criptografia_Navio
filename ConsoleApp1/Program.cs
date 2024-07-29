using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Seja bem vindo ao Intelitrader criptografia---\n");
            bool loop = true;
            do
            {
                Console.WriteLine("Escolha uma opção abaixo:\n 1-Descriptografar mensagem\n 0-Sair");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Digite o código para descriptografar:");
                        string mensagemCript = Descriptografia(Console.ReadLine());
                        Console.WriteLine(mensagemCript);
                        break;
                    case 0:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            while (loop);
        }
        static string Descriptografia(string mensagemDescrip)
        {
            char[] mensagemDescripChar = Regex.Replace(mensagemDescrip, @"\s+", "").ToCharArray();   //retirando os espaços em branco da mensagem
            int comprimento = mensagemDescripChar.Length;                       //obtendo o tamanho total da string
            char[] temp;

            for (int i = 7; i < comprimento; i+=8)
            {
                char alg = mensagemDescripChar[i];
                mensagemDescripChar[i] = mensagemDescripChar[i-1];
                mensagemDescripChar[i-1] = alg;
            }
            for (int i = 3; i < comprimento; i += 4)
            {   
                char temp[i - 3] = mensagemDescripChar[i + 1];
                char temp[i - 2] = mensagemDescripChar[i + 2];
                char temp[i - 1] = mensagemDescripChar[i + 3];

                mensagemDescripChar[i] = mensagemDescripChar[i - 1];
                mensagemDescripChar[i - 1] = alg;
            }


            return new  string(mensagemDescripChar);
        }
    }
}
