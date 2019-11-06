using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace webApiEx
{
    public class TPLEx
    {

        public async Task<int> GetSum(int x, int y)
        {
            //Task<int> t =  Task.Factory.StartNew(() =>
            //{
            //    Thread.Sleep(4000);
            //    return x + y;
            //});
            //return t;

            await Task.Delay(3000);
            return x+ y;
        }

        public async void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    var result = await GetSum(10, 20);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {

                }
            }
        }

    }
}
