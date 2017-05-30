using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows;


namespace DataBase_11_Lab
{
    class DB
    {
        static string connStr = @"Data Source=EUGENEPC;Initial Catalog=myShop;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connStr);

        string queryDeleteAll = "Delete  from Gods";
        string querySelect = "Select * from Gods";
        string queryUpdate = string.Format("Update Gods SET price = '{0}' WHERE price = '{1}'", 10, 3);
        string queryDelete = string.Format("DELETE FROM Gods WHERE ammount = '{0}'", 0);
        string queryInsert = string.Format("Insert Into Gods" + "(name, price, ammount, photo) Values(@nm, @pr,@am,@ph)");


        public void openConnection()
        {
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

        public void insertQuery(Shop obj, Byte[] a)
        {
            openConnection();


            SqlCommand cmd = new SqlCommand(queryInsert, conn);
            cmd.Parameters.AddWithValue("@nm", obj.name);
            cmd.Parameters.AddWithValue("@pr", obj.price);
            cmd.Parameters.AddWithValue("@am", obj.ammount);
            cmd.Parameters.AddWithValue("@ph", a);

                cmd.ExecuteNonQuery();

            closeConnection();


        }

        public void selectQuery()
        {
            openConnection();

            SqlCommand cmd = new SqlCommand(querySelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                var a = dr[3];

                MemoryStream mStream = new MemoryStream((Byte[])a);
                var geti = new BitmapImage();
                geti.BeginInit();
                geti.StreamSource = mStream;
                geti.EndInit();

                Shop obj = new Shop(dr[0].ToString(),Convert.ToInt32(dr[1]), Convert.ToInt32(dr[2]),geti);

                Shop.myShop.Add(obj);
            }

            closeConnection();

        }

        public void deleteQuery()
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(queryDelete, conn);
            cmd.ExecuteNonQuery();
            closeConnection();
        }


        public void updateQuery()
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(queryUpdate, conn);
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public void deleteAllQuery()
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(queryDeleteAll, conn);
            cmd.ExecuteNonQuery();
            closeConnection();
        }

    }
}
