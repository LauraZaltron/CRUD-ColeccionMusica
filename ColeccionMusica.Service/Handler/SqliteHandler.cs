using System.Data;
using System.Data.SQLite;

namespace ColeccionMusica.Services.Handlers
{
    public class SqliteHandler
    {   //var q almacenara la cadena de conexion
        public static string ConnStr = string.Empty;

        //metodo q recibira un query y retornara un datatable
        public static DataTable GetDataTable(string query) {
            DataTable dt = new DataTable();
            SQLiteConnection conn = new SQLiteConnection(ConnStr); //conexion a la base de datos 
            conn.Open();
            SQLiteCommand command = new SQLiteCommand(conn); //creamos comando
            command.CommandText = query; //command equivale al query q pusimos de parametro al principio

            //ejecutar el query
            SQLiteDataReader reader = command.ExecuteReader();
            dt.Load(reader);//llenamos el dt con la info del reader
            reader.Close();
            conn.Close();
            return dt;
        }

        //retorna un unico valor siempre y cuando exista en la base de datos
        public static string GetScalar(string query) {

            //configurar conexion inicio
            string scalarResult = string.Empty;
            SQLiteConnection cnn = new SQLiteConnection(ConnStr);
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = query;

            //configurar conexion final
            object result = mycommand.ExecuteScalar();
            if (result != null)
            {
                scalarResult = result.ToString();
            }
            cnn.Close();
            return scalarResult;
        }


        public static bool ExecQuery(string query) 
        {
            bool response = false;
            SQLiteConnection conn = new SQLiteConnection(ConnStr); //conexion a la base de datos
            SQLiteCommand command = new SQLiteCommand(query,conn);
            conn.Open();

            try
            {
                command.ExecuteNonQuery(); // se ejecuta el query sin esperar ningun resultado
                response = true;
            }
            catch (System.Exception)
            {
                response = false;
            }

            conn.Close();
            return response;
        }


    }
}
