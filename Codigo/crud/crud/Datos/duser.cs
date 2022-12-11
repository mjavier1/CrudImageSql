using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using crud.Logica;
using System.Windows.Forms;
using System.Data;

namespace crud.Datos
{
    class duser
    {
        private SqlCommand cmd = new SqlCommand();
        private int idusuario;
        public bool insertar(lusers dt)
        {
            try
            {

                connetar.abrir();
                cmd = new SqlCommand("insertar_user", connetar.conx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@users", dt.Users);
                cmd.Parameters.AddWithValue("@pass", dt.Pass);
                cmd.Parameters.AddWithValue("@icono", dt.Icono);
                cmd.Parameters.AddWithValue("@estado", dt.Estado);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connetar.cerrar();
            }
        }
        public DataTable mostar_usarios()
        {
            try
            {
                connetar.abrir();
                cmd = new SqlCommand("mostar_usarios", connetar.conx);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;

                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {

                connetar.cerrar();

            }









        }
        public bool editar(lusers dt)
        {
            try
            {
                connetar.abrir();
                cmd = new SqlCommand("editar_usuarios", connetar.conx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", dt.Idusuario);
                cmd.Parameters.AddWithValue("@users", dt.Users);
                cmd.Parameters.AddWithValue("@pass", dt.Pass);
                cmd.Parameters.AddWithValue("@icono", dt.Icono);
                cmd.Parameters.AddWithValue("@estado", dt.Estado);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connetar.cerrar();
            }
        }

        public bool elminar(lusers dt)
        {
            try
            {
                connetar.abrir();
                cmd = new SqlCommand("eliminar_user", connetar.conx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", dt.Idusuario);


                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connetar.cerrar();
            }
        }


        public DataTable buscar(string parametros)
        {
            try
            {
                connetar.abrir();
                cmd = new SqlCommand("buscar_usuario", connetar.conx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@buscando", parametros);


                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;

                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {

                connetar.cerrar();

            }











        }
    }
}
