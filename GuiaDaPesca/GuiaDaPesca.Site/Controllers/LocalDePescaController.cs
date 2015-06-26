using AutoMapper;
using GuiaDaPesca.Domain.Interfaces.Repositories;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Site.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GuiaDaPesca.Site.Controllers
{
    public class LocalDePescaController : Controller
    {
        public ActionResult Novo()
        {
            //TODO: Usar AutoMapper
            List<TipoLocalDePescaViewModel> tiposLocalDePescaViewModel = new List<TipoLocalDePescaViewModel>();
            List<SelectListItem> itens = new List<SelectListItem>();
            List<TipoLocalDePesca> tiposLocalDePesca = new TipoLocalDePescaRepository().Buscar();

            ModelToViewModel(tiposLocalDePesca, tiposLocalDePescaViewModel);
            //tiposLocalDePescaViewModel = Mapper.Map<List<TipoLocalDePescaViewModel>>(tiposLocalDePesca);

            foreach (var item in tiposLocalDePescaViewModel)
            {
                itens.Add(new SelectListItem()
                {
                    Text = item.Comentario.Descricao,
                    Value = item.Id.ToString()
                });
            }

            ViewBag.tiposLocalDePescaViewModel = new SelectList(itens, "Value", "Text");

            return View();
        }

        [HttpPost]
        public ActionResult Novo(LocalDePescaViewModel localDePescaViewModel)
        {
            LocalDePesca localDePesca;
            Localizacao localizacao;
            UsuarioViewModel usuarioViewModel;
            Usuario usuario;
            TipoLocalDePesca tipoLocalDePesca;

            if (ModelState.IsValid)
            {
                try
                {
                    if (Request.Cookies["GuiaDaPescaUsuario"] != null)
                    {
                        usuarioViewModel = Newtonsoft.Json.JsonConvert.DeserializeObject<UsuarioViewModel>(Request.Cookies["GuiaDaPescaUsuario"].Value);
                        usuario = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);

                        localizacao = new Localizacao(localDePescaViewModel.Localizacao.Latitude, localDePescaViewModel.Localizacao.Longitude);
                        new LocalizacaoRepository().AdicionarPadrao(localizacao);

                        tipoLocalDePesca = new TipoLocalDePescaRepository().Obter(localDePescaViewModel.TipoLocalDePesca.Id);

                        localDePesca = new LocalDePesca(localDePescaViewModel.Nome, localizacao, usuario, tipoLocalDePesca);
                        new LocalDePescaRepository().AdicionarPadrao(localDePesca);
                    }
                    else
                    {
                        throw new ArgumentException("O usuario deve estar logado");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return RedirectToAction("Novo");
        }

        #region Methods

        private void ModelToViewModel(List<TipoLocalDePesca> tiposLocalDePesca, List<TipoLocalDePescaViewModel> tiposLocalDePescaViewModel)
        {
            tiposLocalDePesca.ForEach(x =>
                tiposLocalDePescaViewModel.Add(new TipoLocalDePescaViewModel()
                {
                    Id = x.Id,
                    Comentario = new ComentarioViewModel()
                    {
                        Id = x.Comentario.Id,
                        Usuario = new UsuarioViewModel()
                        {
                            Id = x.Comentario.Usuario.Id,
                            Email = x.Comentario.Usuario.Email,
                            Senha = x.Comentario.Usuario.Senha
                        },
                        DataCriacao = x.Comentario.DataCriacao,
                        Descricao = x.Comentario.Descricao
                    }
                })
            );
        }

        #endregion
    }
}