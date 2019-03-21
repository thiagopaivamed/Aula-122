using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testes
{
    public class MetodosTestados
    {
        [Fact]
        public void Somar()
        {
            Assert.NotEqual(5, 4 + 4);
        }

        [Theory]
        [InlineData("Paralelepipedo", "Para")]
        [InlineData("Aviao", "vi")]
        [InlineData("Atualmente", "mente")]
        public void VerificaSubString(string palavra, string subpalavra)
        {
            Assert.Contains(subpalavra, palavra);
        }
    }
}
