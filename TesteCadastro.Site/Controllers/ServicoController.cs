using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TesteCadastro.Application.Interfaces;
using TesteCadastro.Domain.Entities;

namespace TesteCadastro.Site.Controllers
{
    public class ServicoController : Controller
    {

        private readonly IApplicationServico _applicationServico;
        private readonly IApplicationTipoServico _applicationTipoServico;
        private readonly IApplicationCliente _applicationCliente;

        public ServicoController(IApplicationServico applicationServico,
            IApplicationTipoServico applicationTipoServico,
            IApplicationCliente applicationCliente)
        {
            _applicationServico = applicationServico;
            _applicationTipoServico = applicationTipoServico;
            _applicationCliente = applicationCliente;

           
        }

        [Authorize]
        public IActionResult Index()
        {

            ViewBag.TipoServicos = _applicationTipoServico.List().Select(t => new SelectListItem()
            { Text = t.Descricao, Value = t.Id.ToString() }).ToList();

            ViewBag.Clientes = _applicationCliente.List().Select(c => new SelectListItem()
            { Text = c.Nome, Value = c.Id.ToString() }).ToList();

            return View(_applicationServico.List());
        }

        [Authorize]
        public ActionResult Details(int id)
        {
           
            return View(_applicationServico.GetEntity(id));
        }

        [Authorize]
        public ActionResult Create()
        {
            ViewBag.TipoServicos = _applicationTipoServico.List().Select(t => new SelectListItem()
            { Text = t.Descricao, Value = t.Id.ToString() }).ToList();

            ViewBag.Clientes = _applicationCliente.List().Select(c => new SelectListItem()
            { Text = c.Nome, Value = c.Id.ToString() }).ToList();

            return View(new Servico());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Servico servico)
        {
            try
            {
                _applicationServico.Add(servico, User.Identity.Name);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.TipoServicos = _applicationTipoServico.List().Select(t => new SelectListItem()
                { Text = t.Descricao, Value = t.Id.ToString() }).ToList();

                ViewBag.Clientes = _applicationCliente.List().Select(c => new SelectListItem()
                { Text = c.Nome, Value = c.Id.ToString() }).ToList();

                return View();
            }
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            ViewBag.TipoServicos = _applicationTipoServico.List().Select(t => new SelectListItem()
            { Text = t.Descricao, Value = t.Id.ToString() }).ToList();

            ViewBag.Clientes = _applicationCliente.List().Select(c => new SelectListItem()
            { Text = c.Nome, Value = c.Id.ToString() }).ToList();

            return View(_applicationServico.GetEntity(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Servico servico)
        {
            try
            {
                _applicationServico.Update(servico, User.Identity.Name);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.TipoServicos = _applicationTipoServico.List().Select(t => new SelectListItem()
                { Text = t.Descricao, Value = t.Id.ToString() }).ToList();

                ViewBag.Clientes = _applicationCliente.List().Select(c => new SelectListItem()
                { Text = c.Nome, Value = c.Id.ToString() }).ToList();

                return View();
            }
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            ViewBag.TipoServicos = _applicationTipoServico.List().Select(t => new SelectListItem()
            { Text = t.Descricao, Value = t.Id.ToString() }).ToList();

            ViewBag.Clientes = _applicationCliente.List().Select(c => new SelectListItem()
            { Text = c.Nome, Value = c.Id.ToString() }).ToList();

            return View(_applicationServico.GetEntity(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Servico servico)
        {
            try
            {
                ViewBag.TipoServicos = _applicationTipoServico.List().Select(t => new SelectListItem()
                { Text = t.Descricao, Value = t.Id.ToString() }).ToList();

                ViewBag.Clientes = _applicationCliente.List().Select(c => new SelectListItem()
                { Text = c.Nome, Value = c.Id.ToString() }).ToList();
                _applicationServico.Delete(servico);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}