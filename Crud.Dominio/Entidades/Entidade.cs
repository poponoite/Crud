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

        public virtual void Validate()
        {

        }

        public bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }

        public void LimparMensagem()
        {
            MensagemValidacao.Clear();
        }

        public void AdicionarMensagem(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

    }
}
