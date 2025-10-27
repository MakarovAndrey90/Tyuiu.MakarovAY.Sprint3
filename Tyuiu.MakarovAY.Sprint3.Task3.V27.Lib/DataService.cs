using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MakarovAY.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach(char c in value) 
            {
                if (Char.IsDigit(c)) 
                {
                    res += c;
                }
            }
            int num = Int32.Parse(res);
            return num;
        }
    }
}
