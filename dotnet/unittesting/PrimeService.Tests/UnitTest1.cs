using System;
using Xunit;
using PrimeService;
namespace PrimeService.Tests
{
    public class PrimeServiceUnitTest
    {
        PrimeService _primeService;
        public PrimeServiceUnitTest(){
            _primeService = new PrimeService();
        }
        [Fact]
        public void ShouldReturnFalse_OnInput1()
        {
            var result = _primeService.IsPrime(1);
            Assert.False(result,"1 is not a Prime number.");
        }
    }
}
