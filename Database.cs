using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbPracticeConsole
{
    class Database
    {
        List<string> persons=new List<string>();
        SqlConnection connection = new SqlConnection(@"Data Source=MOUNT\SQLExpress;Initial Catalog=AdventureWorks2014;Integrated Security=SSPI");
        public Database()
        {
            try
            {
                connection.Open();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to db");
            }
        }
  
        public void dbQuery()
        {
            using (SqlCommand command = new SqlCommand("select Person.FirstName from Person.Person where BusinessEntityID<10", connection))
            {
                var reader = command.ExecuteReader();
                int x = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string data1 = reader.GetString(0);
                        persons.Add(data1);
                        Console.WriteLine(persons[x]);
                        x++;
                    }
                }
            }
        }
        public void dbClose()
        {
            connection.Close();
        }
    }
}
