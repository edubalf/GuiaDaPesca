using GuiaDePesca.Resourse.Validation;
using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Domain.Model
{
    public class Usuario
    {
        #region Propriets

        public virtual Guid Id { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Senha { get; protected set; }

        #endregion

        #region Constructor

        protected Usuario() { }

        public Usuario(string email, string senha, string senhaConfirmacao)
        {
            ValidarEmail(email);
            ValidarSenha(senha, senhaConfirmacao);

            Id = Guid.NewGuid();
            Email = email;
            Senha = senha;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Altara a senha do usuario
        /// </summary>
        public virtual void AlterarSenha(string senhaAntiga, string senhaNova, string senhaNovaConfirmacao)
        {
            ValidarAlteracaoSenha(senhaAntiga, senhaNova, senhaNovaConfirmacao);

            Senha = senhaNova;
        }

        #endregion

        #region Privete Methods

        public static void ValidarEmail(string email)
        {
            Assertion.NotEmpty(email, "O email é obrigatório.");
            Assertion.Length(email, 5, 100 , "O login deve ter de 5 à 100 caracteres.");
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
