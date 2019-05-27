using TesteCadastro.Domain.Entities;

namespace TesteCadastro.Domain.Interfaces
{
    public interface IPrestadorRepository : IRepository<Prestador>
    {
        Prestador GetEntityByUser(string user);
    }
}
