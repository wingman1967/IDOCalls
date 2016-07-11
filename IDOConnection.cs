using System;
using Mongoose;
using Mongoose.IDO;
using Mongoose.Core.Configuration;
using Mongoose.Core.Common;
using Mongoose.IDO.Protocol;
using Mongoose.Core.DataAccess;
using Mongoose.Core.Extensions;

public class IDOConnection
{
    public string sessionToken;
	public IDOConnection()
	{
        sessionToken = sessionToken ?? get_token();
	}

    public string get_token()
    {
        IDOWebServiceReference.DOWebServiceSoapClient webService = new IDOWebServiceReference.DOWebServiceSoapClient("IDOWebServiceSoap");
        return webService.CreateSessionToken("idotest", "dnetpvcomm", "01 DEV GR Mansfield");
        
    }
}
