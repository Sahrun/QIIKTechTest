using ApiService.BusinesLogic;
using ApiService.ModelView;
using Xunit;

namespace ApiServiceTest
{
    public class GetGetMd5WordTests
    {
        private readonly IServiceLogic _service;
        public GetGetMd5WordTests()
        {
            _service = new ServiceLogic();
        }
        [Theory]
        [InlineData("Word")]
        public void GetMd5Word_Input_Word_Should_Return_07a094a210794e74a0e5e1a1457a92ee(string word)
        {
            HashModel result = _service.HshMd5(word);

            HashModel expected = new HashModel
            {
                Value = "07a094a210794e74a0e5e1a1457a92ee",
                Algorithm = "MD5"

            };

            Assert.Equal(new { expected.Value, expected.Algorithm }, new { result.Value, result.Algorithm });

        }

        [Theory]
        [InlineData("Happy")]
        public void GetMd5Word_Input_Happy_Should_Return_ef97b40b2245d3690c745cd6e8c663db(string word)
        {
            HashModel result = _service.HshMd5(word);

            HashModel expected = new HashModel
            {
                Value = "ef97b40b2245d3690c745cd6e8c663db",
                Algorithm = "MD5"

            };

            Assert.Equal(new { expected.Value, expected.Algorithm }, new { result.Value, result.Algorithm });

        }


    }
}