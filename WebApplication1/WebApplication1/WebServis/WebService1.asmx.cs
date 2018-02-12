using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1.WebServis
{
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]

        public Sınıfdto BilgiGetir(int Id)
        {
            Sınıfdto getir = new Sınıfdto();
            string cs = ConfigurationManager.ConnectionStrings["Baglan"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = ("SELECT * FROM Sınıf WHERE Id=@Id");


                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Id";
                parameter.Value = Id;
                cmd.Parameters.Add(parameter);
                Con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    getir.Id = Convert.ToInt32(dr["Id"]);
                    getir.ad = dr["ad"].ToString();
                }
            }
            return getir;
        }




    }
}
