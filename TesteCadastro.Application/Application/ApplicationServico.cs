using System.Collections.Generic;
using TesteCadastro.Application.Interfaces;
using TesteCadastro.Domain.Entities;
using TesteCadastro.Domain.Interfaces;

namespace TesteCadastro.Application.Application
{
    public class ApplicationServico : IApplicationServico
    {
        private readonly IServicoRepository _repository;
        private readonly IClienteRepository _clienteRepository;
        private readonly ITipoServicoRepository _tipoServicoRepository;
        private readonly IPrestadorRepository _prestadorRepository;


        public ApplicationServico(IServicoRepository repository,
            ITipoServicoRepository tipoServicoRepository,
            IClienteRepository clienteRepository,
            IPrestadorRepository prestadorRepository)
        {
            _repository = repository;
            _tipoServicoRepository = tipoServicoRepository;
            _clienteRepository = clienteRepository;
            _prestadorRepository = prestadorRepository;
        }

        public void Add(Servico entity, string usuario)
        {
            var prestador = _prestadorRepository.GetEntityByUser(usuario);

            if (prestador == null)
            {
                prestador = new Prestador();
                prestador.Nome = usuario;
                prestador.CnpjCpf = string.Empty;
                prestador.Endereco = string.Empty;
                prestador.Usuario = usuario;
                entity.Prestador = prestador;
            }
            else
            {
                entity.PrestadorId = prestador.Id;
            }

            _repository.Add(entity);
        }

        public void Add(Servico entity)
        {
            _repository.Add(entity);
        }

        public void Delete(Servico entity)
        {
            _repository.Delete(entity);
        }

        public Servico GetEntity(int id)
        {
            var entity = _repository.GetEntity(id);
            entity.TipoServico = _tipoServicoRepository.GetEntity(entity.TipoServicoId);
            entity.Cliente = _clienteRepository.GetEntity(entity.ClienteId);

            return entity;
        }

        public List<Servico> List()
        {
            return _repository.List();
        }

        public void Update(Servico entity)
        {
            _repository.Update(entity);
        }

        public void Update(Servico entity, string usuario)
        {
            var prestador = _prestadorRepository.GetEntityByUser(usuario);

            if (prestador == null)
            {
                prestador = new Prestador();
                prestador.Nome = usuario;
                prestador.CnpjCpf = string.Empty;
                prestador.Endereco = string.Empty;
                prestador.Usuario = usuario;
                entity.Prestador = prestador;
            }
            else
            {
                entity.PrestadorId = prestador.Id;
            }

            _repository.Update(entity);
        }



    }
}
