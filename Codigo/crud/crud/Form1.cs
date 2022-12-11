using crud.Datos;
using crud.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int idusuario;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btninst_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            button1.Visible = true;
            btnchanger.Visible = false;
            btnvolver.Visible = true;
            txtPass.Clear();
            txtPass.Clear();
            txtUser.Focus();
            panel4.Dock= DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUser.Text != "")
            {
                if (txtPass.Text != "")
                {
                    insertar_usuario();
                    mostar_usarios();
                }
                else
                {
                    MessageBox.Show("Ingrese una contrasena", "Sin contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Ingrese una contrasena", "Sin contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertar_usuario()
        {
            lusers dt = new lusers();
            duser fun = new duser();

            dt.Users = txtUser.Text;
            dt.Pass = txtPass.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            icono.Image.Save(ms, icono.Image.RawFormat);

            dt.Icono = ms.GetBuffer();
            dt.Estado = "Activo";
            if (fun.insertar(dt))
            {
                MessageBox.Show("Usuarios Registrado");
                panel4.Visible = false;
                panel4.Dock = DockStyle.None;
            }

        }
        




        private void icono_Click(object sender, EventArgs e)
        {
            open.InitialDirectory = "";
            open.Filter = "Imagenes|*jpg;*.png";
            open.FilterIndex = 2;
            open.Title = "Cargador de Imagen";
            if (open.ShowDialog() == DialogResult.OK)
            {

                icono.BackgroundImage = null;
                icono.Image = new Bitmap(open.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostar_usarios();
        }
        private void mostar_usarios()
        {
            DataTable dt;
            duser fun = new duser ();
            dt = fun.mostar_usarios();
            dsdata.DataSource= dt;

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel4.Dock = DockStyle.None;
        }

        private void dsdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idusuario = Convert.ToInt32(dsdata.SelectedCells[2].Value.ToString());
            if (e.ColumnIndex == this.dsdata.Columns["drop"].Index)
            {

                DialogResult result;
                result = MessageBox.Show("Realmente desea eliminar este registro","Elimnar", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    elminar();
                    mostar_usarios();
                }
            }






                if (e.ColumnIndex == this.dsdata.Columns["Editar"].Index)
            {
            
                txtUser.Text = this.dsdata.SelectedCells[3].Value.ToString();   
                txtPass.Text = this.dsdata.SelectedCells[4].Value.ToString();
               icono.BackgroundImage = null;
                byte[] b = (Byte[])dsdata.SelectedCells[5].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(b);
                icono.Image = Image.FromStream(ms);
                panel4.Visible=true
                    ; panel4.Dock = DockStyle.Fill;
                button1.Visible = false;
                btnchanger.Visible = true;



            }
        }

        private void btnchanger_Click(object sender, EventArgs e)
        {
            ed_usuario();
            mostar_usarios();
        }
        private void ed_usuario()
        {
            lusers dt = new lusers();
            duser fun = new duser();
            dt.Idusuario = idusuario;
            dt.Users = txtUser.Text;
            dt.Pass = txtPass.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            icono.Image.Save(ms, icono.Image.RawFormat);

            dt.Icono = ms.GetBuffer();
            dt.Estado = "Activo";
            if (fun.editar(dt))
            {
                MessageBox.Show("Usuarios Registrado");
                panel4.Visible = false;
                panel4.Dock = DockStyle.None;
            }

        }
        private void elminar()
        {
            lusers dt = new lusers();
            duser fun = new duser();
            dt.Idusuario = idusuario;
           
            

            
            if (fun.elminar(dt))
            {
                MessageBox.Show("Usuarios Eliminados");
                panel4.Visible = false;
                panel4.Dock = DockStyle.None;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscar_usuario();
        }
        private void buscar_usuario()
        {
            DataTable dt;
            duser fun = new duser();
            dt = fun.buscar(textBox1.Text);
            dsdata.DataSource= dt;
        }
    }
}




    