using DotNETCoreArchitektuenWorkShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETCoreArchitektuenWorkShop.Database
{
    public class DatabaseHotel
    {
        public List<Hotel> selectAll()
        {
            try
            {

                SqlConnectionStringBuilder builder = createConnection();

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();

                    String sql = "SELECT * from hotels";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<Hotel> hotels = new List<Hotel>();

                            while (reader.Read())
                            {
                                Hotel hotel = new Hotel();

                                hotel.id = reader.GetInt64(0);
                                hotel.name = reader.GetString(1);
                                hotel.rooms_max = reader.GetInt16(2);
                                hotel.rooms_curr = reader.GetInt16(3);
                                hotels.Add(hotel);
                            }

                            return hotels;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public Hotel selectById(Int64 id)
        {
            try
            {

                SqlConnectionStringBuilder builder = createConnection();

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();

                    String sql = "SELECT * from hotels where id =" + id;

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) {
                                reader.Read();
                                Hotel hotel = new Hotel();

                                hotel.id = reader.GetInt64(0);
                                hotel.name = reader.GetString(1);
                                hotel.rooms_max = reader.GetInt16(2);
                                hotel.rooms_curr = reader.GetInt16(3);

                                return hotel;
                            }

                            return null;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public bool updateHotel(Int64 id, Int16 rooms_curr)
        {
            try
            {

                SqlConnectionStringBuilder builder = createConnection();

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand("Update dbo.hotels set rooms_curr=" + rooms_curr + " where id =" + id, connection))
                    {
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        private SqlConnectionStringBuilder createConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "LUCASK-WIN10\\SQLEXPRESS";
            builder.UserID = "wdcuser";
            builder.Password = "#Wdc2019";
            builder.InitialCatalog = "wdc2019workshop";

            return builder;
        }
    }
}
