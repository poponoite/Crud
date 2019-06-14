using System.Collections.Generic;
using System.Linq;
namespace Crud.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validate();

        public bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }


        public void AdicionarMensagem(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

    }
}
