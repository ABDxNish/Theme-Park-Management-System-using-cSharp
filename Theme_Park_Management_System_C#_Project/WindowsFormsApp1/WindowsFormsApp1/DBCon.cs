using System;

namespace WindowsFormsApp1
{
    public sealed class DBCon
    {
        private static readonly Lazy<DBCon> instance = new Lazy<DBCon>(() => new DBCon());

        private readonly string connectionString;



        private DBCon()
        {
            connectionString = "Data Source=LAPTOP-TC7UTBCV\\SQLEXPRESS;Initial Catalog=ProjectDatabase;User ID=sa;Password=KHNISHAT172";
        }



        public static DBCon Instance => instance.Value;

        public string ConnectionString => connectionString;
    }
}
