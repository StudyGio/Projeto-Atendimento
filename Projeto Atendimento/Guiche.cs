using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    public class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id => id;
        public Queue<Senha> Atendimentos => atendimentos;

        public Guiche()
        {
            this.atendimentos = new Queue<Senha>();
            this.id = 0;
        }

        public Guiche(int id)
        {
            this.atendimentos = new Queue<Senha>();
            this.id = id;
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas == null || filaSenhas.Count == 0)
            {
                return false;
            }

            Senha senhaAtendida = filaSenhas.Dequeue();
            senhaAtendida.DataAtend = DateTime.Now.Date;
            senhaAtendida.HoraAtend = DateTime.Now;

            this.atendimentos.Enqueue(senhaAtendida);
            return true;
        }
    }
}
