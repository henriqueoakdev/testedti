using System;

namespace TesteDTI
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtdCaloricaTotal = 0;
            int numAlimentos = 0, cont1 = 0, cont2 = 0, cont3 = 0, grupoMaior = 0;
            Alimento listaAlimentos = new Alimento();
            Paciente paciente = new Paciente();
            Consulta consulta = new Consulta();

            //Entrada de informações do paciente
            Console.WriteLine("Entre com os dados do paciente:");
            Console.WriteLine("Nome:");
            paciente.nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            paciente.endereco = Console.ReadLine();
            Console.WriteLine("Telefone:");
            paciente.telefone = Console.ReadLine();
            Console.WriteLine("E-mail:");
            paciente.email = Console.ReadLine();
            Console.WriteLine("Data de nascimento:");
            paciente.dataNascimento = Console.ReadLine();

            //Entrada de informações da consulta
            Console.WriteLine("Entre com os dados da consulta");
            Console.WriteLine("Data:");
            consulta.data = Console.ReadLine();
            Console.WriteLine("Horário:");
            consulta.horario = Console.ReadLine();
            Console.WriteLine("Peso:");
            consulta.peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem de gordura no corpo:");
            consulta.pctGorduraPessoal = double.Parse(Console.ReadLine());
            Console.WriteLine("Sensação física do paciente:");
            consulta.sensacao = Console.ReadLine();
            Console.WriteLine("Restrições alimentares:");
            consulta.restricoes = Console.ReadLine();

            //Entrada de informações para fazer o cálculo de calorias
            Console.WriteLine("Entre com a quantidade calórica limite:");
            qtdCaloricaTotal = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre o número de alimentos que deseja usar para o cálculo de calorias:");
            numAlimentos = int.Parse(Console.ReadLine());

            string[] grupo1 = new string[numAlimentos];
            string[] grupo2 = new string[numAlimentos];
            string[] grupo3 = new string[numAlimentos];

            double[] grupoValorCal1 = new double[numAlimentos];
            double[] grupoValorCal2 = new double[numAlimentos];
            double[] grupoValorCal3 = new double[numAlimentos];

            Console.WriteLine("Informe os alimentos, seus grupos e seu valor calórico:");
            for (int i = 0; i < numAlimentos; i++)
            {
                Console.WriteLine("Alimento número " + (i + 1) + ":");
                Console.WriteLine("Nome:");
                listaAlimentos.nome = Console.ReadLine();
                Console.WriteLine("Grupo(De 1 à 3):");
                listaAlimentos.grupo = int.Parse(Console.ReadLine());

                if (listaAlimentos.grupo < 1 || listaAlimentos.grupo > 3)
                {
                    Console.WriteLine("Grupo(De 1 à 3):");
                    listaAlimentos.grupo = int.Parse(Console.ReadLine());
                }

                if (listaAlimentos.grupo == 1)
                {
                    cont1++;
                } 
                else if (listaAlimentos.grupo == 2)
                {
                    cont2++;
                } 
                else if (listaAlimentos.grupo == 3)
                {
                    cont3++;
                }

                Console.WriteLine("Valor calórico:");
                listaAlimentos.valorCalorico = double.Parse(Console.ReadLine());

                if (listaAlimentos.grupo.Equals(1))
                {
                    grupo1[i] = listaAlimentos.nome;
                    grupoValorCal1[i] = listaAlimentos.valorCalorico;
                } 
                else if (listaAlimentos.grupo.Equals(2))
                {
                    grupo2[i] = listaAlimentos.nome;
                    grupoValorCal2[i] = listaAlimentos.valorCalorico;
                } 
                else if (listaAlimentos.grupo.Equals(3))
                {
                    grupo3[i] = listaAlimentos.nome;
                    grupoValorCal3[i] = listaAlimentos.valorCalorico;
                }
            }

            if (cont1 > cont2 && cont1 > cont3 || cont1 > cont2 && cont1 == cont3 || cont1 == cont2 && cont1 > cont3)
            {
                grupoMaior = cont1;
            } 
            else if (cont2 > cont1 && cont2 > cont3 || cont2 > cont1 && cont2 == cont3 || cont2 == cont1 && cont2 > cont3)
            {
                grupoMaior = cont2;
            }
            else if (cont3 > cont1 && cont3 > cont2 || cont3 > cont1 && cont3 == cont2 || cont3 == cont1 && cont3 > cont2)
            {
                grupoMaior = cont3;
            }

            Console.WriteLine("Combinações de alimentos dentro do valor máximo de calorias:");
            for (int i = 0; i < grupoMaior; i++)
            {
                for (int j = 0; j < grupoMaior; j++)
                {
                    for (int k = 0; k < grupoMaior; k++)
                    {
                        if (grupoValorCal1[i] + grupoValorCal2[j] + grupoValorCal3[k] <= qtdCaloricaTotal)
                        {
                            Console.Write(grupoValorCal1[i] + ", " + grupoValorCal2[j] + " e " + grupoValorCal3[k] + ".");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
