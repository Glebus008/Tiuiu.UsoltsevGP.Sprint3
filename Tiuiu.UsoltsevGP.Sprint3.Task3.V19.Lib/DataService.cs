using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tiuiu.UsoltsevGP.Sprint3.Task3.V19.Lib
{
    public class DataService : ISprint3Task3V19
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            foreach (char r in value)
            {
                if (r == replaceable)
                {
                    value = value.Replace(replaceable, replacement);
                }
            }
            return value;
        }
    }
}
