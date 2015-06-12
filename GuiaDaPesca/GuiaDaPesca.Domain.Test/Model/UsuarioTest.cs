using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Domain.Test.Model
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void PreenchimentoParametros()
        {
            Usuario usuario = new Usuario("edubalf", "123mudar", "123mudar");

            Assert.AreEqual(usuario.Email, "edubalf");
            Assert.AreEqual(usuario.Senha, "123mudar");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void LoginPequeno()
        {
            //Menor que 6 caracteres
            Usuario usuario = new Usuario("eduba", "123mudar", "123mudar");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void LoginGrande()
        {
            //maior que 20 caracteres
            Usuario usuario = new Usuario("abcdefghijabcdefghija", "123mudar", "123mudar");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void SenhaPequena()
        {
            //Menor que 6 caracteres
            Usuario usuario = new Usuario("edubalf", "12345", "12345");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void SenhaGrande()
        {
            //maior que 20 caracteres
            Usuario usuario = new Usuario("edubalf", "abcdefghijabcdefghija", "abcdefghijabcdefghija");
        }

        [TestMethod]
        public void AlterarSenha()
        {
            Usuario usuario = new Usuario("edubalf", "123mudar", "123mudar");

            usuario.AlterarSenha("123mudar", "1234mudar", "1234mudar");

            Assert.AreEqual("1234mudar", usuario.Senha);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void AlterarSenhaParaSenhaPequena()
        {
            //maior que 20 caracteres
            Usuario usuario = new Usuario("edubalf", "123mudar", "123mudar");

            usuario.AlterarSenha("123mudar", "12345", "12345");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void AlterarSenhaParaSenhaGrande()
        {
            //maior que 20 caracteres
            Usuario usuario = new Usuario("edubalf", "123mudar", "123mudar");

            usuario.AlterarSenha("123mudar", "abcdefghijabcdefghija", "abcdefghijabcdefghija");
        }
    }
}
