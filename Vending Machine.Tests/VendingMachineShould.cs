namespace Vending_Machine.Tests
{
    public class VendingMachineShould
    {
        [Fact]
        public void CheckSaldoUpdate()
        {
            //Arrange 
            VM sut = new VM();
            //vars

            //Act
            sut.UpdateSaldo(500);
            //test

            //Assert
            Assert.Equal(500, sut.saldo);
        }

        [Fact]
        public void CheckProductCreation()
        {
            //Arrange 
            VM sut = new VM();
            //vars

            //Act
            
            //test

            //Assert
            Assert.True(sut.Products.Count > 0);
        }

        [Fact]
        public void CheckCorrectMoneyDenomination()
        {
            //Arrange 
            VM sut = new VM();
            //vars

            //Act

            //test

            //Assert
            Assert.True(sut.ValidateMoneyInput(100));
        }
    }
}