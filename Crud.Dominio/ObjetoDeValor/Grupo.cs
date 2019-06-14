using Crud.Dominio.Entidades;
using Crud.Dominio.Enumerados;
namespace Crud.Dominio.ObjetoDevalor
{
    public class Grupo : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public bool EhTsa
        {
            get { return Id == (int)GrupoEnum.TSA; }

        }

        public bool EhLynx
        {
            get { return Id == (int)GrupoEnum.LYNX; }
        }

       

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagem("O campo nome deve ser preenchido!");
            }
        }
    }
}
