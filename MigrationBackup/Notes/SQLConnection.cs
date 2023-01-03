using Notes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    //What does internal mean: Google: 
    //An internal modifier is used to prevent the use of a public modifier, which allows access to other assemblies wherever necessary.
    //Kann nur innerhalb des Projektes genutzt werden
    internal class SQLConnection
    {
        /// <summary>
        /// Builds connection to the SQL Server. You do not have to do it with the connection string builder. You can just use a connectionstring.
        /// </summary>
        /// <returns></returns>
        private SqlConnection connectionStringBuilder()
        {
            try
            {
                SqlConnection conn = new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = "localhost",
                    InitialCatalog = "Notes",
                    IntegratedSecurity = true

                }.ConnectionString
                );
                //When the connection opens, it should be closed after, what I did not in this case
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Could not open SQL Connection");
            }

            return null;
        }

        
        /// <summary>
        /// Inserting note
        /// </summary>
        /// <param name="note"></param>
        /// <param name="reminder"></param>
        /// <param name="user"></param>
        public void insertNote(string note, DateTime reminder, string user)
        {
            string insertNote = "INSERT INTO Notetbl (Note, Reminder,usernote) VALUES ('" + user + "','" + reminder + "','" + user + "')";
            SqlCommand commandInsert= new SqlCommand(insertNote, connectionStringBuilder());
            commandInsert.ExecuteNonQuery();
        }
        /// <summary>
        /// Get SQL Data, to show all written notes
        /// </summary>
        /// <returns></returns>
        public DataTable getData()
        {
            DataTable dt = new DataTable();

            string insertNote = "SELECT * FROM Notetbl";
            SqlDataAdapter dataAdapter= new SqlDataAdapter(insertNote,connectionStringBuilder());
            dataAdapter.Fill(dt);

            return dt;
        }


    }
}
