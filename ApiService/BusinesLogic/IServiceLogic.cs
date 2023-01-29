using ApiService.ModelView;

namespace ApiService.BusinesLogic
{
    public interface IServiceLogic
    {
        public string GetTriangleCategory(double side_a, double side_b, double side_c);
        public int GetFibonacci(int max);

        public string ReverseWord(string word);

        public HashModel HshMd5(string word);
    }
}
