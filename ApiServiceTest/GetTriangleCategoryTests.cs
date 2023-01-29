using ApiService.BusinesLogic;
using Xunit;

namespace ApiServiceTest
{
    public class GetTriangleCategoryTests
    {
        private readonly IServiceLogic _service;
        public GetTriangleCategoryTests()
        {
            _service =new ServiceLogic();
        }
        [Theory]
        [InlineData(10, 10, 10)]
        public void GetTriangleCategory_Should_Return_EquilateralTriangle(double side_a, double side_b, double side_c)
        {
            string result = _service.GetTriangleCategory(side_a, side_b, side_c);

            Assert.Equal("Equilateral triangle",result);

        }
        [Theory]
        [InlineData(10, 3, 3)]
        public void GetTriangleCategory_Should_Return_IsoscelesTriangle(double side_a, double side_b, double side_c)
        {
            string result = _service.GetTriangleCategory(side_a, side_b, side_c);

            Assert.Equal("Isosceles triangle", result);

        }
        [Theory]
        [InlineData(4, 3, 5)]
        public void GetTriangleCategory_Should_Return_RightTriangle(double side_a, double side_b, double side_c)
        {
            string result = _service.GetTriangleCategory(side_a, side_b, side_c);

            Assert.Equal("Right triangle", result);

        }
        [Theory]
        [InlineData(10, 20, 30)]
        public void GetTriangleCategory_Should_Return_AnyTriangle(double side_a, double side_b, double side_c)
        {
            string result = _service.GetTriangleCategory(side_a, side_b, side_c);

            Assert.Equal("Any triangle", result);

        }
    }
}