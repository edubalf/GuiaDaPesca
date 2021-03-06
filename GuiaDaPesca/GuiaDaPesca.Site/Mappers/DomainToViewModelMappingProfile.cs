﻿using AutoMapper;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Site.ViewModels;
using System.Collections.Generic;

namespace GuiaDaPesca.Site.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Comentario, ComentarioViewModel>();
            Mapper.CreateMap<LocalDePesca, LocalDePescaViewModel>();
            Mapper.CreateMap<Localizacao, LocalizacaoViewModel>();
            Mapper.CreateMap<Peixe, PeixeViewModel>();
            Mapper.CreateMap<TipoLocalDePesca, TipoLocalDePescaViewModel>();
            Mapper.CreateMap<Usuario, UsuarioViewModel>();

            Mapper.CreateMap<List<TipoLocalDePesca>, List<TipoLocalDePescaViewModel>>();
        }
    }
}