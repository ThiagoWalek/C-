// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            int grins = 0;
            byte pss3 = 0;
            int maiordeidade = 0;
            int menordeidade = 0;

            char resp;
            string nomeusuario = "m";

            float c1 = 0;
            byte c2 = 0;
            float c3 = 0;

            byte qtdp = 0;
            int tidade = 0;
            float tsalario = 0;
            float tdolar = 0;

            float maiorsalario = 0;
            string nome_melhor = "m";
            int idade_melhor = 0;
            int grau_melhor = 0;
            float menorsalario = 0;
            string nome_pior = "m";
            int idade_pior = 0;
            int grau_pior = 0;


            do
            {
                //nome do usuário
                Console.WriteLine("Digite o nome do usuário");
                nomeusuario = Console.ReadLine();

                //salário do usuário
                Console.WriteLine("Digite o valor do salário do usuário (R$)");
                float salario = float.Parse(Console.ReadLine());

                while (salario <= 0)
                
                    Console.WriteLine("Valor incorreto, digite o salário do usuário novamente");
                    salario = float.Parse(Console.ReadLine());
                

                //Idade
                Console.WriteLine("Digite a idade do usuário");
                int idade = int.Parse(Console.ReadLine());

                while (idade <= 0 || idade>=255)
                
                    Console.WriteLine("Valor incorreto, digite a idade do usuário novamente");
                    idade = int.Parse(Console.ReadLine());
                

                //maior e menor idade diferença entre eles, comparativo de 25 anos (B)

                if (idade > 25)
                
                    maiordeidade += 1;
                
                else
                
                    menordeidade += 1;
                

                if (maiordeidade >= menordeidade)
                
                    maiordeidade = maiordeidade - menordeidade;
                
                else
                
                    menordeidade = menordeidade - maiordeidade;
                

                //valor de cotação do dólar
                Console.WriteLine("Digite o valor da cotação do dolár");
                float dolar = float.Parse(Console.ReadLine());

                while (dolar <= 0 || dolar >= 255)
                
                    Console.WriteLine("Valor incorreto, digite a cotação do dolár novamente");
                    dolar = float.Parse(Console.ReadLine());
                

                Console.WriteLine("Informe o Grau de Instrução do usuário com base nessa tabela: (1) - primário, (2) - Segundo Grau e (3) – Superior");
                grins = int.Parse(Console.ReadLine());

                while (grins != 1 && grins != 2 && grins != 3)
                
                    Console.WriteLine("Grau de instrução incorreto: (1) - primário, (2) - Segundo Grau e (3) – Superior");
                    grins = int.Parse(Console.ReadLine());
                

                if (grins == 1)
                
                    c1 += 1;
                

                //media de pessoas de segundo grau (C)

                if (grins == 2)
                
                    tidade += idade;
                    c2 += 1;
                

                //numero de pessoas que são superiores e ganham acima de 500 reais (A)
                if (grins == 3)
                {
                    c3 += 1;
                    if (salario > 500.00)
                    {
                        pss3 += 1;
                    }
                }

                qtdp += 1;

                if (qtdp == 1)
                
                    nome_melhor = nomeusuario;
                    idade_melhor = idade;
                    grau_melhor = grins;
                    maiorsalario = salario;
                    menorsalario = salario;
                    nome_pior = nomeusuario;
                    idade_pior = idade;
                    grau_pior = grins;
                

                if (maiorsalario < salario)
                
                    nome_melhor = nomeusuario;
                    idade_melhor = idade;
                    grau_melhor = grins;
                    maiorsalario = salario;
                

                if (menorsalario > salario)
                
                    nome_pior = nomeusuario;
                    idade_pior = idade;
                    grau_pior = grins;
                    menorsalario = salario;
                

                tsalario += salario;
                tdolar += dolar;

                //testes de condição para a repetição do programa (H)
                Console.WriteLine("Deseja continuar (s/n)");
                resp = char.Parse(Console.ReadLine());

                while (resp != 's' && resp != 'n')
                {
                    Console.WriteLine("Valor incorreto, digite novamente (s/n)");
                    resp = char.Parse(Console.ReadLine());
                }

            } while (resp == 's');

            if (tidade != 0)
            
                tidade /= c2;
            

            //percentual das pessoas do primario e superior em relação ao total (D)
            c1 = (c1 * 100) / qtdp;
            c3 = (c3 * 100) / qtdp;

            if (tsalario >= 20000)
            
                tsalario += ((tsalario * 20) / 100);
            
            
            if (tsalario >= 35000)
            
                tsalario += ((tsalario * 10) / 100);
            

            if (tsalario >= 45000)
            
                tsalario += ((tsalario * 5) / 100);
            

            if (tsalario >= 50000)
            
                tsalario += ((tsalario * 3) / 100);
            

            tdolar /= qtdp;
            tdolar = tsalario / tdolar;

            Console.WriteLine("Número de pessoas que possuem curso superior e ganham mais do que R$ 500,00 reais: " + pss3);

            if (maiordeidade >= menordeidade)
            {
                maiordeidade = maiordeidade - menordeidade;
                Console.WriteLine("A diferença entre a quantidade de pessoas com mais de 25 anos menos de 25 anos: " + maiordeidade);
            }
            else
            {
                menordeidade = menordeidade - maiordeidade;
                Console.WriteLine("A diferença entre a quantidade de pessoas com mais de 25 anos menos de 25 anos: " + menordeidade);
            }

            Console.WriteLine("A idade média das pessoas que possuem 2o grau: " + tidade);

            Console.WriteLine("percentual de pessoas que possuem o curso Primário: " + c1 + "%");
            Console.WriteLine("percentual de pessoas que possuem o curso Superior: " + c3 + "%");

                Console.WriteLine("Informações da pessoa com maior salário:");
                Console.WriteLine("Nome da pessoa com maior salário = "+nome_melhor);
                Console.WriteLine("Grau de instrução = "+grau_melhor);
                Console.WriteLine("Idade = "+idade_melhor);
                Console.WriteLine("Salário = "+maiorsalario);
                Console.WriteLine("Nome da pessoa com menor salário = "+nome_melhor);

            if (qtdp >= 2)
            {
                Console.WriteLine("Informações da pessoa com menor salário:");
                Console.WriteLine("Nome da pessoa com menor salário = "+nome_pior);
                Console.WriteLine("Grau de instrução = "+grau_pior);
                Console.WriteLine("Idade = "+idade_pior);
                Console.WriteLine("Salário = "+menorsalario);
                Console.WriteLine("Nome da pessoa com menor salário = "+nome_pior);
            }

            Console.WriteLine("somatória dos salários: " + tsalario);

            Console.WriteLine("Conversão de reais para dolar: " + tdolar);
        }
    }
}