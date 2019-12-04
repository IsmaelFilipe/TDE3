using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;
using TDEServico.Validadores;

namespace APITeste
{
    [TestClass]
    public class CampanhasTest
    {
        [TestMethod]
        public void TestPremiacao()
        {
            CampanhasValidador CampanhasValidador = new CampanhasValidador();
            Campanha c = new Campanha();
            c.CodCampanha = 1;
            c.CodFuncionario = 1;
            c.Nome = "Joao";
            c.Tema = "Teste";
            c.DataInicio = DateTime.Now.AddDays(30);
            c.Premio = 1000;
            c.Descricao = "Teste";
            c.DataFim = DateTime.Now.AddYears(2);

            var resultado = CampanhasValidador.Validate(c);
            Assert.AreEqual(resultado.IsValid, false);
        }
    }
}
