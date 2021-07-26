using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
        public delegate void Operacao(BaseModels model);
    public class Crud
    {
        protected Operacao operacaocadastrar;
        protected Operacao operacaoRead;
        protected Operacao operacaoUpdate;
        protected Operacao operacaoDelete;
        public void Create(BaseModels model)
        {
            operacaocadastrar(model);
        }

        public void Read(BaseModels model)
        {
            operacaoRead(model);
        }
        public void ReadById()
        {
            //readbyid
        }
        public void Update()
        {
            //update
        }
        public void Delete()
        {
            //delete
        }
    }
}
