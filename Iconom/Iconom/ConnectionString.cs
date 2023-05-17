using System.Data.Common;

namespace Iconom
{
    public class ConnectionString
    {
        //change the DB connection before use
        public const string DbConnection =
            @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30";
    }
}