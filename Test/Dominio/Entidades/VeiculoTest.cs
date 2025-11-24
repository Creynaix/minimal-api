using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetVeiculoPropriedades()
    {
        // Arrange
        var veiculo = new Veiculo();
        
        // Act
        veiculo.Id = 1;
        veiculo.Nome = "Classic";
        veiculo.Marca = "Chevrolet";
        veiculo.Ano = 2010;

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Classic", veiculo.Nome);
        Assert.AreEqual("Chevrolet", veiculo.Marca);
        Assert.AreEqual(2010, veiculo.Ano);
    }
}
