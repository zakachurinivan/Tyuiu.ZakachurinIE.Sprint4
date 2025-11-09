using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZakachurinIE.Sprint4.Task6.V26.Lib
{
    public class DataService : ISprint4Task6V26

    {
        public string[] Calculate(string[] array)
        {
            string[] result = array.Where(item => item.Length > 5).ToArray();
            return result;
        }
    }
}
