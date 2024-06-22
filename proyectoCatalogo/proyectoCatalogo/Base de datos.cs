using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCatalogo
{
    
}


public class Database
{
    private MySqlConnection connection;

    public Database()
    {
        string connectionString = "SERVER=localhost;DATABASE=catalogoplaylist;UID=root;PASSWORD=root;";
        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }
}
