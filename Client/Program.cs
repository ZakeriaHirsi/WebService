using Client.MyServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WebService;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyServiceClient _Service = new MyServiceClient();
            Console.ReadLine();
        }
    }
}
