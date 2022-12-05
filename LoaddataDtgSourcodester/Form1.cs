using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoaddataDtgSourcodester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            con.ConnectionString = "Data Source=DESKTOP-OPOHIL4\\AXEL;Initial Catalog=Registro;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            try
            {
                
                cmd = new SqlCommand();
                
                cmd.Connection = con;

                if (this.textBox1.Text == "")
                {
                    cmd.CommandText = "Select * FROM Estudiantes";
                }
                else
                {
                    cmd.CommandText = "Select ID, Nombre, Apellido, Correo, Sexo FROM Estudiantes where ID like @filter";
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@filter";
                    param.Value = "%"+this.textBox1.Text.Trim()+"%";
                    cmd.Parameters.Add(param);
                }

                da = new SqlDataAdapter();
                
                da.SelectCommand = cmd;
                
                dt = new DataTable();
               
                da.Fill(dt);
                
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                //Mensaje de Error 
                MessageBox.Show(ex.Message);
            }
           
            da.Dispose();

            con.Close();
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                cmd = new SqlCommand();

                cmd.Connection = con;

                if (this.textBox1.Text == "")
                {
                    cmd.CommandText = "Select * FROM Profesores";
                }
                else
                {
                    cmd.CommandText = "Select ProfesorId, Nombre, Apellidos, Correo FROM Profesores where ProfesorId like @filter";
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@filter";
                    param.Value = "%"+this.textBox1.Text.Trim()+"%";
                    cmd.Parameters.Add(param);
                }

                da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                //Mensaje de Error 
                MessageBox.Show(ex.Message);
            }

            da.Dispose();

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                cmd = new SqlCommand();

                cmd.Connection = con;

                if (this.textBox1.Text == "")
                {
                    cmd.CommandText = "Select * FROM Materia";
                }
                else
                {
                    cmd.CommandText = "Select MateriaId FROM Materia where MateriaId like @filter";
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@filter";
                    param.Value = "%"+this.textBox1.Text.Trim()+"%";
                    cmd.Parameters.Add(param);
                }


                da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                //Mensaje de Error 
                MessageBox.Show(ex.Message);
            }

            da.Dispose();

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                cmd = new SqlCommand();

                cmd.Connection = con;

                if (this.textBox1.Text == "")
                {
                    cmd.CommandText = "Select * FROM Cursos";
                }
                else
                {
                    cmd.CommandText = "Select Nombre FROM Cursos where Nombre like @filter";
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@filter";
                    param.Value = "%"+this.textBox1.Text.Trim()+"%";
                    cmd.Parameters.Add(param);
                }
                da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                //Mensaje de Error 
                MessageBox.Show(ex.Message);
            }

            da.Dispose();

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                cmd = new SqlCommand();

                cmd.Connection = con;

                if (this.textBox1.Text == "")
                {
                    cmd.CommandText = "Select Materia.MateriaId, Profesores.ProfesorId FROM Materia INNER JOIN Profesores ON Materia.MateriaId = Profesores.ProfesorId";
                }
                else
                {
                    cmd.CommandText = "Select Materia.MateriaId, Profesores.ProfesorId FROM Materia INNER JOIN Profesores ON Materia.MateriaId = Profesores.ProfesorId where MateriaId like @filter";
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@filter";
                    param.Value = "%"+this.textBox1.Text.Trim()+"%";
                    cmd.Parameters.Add(param);
                }

                da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                //Mensaje de Error 
                MessageBox.Show(ex.Message);
            }

            da.Dispose();

            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
