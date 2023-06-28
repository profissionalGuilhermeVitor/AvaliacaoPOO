using ConsoleAppHelice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto
{
    internal class Pilha
    {
        private Peca topo;
        private int porto;

        public Pilha()
        {
            Topo = null;
        }

        public Pilha(Peca topo)
        {
            this.Topo = topo;
        }

        public int Porto { get => porto; set => porto = value; }
        internal Peca Topo { get => topo; set => topo = value; }

        public bool estarVazia()
        {
            if (Topo == null) return true;
            else return false;
        }

        public void inserir(string nome)
        {
            if (estarVazia())
            {
                Peca novaPilha = new Peca(nome);
                topo = novaPilha;
            }
            else
            {
                Peca novaPilha = new Peca(nome, topo);
                topo = novaPilha;
            }
        }


        public string subPeca(string nome)
        {
            if (NomeExiste(nome))
            {
                
                return  nome + "(Nova)";
            }
            else
            {
                return null;
            }

        }

        public bool remover()
        {
            if (estarVazia())
            {
                return false;
            }
            else
            {
                topo = topo.Anterior;
                return true;
            }
        }

        public int quantPilha()
        {
            int n = 0;
            Peca temp = topo;
            while (temp != null)
            {
                temp = temp.Anterior;
                n++;
            }
            return n;

        }

        public bool estaCheia()
        {
            if (quantPilha() >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NomeExiste(string Nome)
        {
            Peca temp = topo;
            while (temp != null)
            {
                if (temp.Nome.Equals(Nome))
                {
                    return true;
                }
                else { temp = temp.Anterior; }
            }
            return false;
        }

        public void imprime(int i)
        {
            switch (i)
            {
                case 1:
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine("|" + Topo.Nome + "|\n");
                    }
                    break;
                case 2:
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("|" + Topo.Nome + "|" + Topo.Anterior.Nome + "|\n");
                        break;
                    }
                    break;
                case 4:
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("|" + Topo.Nome + "|\n" + Topo.Anterior.Nome + "|\n" + Topo.Anterior.Anterior.Nome + "|\n" + Topo.Anterior.Anterior.Anterior.Nome + "|\n");
                        break;
                    }
                    break;
                case 3:
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("|" + Topo.Nome + "|\n" + Topo.Anterior.Nome + "|\n" + Topo.Anterior.Anterior.Nome + "|\n");
                        break;
                    }
                    break;
            }
            try
            {
                string code = Topo.Nome;
            }
            catch (Exception e) { Console.WriteLine("|      |"); }
        }
    }
}
