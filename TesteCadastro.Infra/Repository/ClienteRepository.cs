using TesteCadastro.Domain.Entities;
using TesteCadastro.Domain.Interfaces;

namespace TesteCadastro.Infra.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
    }
}
