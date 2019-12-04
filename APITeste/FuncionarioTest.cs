using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;
using TDEServico.Validadores;

namespace APITeste
{
    [TestClass]
    public class FuncionarioTest
    {
        [TestMethod]
        public void TesteIdade()
        {
            FuncionarioValidador FuncionarioValidador = new FuncionarioValidador();
            Funcionario f = new Funcionario();
            f.CodFuncionario = 1;
            f.CodUsuario = 1;
            f.CPF = "123";
            f.DataNascimento = DateTime.Now;
            f.Nome = "teste";

            var resultado = FuncionarioValidador.Validate(f);
            Assert.AreEqual(resultado.IsValid, false);

        }

        [TestMethod]
        public void TesteCpfValido()
        {
            FuncionarioValidador FuncionarioValidador = new FuncionarioValidador();
            Funcionario f = new Funcionario();
            f.CodFuncionario = 1;
            f.CodUsuario = 1;
            f.CPF = "12524383628";
            f.DataNascimento = DateTime.Now;
            f.Nome = "teste";

            var resultado = FuncionarioValidador.Validate(f);
            Assert.AreEqual(resultado.IsValid, true);

        }

        [TestMethod]
        public void TesteCpfInValido()
        {
            FuncionarioValidador FuncionarioValidador = new FuncionarioValidador();
            Funcionario f = new Funcionario();
            f.CodFuncionario = 1;
            f.CodUsuario = 1;
            f.CPF = "12524383627";
            f.DataNascimento = DateTime.Now;
            f.Nome = "teste";

            var resultado = FuncionarioValidador.Validate(f);
            Assert.AreEqual(resultado.IsValid, false);

        }
    }
}
