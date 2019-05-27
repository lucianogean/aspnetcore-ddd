using System.Collections.Generic;
using TesteCadastro.Application.Interfaces;
using TesteCadastro.Domain.Entities;
using TesteCadastro.Domain.Interfaces;

namespace TesteCadastro.Application.Application
{
    public class ApplicationCliente : IApplicationCliente
    {
        private readonly IClienteRepository _repository;

        public ApplicationCliente(IClienteRepository repository)
        {
            _repository = repository;
        }
        public void Add(Cliente entity)
        {
            _repository.Add(entity);
        }

        public void Delete(Cliente entity)
        {
            _repository.Delete(entity);
        }

        public Cliente GetEntity(int id)
        {
            return _repository.GetEntity(id);
        }

        public List<Cliente> List()
        {
            return _repository.List();
        }

        public void Update(Cliente entity)
        {
            _repository.Update(entity);
        }
    }    
}
