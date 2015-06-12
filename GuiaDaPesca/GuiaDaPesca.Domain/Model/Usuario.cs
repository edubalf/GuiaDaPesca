using GuiaDePesca.Resourse.Validation;
using System;

namespace GuiaDaPesca.Domain.Model
{
    public class Usuario
    {
        #region Propriets

        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        #endregion

        #region Constructor

        protected Usuario() { }

        public Usuario(string login, string senha, string senhaConfirmacao)
        {
            ValidarLogin(login);
            ValidarSenha(senha, senhaConfirmacao);

            Id = Guid.NewGuid();
            Email = login;
            Senha = senha;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Altara a senha do usuario
        /// </summary>
        public void AlterarSenha(string senhaAntiga, string senhaNova, string senhaNovaConfirmacao)
        {
            ValidarAlteracaoSenha(senhaAntiga, senhaNova, senhaNovaConfirmacao);

            Senha = senhaNova;
        }

        #endregion

        #region Privete Methods

        private void ValidarLogin(string login)
        {
            Assertion.NotEmpty(login, "O login é obrigatório.");
            Assertion.Length(login, 6, 20, "O login deve ter de 5 à 20 caracteres.");
        }

        private void ValidarSenha(string senha, string senhaConfirmacao)
        {
            Assertion.NotEmpty(senha, "A senha é obrigatória.");
            Assertion.NotEmpty(senha, "A confirmação da senha é obrigatória.");
            Assertion.Length(senha, 6, 20, "A senha deve ter de 5 à 20 caracteres.");
            Assertion.Equals(senha, senhaConfirmacao, "A senha e a confirmação de senha devem ser iguais.");
        }

        private void ValidarAlteracaoSenha(string senhaAntiga, string senhaNova, string senhaNovaConfirmacao)
        {
            Assertion.Equals(senhaAntiga, Senha, "A senha antiga deve ser igual a senha atual.");
            ValidarSenha(senhaNova, senhaNovaConfirmacao);
        }

        #endregion
    }
}
