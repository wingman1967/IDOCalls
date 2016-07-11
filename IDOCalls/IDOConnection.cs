using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Mongoose;
using Mongoose.IDO;
using Mongoose.Core.Configuration;
using Mongoose.Core.Common;
using Mongoose.IDO.Protocol;
using Mongoose.Core.DataAccess;
using Mongoose.Core.Extensions;

namespace IDOCalls
{
    public class IDOConnection
    {
        public string sessionToken;
        public IDOWebServiceReference.DOWebServiceSoapClient webService;
        public IDOConnection()
        {
            webService = new IDOWebServiceReference.DOWebServiceSoapClient("IDOWebServiceSoap");
            sessionToken = getToken();
        }

        public string getToken()
        {
            IDOWebServiceReference.DOWebServiceSoapClient webService = new IDOWebServiceReference.DOWebServiceSoapClient("IDOWebServiceSoap");
            return webService.CreateSessionToken("idotest", "dnetpvcomm", "01 DEV GR Mansfield");
        }

        public System.Data.DataSet getIdoDataset(string idoName, string propertyList, string filter = "123")
        {
            System.Data.DataSet IdoDataSet = webService.LoadDataSet(
                sessionToken,
                "SL.SLCoitems",
                "Item, Description",
                "co_num = " + (char)39 + filter + (char)39 + " and co_line = " + (char)39 + filter + (char)39,
                "", "", 
                -1
                );
            Debug.WriteLine(IdoDataSet);
            return IdoDataSet;
        }
    }
}
