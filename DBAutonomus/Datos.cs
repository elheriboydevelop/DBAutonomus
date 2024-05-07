using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace DBAutonomus
{
    internal class Datos
    {
        OracleConnection con;
        string cadenaConexion= "User Id=ADMIN;Password=JOSEluis1981;Data Source=jldb_high;";
        

        public bool abrirConexion()
        {
            OracleConfiguration.TnsAdmin = @"C:\Users\Jose Luis\Downloads\Wallet_JLDB";
            OracleConfiguration.WalletLocation=OracleConfiguration.TnsAdmin;
            try {
                con = new OracleConnection(cadenaConexion);
                con.Open();
                return true;
            }
            catch (Exception ex){
                return false;
            }
        }

    }
}

