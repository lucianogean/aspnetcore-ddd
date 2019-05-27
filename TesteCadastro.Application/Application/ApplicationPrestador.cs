using System.Collections.Generic;
using TesteCadastro.Application.Interfaces;
using TesteCadastro.Domain.Entities;
using TesteCadastro.Domain.Interfaces;

namespace TesteCadastro.Application.Application
{
    public class ApplicationPrestador : IApplicationPrestador
    {
        private readonly IPrestadorRepository _repository;

        public ApplicationPrestador(IPrestadorRepository repository)
        {
            _repository = repository;
        }
        public void Add(Prestador entity)
        {
            _repository.Add(entity);
        }

        public void Delete(Prestador entity)
        {
            _repository.Delete(entity);
        }

        public Prestador GetEntity(int id)
        {
            return _repository.GetEntity(id);
        }

        public List<Prestador> List()
        {
            return _repository.List();
        }

        public void Update(Prestador entity)
        {
            _repository.Update(entity);
        }
    }    
}
