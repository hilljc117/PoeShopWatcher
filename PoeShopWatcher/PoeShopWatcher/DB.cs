using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using PoeShopWatcher.Models;

namespace PoeShopWatcher
{
    internal static class DB
    {
        internal static string ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        internal static IEnumerable<T> Query<T>(string sql, object param = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                return conn.Query<T>(sql, param);
            }
        }

        internal static void InsertStashes(IEnumerable<Stash> stashes)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var maxId = conn.QuerySingle<string>("SELECT MAX(Id) FROM Stash");
                foreach (Stash stash in stashes)
                {
                    FullDeleteStash(stash.Id);
                }
            }
        }

        private static void FullDeleteStash(string stashId)
        {

        }
    }
}
