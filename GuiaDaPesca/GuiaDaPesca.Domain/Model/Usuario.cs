using System;

namespace GuiaDaPesca.Domain.Model
{
    public class Usuario
    {
        #region Propriets

        public Guid Id { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }

        #endregion

        #region Constructor

        public Usuario(string login, string senha, string senhaConfirmacao)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Altara a senha do usuario
        /// </summary>
        public void AlterarSenha(string senhaAntiga, string senhaNova, string senhaNovaConfirmacao)
        {

        }

        #endregion
    }
}
