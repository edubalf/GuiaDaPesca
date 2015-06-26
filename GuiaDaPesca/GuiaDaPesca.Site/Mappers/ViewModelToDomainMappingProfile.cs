using AutoMapper;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Site.ViewModels;

namespace GuiaDaPesca.Site.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ComentarioViewModel, Comentario>();
            Mapper.CreateMap<LocalDePescaViewModel, LocalDePesca>();
            Mapper.CreateMap<LocalizacaoViewModel, Localizacao>();
            Mapper.CreateMap<PeixeViewModel, Peixe>();
            Mapper.CreateMap<TipoLocalDePescaViewModel, TipoLocalDePesca>();
            Mapper.CreateMap<UsuarioViewModel, Usuario>()
                .ConstructUsing(s => new Usuario(s.Email, s.Senha, s.Senha));
        }
    }
}