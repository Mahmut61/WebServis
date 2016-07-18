using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WcfWebService
{
    /// <summary>
    /// Summary description for WSFilmler
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSFilmler : System.Web.Services.WebService
    {
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection("Data Source = Pc; Initial Catalog = VideoMarket; uid = sa; pwd = 61");
        [WebMethod]
        public DataSet GetAllFilmlerByFilmTuru(string FilmTuru)
        {
            SqlDataAdapter da = new SqlDataAdapter("select FilmAd,TurAd,Yonetmen,Oyuncular,Miktar from Filmler inner join FilmTurleri on Filmler.FilmTurNo=FilmTurleri.FilmTurNo where TurAd=@TurAd", conn);
            da.SelectCommand.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            try
            {
                da.Fill(ds, "Filmler");
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }
    }
}
