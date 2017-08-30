using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MVC_ABM.ViewModel;
using System.Data;

namespace MVC_ABM.Models
{
    public class GestorCliente
    {
        public int Post(ClienteViewModel c)
        {
            SqlConnection conection = null;
            SqlTransaction trans = null;
            int rowCount = 0;
            try
            {
                conection = ManagerViewModel.OpenConection();
                trans = conection.BeginTransaction();
                string sql = "INSERT INTO CLIENTE (NOMBRE,APELLIDO,SALDOINICIAL) VALUES(@NOMBRE,@APELLIDO,@SALDOINICIAL)";
                SqlCommand command = new SqlCommand(sql, conection, trans);
               
                command.Parameters.AddWithValue("@NOMBRE", c.Nombre);
                command.Parameters.AddWithValue("@APELLIDO", c.Apellido);
                command.Parameters.AddWithValue("@SALDOINICIAL", c.SaldoInicial);
              

                rowCount = command.ExecuteNonQuery();
                trans.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message " + e.Message + "\n" + e.StackTrace);
                if (trans != null)
                {
                    trans.Rollback();
                }
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return rowCount;
        }

        public List<ClienteViewModel> Buscador(string term)
        {
            SqlConnection conection = null;

            SqlDataReader dr = null;
            DataTable datosPersonales = new DataTable();
            ClienteViewModel cliente = new ClienteViewModel();
            List<ClienteViewModel> listaCliente = new List<ClienteViewModel>();

            try
            {
                conection = ManagerViewModel.OpenConection();
                string sqlGet = "SELECT * FROM CLIENTE WHERE NOMBRE like @buscar";
                SqlCommand commandConsulta = new SqlCommand(sqlGet, conection);
                commandConsulta.Parameters.AddWithValue("@buscar", "%" + term + "%");
                dr = commandConsulta.ExecuteReader();

                datosPersonales.Load(dr);
                // dr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message " + e.Message + "\n" + e.StackTrace);

            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (conection != null)
                {
                    conection.Close();
                }
            }

            foreach (DataRow row in datosPersonales.Rows)
            {
                ClienteViewModel clienteModel = new ClienteViewModel();
                clienteModel.Id = (int)row["ID"];
                clienteModel.Nombre = (string)row["NOMBRE"];
                clienteModel.Apellido = (string)row["APELLIDO"];
                clienteModel.SaldoInicial = (int)row["SALDOINICIAL"];

                listaCliente.Add(clienteModel);

            }

            return listaCliente;
        }


        public ClienteViewModel Get(int id)
        {
            SqlConnection conection = null;

            SqlDataReader dr = null;
            DataTable datosPersonales = new DataTable();
            ClienteViewModel cliente = new ClienteViewModel();

            try
            {
                conection = ManagerViewModel.OpenConection();
                string sqlGet = "SELECT * FROM CLIENTE WHERE ID = " + id;
                SqlCommand commandConsulta = new SqlCommand(sqlGet, conection);
                dr = commandConsulta.ExecuteReader();

                datosPersonales.Load(dr);
                // dr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message " + e.Message + "\n" + e.StackTrace);

            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (conection != null)
                {
                    conection.Close();
                }
            }

            foreach (DataRow row in datosPersonales.Rows)
            {
                cliente.Id = (int)row["ID"];
                cliente.Nombre = (string)row["NOMBRE"];
                cliente.Apellido = (string)row["APELLIDO"];
                cliente.SaldoInicial = (int)row["SALDOINICIAL"];
              

            }

            return cliente;
        }

        public List<ClienteViewModel> Get()
        {
            SqlConnection conection = null;
            SqlTransaction trans = null;
            SqlDataReader dr = null;
            DataTable datosPersonales = new DataTable();
            List<ClienteViewModel> listaCliente = new List<ClienteViewModel>();

            try
            {
                conection = ManagerViewModel.OpenConection();
                trans = conection.BeginTransaction();

                string sqlGet = "SELECT * FROM CLIENTE";
                SqlCommand commandConsulta = new SqlCommand(sqlGet, conection, trans);
                dr = commandConsulta.ExecuteReader();

                datosPersonales.Load(dr);
                // dr.Close();
                trans.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message " + e.Message + "\n" + e.StackTrace);
                if (trans != null)
                {
                    trans.Rollback();
                }
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (conection != null)
                {
                    conection.Close();
                }
            }

            foreach (DataRow row in datosPersonales.Rows)
            {
                ClienteViewModel cliente = new ClienteViewModel();
                cliente.Id = (int)row["ID"];
                cliente.Nombre = (string)row["NOMBRE"];
                cliente.Apellido = (string)row["APELLIDO"];
                cliente.SaldoInicial = (int)row["SALDOINICIAL"];
              
                listaCliente.Add(cliente);
            }

            return listaCliente;
        }

    }

}