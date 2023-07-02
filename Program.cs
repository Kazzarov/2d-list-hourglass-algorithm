namespace _2dArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> dou = new List<List<int>>();
            dou.Add(new List<int>() { 1, 1, 1, 0, 0, 0 });
            dou.Add(new List<int>() { 0, 1, 0, 0, 0, 0 });
            dou.Add(new List<int>() { 1, 1, 1, 0, 0, 0 });
            dou.Add(new List<int>() { 0, 0, 0, 0, 0, 0 });
            dou.Add(new List<int>() { 0, 0, 0, 0, 0, 0 });
            dou.Add(new List<int>() { 0, 0, 0, 0, 0, 0 });
           
            int res = hourglass(dou);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static int hourglass(List<List<int>> dou) 
        {
            int maxVal = int.MinValue;
            int currVal = 0;
            int rows = dou.Count;
            int cols = dou[0].Count;
            for(int i = 0;i<rows-2;i++)
            {
                for(int j = 0;j<cols-2;j++)
                {
                    currVal = dou[i][j]+dou[i][j+1]+dou[i][j + 2]+
                        dou[i+1][j + 1]+ dou[i+2][j]+ dou[i+2][j + 1] + dou[i + 2][j + 2];
                    if(currVal > maxVal)
                    {
                        maxVal = currVal;
                    }
                }
            }

            return maxVal;
        }
    }
}


