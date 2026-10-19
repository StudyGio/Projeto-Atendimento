using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    public class Guiches
    {
        private List<Guiche> listaGuiches;

        public List<Guiche> ListaGuiches => listaGuiches;

        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            this.listaGuiches.Add(guiche);
        }
    }
}
