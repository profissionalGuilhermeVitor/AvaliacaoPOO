using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelice
{
    internal class Peca
    {
        private string nome;
        private Peca anterior;

        public Peca()
        {
            this.Anterior = null;
        }

        public Peca(string _nome)
        {
           nome = _nome;
            this.Anterior = null;
        }

        public Peca(string _nome, Peca _anterior)
        {
            nome = _nome;
            anterior = _anterior;
        }

        public string Nome { get => nome; set => nome = value; }
        internal Peca Anterior { get => anterior; set => anterior = value; }
    }
}
