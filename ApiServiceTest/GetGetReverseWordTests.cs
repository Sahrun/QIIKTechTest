using ApiService.BusinesLogic;
using Xunit;

namespace ApiServiceTest
{
    public class GetReverseWordTests
    {
        private readonly IServiceLogic _service;
        public GetReverseWordTests()
        {
            _service = new ServiceLogic();
        }
        [Theory]
        [InlineData("Yogi")]
        public void GetReverseWord_Input_Yogi_Should_Return_igoY(string word)
        {
            string result = _service.ReverseWord(word);

            Assert.Equal("igoY", result);

        }
        [Theory]
        [InlineData("Eat")]
        public void GetReverseWord_Input_Eat_Should_Return_taE(string word)
        {
            string result = _service.ReverseWord(word);

            Assert.Equal("taE", result);

        }

    }
}