using Crud.Dominio.ObjetoDevalor;

namespace Crud.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //public virtual Grupo Grupo { get; set; }

        public override void Validate()
        {
            LimparMensagem();
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagem("O campo nome deve ser preenchido!");
            }

        }
    }
}
