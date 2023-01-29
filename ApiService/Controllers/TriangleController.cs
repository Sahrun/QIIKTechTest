using ApiService.BusinesLogic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TriangleController : Controller
    {
        private readonly IServiceLogic _service;
        public TriangleController(IServiceLogic service)
        {
            _service = service;
        }
        [HttpGet(Name = "GetTriangleCategory")]
        public string GetTriangleCategory(double side_a, double side_b, double side_c)
        {
            return _service.GetTriangleCategory(side_a, side_b, side_c);
        }

        [HttpGet(Name = "GetFibonacci")]
        public int GetFibonacci(int max)
        {
            return _service.GetFibonacci(max);
        }


        [HttpGet(Name = "GetReverseWord")]
        public string GetReverseWord(string word)
        {
            return _service.ReverseWord(word);
        }

        [HttpGet(Name = "GetGetMd5Word")]
        public JsonResult GetMd5(string word)
        {

            return Json(_service.HshMd5(word));
        }

    }
}
