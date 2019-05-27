using TesteCadastro.Domain.Entities;

namespace TesteCadastro.Application.Interfaces
{
    public interface IApplicationServico : IApplication<Servico>
    {
        void Add(Servico Entity, string usuario);

        void Update(Servico entity, string usuario);
    }
}
