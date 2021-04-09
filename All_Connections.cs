using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;


namespace MVC_Pratice
{
    public class All_Connections
    {

        SqlConnection con = null;
         public   SqlConnection init_connection_1 ()
        {

            String conString = "server=192.168.23.226;user id=sa;password=sandbox@gitam@cats;database=Gitam";

            try
            {
                con = new SqlConnection(conString);
            }
            catch(SqlException ex)
            {
                Console.Write(ex.Message);
            }

            return con;
        }
    }
}