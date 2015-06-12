using AutoMapper;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Site.ViewModels;

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
            Mapper.CreateMap<PeixeCapturado, PeixeCapturadoViewModel>();
            Mapper.CreateMap<Peixe, PeixeViewModel>();
            Mapper.CreateMap<RelatoDePesca, RelatoDePescaViewModel>();
            Mapper.CreateMap<TipoLocalDePesca, TipoLocalDePescaViewModel>();
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}