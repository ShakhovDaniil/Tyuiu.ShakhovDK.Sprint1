using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.ShakhovDK.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            for (int i = 0; i < 2; i++)
            {
                k /= 10;
            }

            return k % 10;
        }
    }
}
