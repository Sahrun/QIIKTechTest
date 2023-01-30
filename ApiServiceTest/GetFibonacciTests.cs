using ApiService.BusinesLogic;
using ApiService.ModelView;
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
            FibonancciModel actual = _service.GetFibonacci(max);

            FibonancciModel expected = new FibonancciModel
            {
                NumberList = "0,1,1",
                Toal = 1

            };

            Assert.Equal(new { expected.NumberList, expected.Toal }, new { actual.NumberList, actual.Toal });

        }

        [Theory]
        [InlineData(10)]
        public void GetFibonacci_Input_10_Should_Return_34(int max)
        {
            FibonancciModel actual = _service.GetFibonacci(max);

            FibonancciModel expected = new FibonancciModel
            {
                NumberList = "0,1,1,2,3,5,8,13,21,34",
                Toal = 34

            };

            Assert.Equal(new { expected.NumberList, expected.Toal }, new { actual.NumberList, actual.Toal });

        }
    }
}