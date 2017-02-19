using HC.Tomek.Ex6.Forms.Data.Abstract;
using HC.Tomek.Ex6.Forms.Data.Abstract.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HC.Tomek.Ex6.Forms.Data.Sql
{
    public class ComputerRepository : IComputerRepository
    {
        public List<Computer> GetComputers()
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "Data Source=dev.opsys.headchannel.co.uk,49457;" + "Initial Catalog=it_store_test;" + "User id=sa;" + "Password=kawacreY8CeD;";
            sql.Open();
            SqlCommand command = new SqlCommand("select * from Computer;", sql);
            SqlDataReader datareader = command.ExecuteReader();
            List<Computer> lista = new List<Computer>();
            while (datareader.Read())
            {
                Computer computer = new Computer();
                computer.Id = (int)datareader["Id"];
                computer.Name = datareader["Name"].ToString();
                computer.Processor = datareader["Processor"].ToString();
                computer.Ram = (int)datareader["Ram"];
                lista.Add(computer);
            }
            sql.Close();
            return lista;
        }
    }
}

//SqlConnection conn = new SqlConnection();
//conn.ConnectionString =
//"Data Source=ServerName;" +
//"Initial Catalog=DataBaseName;" +
//"User id=UserName;" +
//"Password=Secret;";
//conn.Open();