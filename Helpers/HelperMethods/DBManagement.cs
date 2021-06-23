using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.Helpers.HelperMethods
{
    public static class DBManagement
    {
        private static readonly string StringConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        private static readonly SqlConnection Conn = new SqlConnection(StringConnection);

        public static void SaveMessage(Message message)
        {
            var completeMessage = TextBuilder.MessageBuilder(message);
            var sqlCommand = new SqlCommand($"INSERT INTO Logs(MessageContent) VALUES('{completeMessage}')", Conn);

            try
            {
                Conn.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
