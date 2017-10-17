using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace DAO
{
    public class SQLConnexion
    {
        public static void Connexion()
        {
            decimal COMM = 0;
            int MGR = 0;
            string strConnexion = "Data Source=176.31.248.137;Initial Catalog=user05;Persist Security Info=True;User ID=user05;Password=546user05";
            string strRequete = "SELECT * FROM EMP ORDER BY EMPNO";
            SqlConnection oConnection = new SqlConnection(strConnexion);
            SqlDataReader DataRead = null;
            try
            {
                
                oConnection.Open();
                Console.WriteLine("Etat de la connexion : " + oConnection.State);
                SqlCommand oCommand = new SqlCommand(strRequete, oConnection);
                

                DataRead = oCommand.ExecuteReader();
                

                while (DataRead.Read())
                {
                    if (!DBNull.Value.Equals(DataRead["COMM"]))
                        COMM = DataRead.GetDecimal(3);
                    if (!DBNull.Value.Equals(DataRead["MGR"]))
                        MGR = DataRead.GetInt32(6);
                    Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", DataRead[0], DataRead[1], DataRead[2], DataRead[3], DataRead[4], DataRead[5], DataRead[6], DataRead[7]));
                }
                
                oConnection.Close();
            }
            
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
            }
            finally
            {
                if (oConnection != null)
                {
                    DataRead.Close();
                    oConnection.Close();
                    
                }
            }
        }

        public static List<Employe> GetAllEmployes()
        {
            List<Employe> liste = new List<Employe>(); 

            decimal COMM = 0;
            int MGR = 0;
            string strConnexion = "Data Source=176.31.248.137;Initial Catalog=user05;Persist Security Info=True;User ID=user05;Password=546user05";
            string strRequete = "SELECT * FROM EMP ORDER BY EMPNO";
            SqlConnection oConnection = new SqlConnection(strConnexion);
            SqlDataReader DataRead = null;
            try
            {

                oConnection.Open();
                Console.WriteLine("Etat de la connexion : " + oConnection.State);
                SqlCommand oCommand = new SqlCommand(strRequete, oConnection);


                DataRead = oCommand.ExecuteReader();


                while (DataRead.Read())
                {
                    if (!DBNull.Value.Equals(DataRead["COMM"]))
                        COMM = DataRead.GetDecimal(3);
                    if (!DBNull.Value.Equals(DataRead["MGR"]))
                        MGR = DataRead.GetInt32(6);

                    liste.Add(new Employe(DataRead["EMPNO"].ToString(), DataRead["ENAME"].ToString(), Convert.ToDecimal(DataRead["SAL"]),COMM, MGR, Convert.ToInt32(DataRead["DEPTNO"])));
                        //Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", DataRead[0], DataRead[1], DataRead[2], DataRead[3], DataRead[4], DataRead[5], DataRead[6], DataRead[7]));
                }

                oConnection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
            }
            finally
            {
                if (oConnection != null)
                {
                    DataRead.Close();
                    oConnection.Close();
                }
               
            }
            return liste;
        }
    }
}