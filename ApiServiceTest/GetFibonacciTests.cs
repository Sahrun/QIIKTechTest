using ApiService.BusinesLogic;
using Xunit;

namespace ApiServiceTest
{
    public class GetFibonacciTests
    {
        private readonly IServiceLogic _service;
        public GetFibonacciTests()
        {
            _service = new ServiceLogic();
        }
        [Theory]
        [InlineData(3)]
        public void GetFibonacci_Input_3_Should_Return_1(int max)
        {
            int result = _service.GetFibonacci(max);

            Assert.Equal(1, result);

        }

        [Theory]
        [InlineData(10)]
        public void GetFibonacci_Input_10_Should_Return_34(int max)
        {
            int result = _service.GetFibonacci(max);

            Assert.Equal(34, result);

        }
    }
}