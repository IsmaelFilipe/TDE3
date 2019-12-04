using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;
using TDEServico.Validadores;

namespace APITeste
{
    [TestClass]
    public class SugestaoTest
    {
        [TestMethod]
        public void CustoValidacao()
        {
            SugestoesValidador SugestoesValidador = new SugestoesValidador();
            Sugestoes s = new Sugestoes();
            s.CodCampanha = 1;
            s.CodFuncionario = 1;
            s.CodSugestoes = 1;
            s.Custo = 200;
            s.DataFim = DateTime.Now.AddYears(2);
            s.DataInicio = DateTime.Now.AddYears(1);
            s.ReduçãoCusto = 100;

            var resultado = SugestoesValidador.Validate(s);
            Assert.AreEqual(resultado.IsValid, false);
        }
    }
}
