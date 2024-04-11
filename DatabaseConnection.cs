using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;
using System.Web.Security;
using System.Collections;

namespace tropicasa
{
    public class DatabaseConnection
    {
         String SqlConnectString = @"Data Source=cis-mssql1.temple.edu;Initial Catalog=SP23_3342_tuk54604;User ID=tuk54604;Password=oodai3Thoo;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //String SqlConnectString = @"server=cis-mssql1.temple.edu;Database=sp23_3342_tuk54602;User id=tuk54604;Password=oodai3Thoo";

        private SqlConnection myConnectionSql;
        private SqlCommand sqlCmd;
        private SqlDataReader reader;
        private DataSet ds;

        public DatabaseConnection()
        {
            myConnectionSql = new SqlConnection(SqlConnectString);
        }

        public int spRegister(string spname, string username, string fullname, string email, string password, string phone, string address, string role, string questionone, string questiontwo, string questionthree, string isverified)
        {
            // Returns -1 when an exsception occurs.
            sqlCmd = new SqlCommand(spname, myConnectionSql);

            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@username", username);
            sqlCmd.Parameters.AddWithValue("@fullname", fullname);
            sqlCmd.Parameters.AddWithValue("@email", email);
            sqlCmd.Parameters.AddWithValue("@password", password);
            sqlCmd.Parameters.AddWithValue("@phone", phone);
            sqlCmd.Parameters.AddWithValue("@address", address);
            sqlCmd.Parameters.AddWithValue("@role", role);
            sqlCmd.Parameters.AddWithValue("@questionone", questionone);
            sqlCmd.Parameters.AddWithValue("@questiontwo", questiontwo);
            sqlCmd.Parameters.AddWithValue("@questionthree", questionthree);
            sqlCmd.Parameters.AddWithValue("@isverified", isverified);

            try
            {
                myConnectionSql.Open();
                int ret = sqlCmd.ExecuteNonQuery();
                myConnectionSql.Close();
                return ret;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int spBidAndFeedback(string spname, string buyeremail, string owneremail, string bid, string feedback, string questionone, string questiontwo, string questionthree, string questionfour, string questionfive)
        {
            // Returns -1 when an exsception occurs.
            sqlCmd = new SqlCommand(spname, myConnectionSql);

            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@buyeremail", buyeremail);
            sqlCmd.Parameters.AddWithValue("@owneremail", owneremail);
            sqlCmd.Parameters.AddWithValue("@bid", bid);
            sqlCmd.Parameters.AddWithValue("@feedback", feedback);

            sqlCmd.Parameters.AddWithValue("@questionone", questionone);
            sqlCmd.Parameters.AddWithValue("@questiontwo", questiontwo);
            sqlCmd.Parameters.AddWithValue("@questionthree", questionthree);
            sqlCmd.Parameters.AddWithValue("@questionfour", questionfour);
            sqlCmd.Parameters.AddWithValue("@questionfive", questionfive);



            try
            {
                myConnectionSql.Open();
                int ret = sqlCmd.ExecuteNonQuery();
                myConnectionSql.Close();
                return ret;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public DataTable spSelectFeedback(String spName, string email)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            sqlCmd = new SqlCommand(spName, myConnectionSql);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@email", email);

            try
            {
                myConnectionSql.Open();
                sqlDataAdapter.SelectCommand = sqlCmd;
                sqlDataAdapter.Fill(dataTable);
                myConnectionSql.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                return dataTable;
            }
        }

        public int spScheduleTour(string spname, string buyeremail, string owneremail)
        {
            // Returns -1 when an exsception occurs.
            sqlCmd = new SqlCommand(spname, myConnectionSql);

            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@buyeremail", buyeremail);
            sqlCmd.Parameters.AddWithValue("@owneremail", owneremail);

            try
            {
                myConnectionSql.Open();
                int ret = sqlCmd.ExecuteNonQuery();
                myConnectionSql.Close();
                return ret;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public DataTable spSelectTours(String spName, string email)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            sqlCmd = new SqlCommand(spName, myConnectionSql);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@email", email);

            try
            {
                myConnectionSql.Open();
                sqlDataAdapter.SelectCommand = sqlCmd;
                sqlDataAdapter.Fill(dataTable);
                myConnectionSql.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                return dataTable;
            }
        }

        public ArrayList spLogin(string spname, string email, string password)
        {
            ArrayList myList = new ArrayList();

            sqlCmd = new SqlCommand(spname, myConnectionSql);

            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@email", email);
            sqlCmd.Parameters.AddWithValue("@password", password);

            try
            {
                myConnectionSql.Open();

                reader = sqlCmd.ExecuteReader();
                bool res = reader.HasRows;

                while (reader.Read())
                {
                    // Access the values returned by the query using the column names
                    string usernameUser = reader.GetString(reader.GetOrdinal("username"));
                    string emailUser = reader.GetString(reader.GetOrdinal("email"));
                    string passwordUser = reader.GetString(reader.GetOrdinal("password"));
                    string roleUser = reader.GetString(reader.GetOrdinal("role"));

                    myList.Add(usernameUser);//0
                    myList.Add(emailUser);//1
                    myList.Add(passwordUser);//2
                    myList.Add(roleUser);//3
                }

                reader.Close();
                myConnectionSql.Close();
                return myList;
            }
            catch (Exception ex)
            {
                return myList;
            }
        }

        //Verify email

        public int spVerify(string spname, string email)
        {
            // Returns -1 when an exsception occurs.
            sqlCmd = new SqlCommand(spname, myConnectionSql);

            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@email", email);

            try
            {
                myConnectionSql.Open();
                int ret = sqlCmd.ExecuteNonQuery();
                myConnectionSql.Close();
                return ret;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}