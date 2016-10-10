using HukukWs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HukukWs
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHsClient
    {
        [OperationContract]
        int GetSumOfTwoInts(int Operand1, int Operand2);
        [OperationContract]
        HsResponse<string> AuthenticateUser(int userId, string password);

        [OperationContract]
        GetMattersResponse GetMatters(string dbname,int reporttype);

        [OperationContract]
        GetKullanicilarResponse GetKullanicilar(string dbname);   

        // TODO: Add your service operations here
    }
}
