using HukukWs.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HukukWs
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class HsClient : IHsClient
    {

            public int GetSumOfTwoInts(int Operand1, int Operand2)
            {
                return Operand1 + Operand2;
            }

        MysqlDbAccess _dbAccess = new MysqlDbAccess();
        public HsResponse<string> AuthenticateUser(int userId, string password)
        {
            var response = new HsResponse<string>() { Operation = "AuthenticateUser" };
            try
            {
                var result = _dbAccess.ExecuteScalar("FN_AUTHENTICATEUSER", new List<MySqlParameter> {
                new MySqlParameter("P_USERID",userId),
                new MySqlParameter("P_PASSWORD",password)});

                if (result.ToString() != password)
                {
                    response.Statu = Statu.fail;
                    response.Message = "Yanlış Kullanıcı adı veya şifre";
                    return response;
                }
                response.Statu = Statu.success;
                response.Message = "Giriş başarılı";
            }
            catch (Exception ex)
            {
                response.Statu = Statu.fail;
                response.Message = ex.Message;
            }
            return response;
        }

        public GetMattersResponse GetMatters(string dbname, int reporttype)
        {
            var response = new GetMattersResponse() { Operation = "GetMatters" };
            
            try
            {
                response.Statu = Statu.success;
                response.Message = "Giriş başarılı";
                response.Matters = _dbAccess.QueryList<Matter>("PORC_GETMATTERS", new List<MySqlParameter>());
            }
            catch (Exception ex)
            {
                response.Statu = Statu.fail;
                response.Message = ex.Message;
            }
            return response;
        }
        public GetKullanicilarResponse GetKullanicilar(string dbname)
        {
            var response = new GetKullanicilarResponse { Operation = "GetKullanicilar" };
            
            try
            {
                response.Kullanicilar = _dbAccess.QueryList<Kullanicilar>("PROC_KULLANICILAR_SELECT", new List<MySqlParameter>());
                response.Message = "";

                response.Statu = Statu.success;
            }
            catch (Exception ex)
            {
                response.Statu = Statu.fail;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
