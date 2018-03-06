using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLibrary;

namespace WcfSoapEnableEksternDLLAndCI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        Bil bil1 = new Bil("AB123456", DateTime.Now, true, 100000);

        public int bilPris()
        {

        }

        public int mcpris()
        {
            throw new NotImplementedException();
        }
    }
}
