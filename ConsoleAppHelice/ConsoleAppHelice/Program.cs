using ConsoleAppHelice;
using Porto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static bool IsNumeric(object Expression)
{
    double retNum;

    bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
    return isNum;
}
//Criar pilhas para cada local
Pilha pilha1 = new Pilha();
Pilha pilhasub = new Pilha();
bool sair = false;
string[] pos = new string[4];
string nomePeca;
pilha1.inserir("Suporte");
pilha1.inserir("Helice");
pilha1.inserir("Lampada");
pilha1.inserir("Cupula de vidro");
try
{
    while (sair == false)
    {
        Console.WriteLine("----------------------------------ROBÔ MONTADOR-----------------------------------");
        int aux = 0;
        Console.WriteLine("Quantidade de peças montadas: "+ pilha1.quantPilha());
        pilha1.imprime(pilha1.quantPilha());
        //Imprimir pilhas completa
        //Definir para usuário qual opção escolher: Remover ou Inserir
        Console.WriteLine("\nDefina qual peća trocar:\n");
        Console.WriteLine("Digite [3] para SAIR");


        nomePeca = Console.ReadLine();
        //Muda peça defeituosa
        if (nomePeca == "3")
        {
            Environment.Exit(0);
        }

        else if (pilha1.NomeExiste(nomePeca) == false)
        {
            Console.WriteLine("O NOME DESTA PEÇA NÂO EXISTE NO PRODUTO!! TENTE NOVAMENTE!!");
            continue;
        }

        for (int i = pilha1.quantPilha(); i > 0; i--)
        {

            pos[aux] = pilha1.Topo.Nome;
            if (pilha1.Topo.Nome == nomePeca)
            {
                pilha1.Topo.Nome = pilha1.subPeca(nomePeca);
                break;

            }
            else
            {
                pilha1.remover();
            }
            Console.WriteLine("\n-------------------Remoção----------------");
            pilha1.imprime(pilha1.quantPilha());
            aux++;
        }
        for (int j = aux; j > 0; j--)
        {

            pilha1.inserir(pos[j - 1]);
        }
        Console.WriteLine("\n-------------------Inserção----------------");
        pilha1.imprime(pilha1.quantPilha());
    }
}
catch(Exception e)
{
    Console.WriteLine("\n" + e.ToString());
}
    



    






