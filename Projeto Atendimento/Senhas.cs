using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    public class Senhas : IEnumerable<Senha>
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Queue<Senha> FilaSenhas => filaSenhas;

        public Senhas()
        {
            this.filaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 1;
        }

        public void gerar()
        {
            this.filaSenhas.Enqueue(new Senha(this.proximoAtendimento));
            this.proximoAtendimento++;
        }

        public IEnumerator<Senha> GetEnumerator()
        {
            return filaSenhas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}