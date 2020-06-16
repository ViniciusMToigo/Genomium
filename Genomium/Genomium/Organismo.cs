using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genomium
{
    public class Organismo
    {
        #region Propriedades

        public string Nome { get; set; }
        public string Gene { get; set; }
        public string Tipo { get; set; }
        public string Familia { get; set; }
        public string PapelBiologico { get; set; }
        public int PosicaoInicial { get; set; }
        public int PosicaoFinal { get; set; }
        public string SequenciaDNA { get; set; }

        #endregion

        #region Construtor

        public Organismo(string nome,
            string gene,
            string tipo,
            string familia, 
            string papelBiologico, 
            int posicaoInicial, 
            int posicaoFinal, 
            string sequenciaDNA)
        {
            this.Nome = nome;
            this.Gene = gene;
            this.Tipo = tipo;
            this.Familia = familia;
            this.PapelBiologico = papelBiologico;
            this.PosicaoInicial = posicaoInicial;
            this.PosicaoFinal = posicaoFinal;
            this.SequenciaDNA = sequenciaDNA;
        }

        #endregion
    }
}
