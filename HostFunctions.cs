using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestHost
{

        [ServiceContract]
        public class HostFunctions
        {
            [OperationContract]
            public string getDate()
            {
                return DateTime.Today.DayOfWeek.ToString();
            }

            [OperationContract]
            public string getTim()
            {
                return DateTime.Now.ToString();
            }
        }
    
}
