using System.Collections.Generic;
using TesteCadastro.Application.Interfaces;
using TesteCadastro.Domain.Entities;
using TesteCadastro.Domain.Interfaces;

namespace TesteCadastro.Application.Application
{
    public class ApplicationTipoServico : IApplicationTipoServico
    {
        private readonly ITipoServicoRepository _repository;

        public ApplicationTipoServico(ITipoServicoRepository repository)
        {
            _repository = repository;
        }
        public void Add(TipoServico entity)
        {
            _repository.Add(entity);
        }

        public void Delete(TipoServico entity)
        {
            _repository.Delete(entity);
        }

        public TipoServico GetEntity(int id)
        {
            return _repository.GetEntity(id);
        }

        public List<TipoServico> List()
        {
            return _repository.List();
        }

        public void Update(TipoServico entity)
        {
            _repository.Update(entity);
        }
    }
}
