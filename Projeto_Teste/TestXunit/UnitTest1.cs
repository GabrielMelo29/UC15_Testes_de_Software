using Projeto_Teste;

namespace TestXunit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - Acao
            var Resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificacao
            Assert.Equal(rNum, Resultado);
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, 2, 3)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act 2
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert 2
            Assert.Equal(rNum, resultado);
        }

    }
}