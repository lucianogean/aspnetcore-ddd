using Microsoft.EntityFrameworkCore;
using System.Linq;
using TesteCadastro.Domain.Entities;
using TesteCadastro.Domain.Interfaces;
using TesteCadastro.Infra.Data;

namespace TesteCadastro.Infra.Repository
{
    public class PrestadorRepository : Repository<Prestador>, IPrestadorRepository
    {
        private readonly DbContextOptionsBuilder<ContextBase> _OptionsBuider;

        public PrestadorRepository()
        {
            _OptionsBuider = new DbContextOptionsBuilder<ContextBase>();
        }

        public Prestador GetEntityByUser(string user)
        {
            using (var banco = new ContextBase(_OptionsBuider.Options))
            {
                return banco.Set<Prestador>().Where(p => p.Usuario == user).SingleOrDefault();
            }
        }
    }
}
