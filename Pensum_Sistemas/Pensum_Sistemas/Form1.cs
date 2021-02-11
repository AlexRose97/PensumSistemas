using Pensum_Sistemas.Cursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pensum_Sistemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            iniciarTablas();
            mis_acciones.argregarCursos();
        }

        private Acciones mis_acciones = new Acciones();
        private int Creditos = 0;
        private Dictionary<int, ObjetoCurso> Aprobados = new Dictionary<int, ObjetoCurso>();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_FiltrarCursos_Click(object sender, EventArgs e)
        {

            grid_Filtro.Rows.Clear();
            List<ObjetoCurso> cursos = mis_acciones.busqueda_cursosDisponibles(Creditos, Aprobados);
            foreach (ObjetoCurso s in cursos)
            {
                grid_Filtro.Rows.Add(s.Codigo, s.Creditos, s.Curso, s.obligatorio.ToString(), s.Semestre);
            }


            //actualizar creditos
            lb_Creditos.Text = Creditos.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creditos = 0;
            Aprobados = new Dictionary<int, ObjetoCurso>();
            this.Width = 560;
        }

        private void bt_CursosAprobados_Click(object sender, EventArgs e)
        {
            //recorrer los columnas de cursos seleccionados
            ObjetoCurso micurso = new ObjetoCurso();
            for (int i = 0; i < grid_Semestre.RowCount; i++)
            {
                if ((Boolean)grid_Semestre.Rows[i].Cells[4].EditedFormattedValue == true)
                {
                    if (Aprobados.ContainsKey(System.Convert.ToInt32(grid_Semestre.Rows[i].Cells[0].EditedFormattedValue)) == false)
                    {
                        micurso = mis_acciones.buscar_curso(System.Convert.ToInt32(grid_Semestre.Rows[i].Cells[0].EditedFormattedValue));
                        Aprobados.Add(micurso.Codigo, micurso);
                        Creditos += micurso.Creditos;
                    }

                }

            }



            grid_Aprobados.Rows.Clear();

            Recargar_lista();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            grid_Semestre.Rows.Clear();

            int semestre = cb_Semestre.SelectedIndex + 1;
            if (semestre > 0)
            {
                List<ObjetoCurso> cursos = mis_acciones.busqueda_Semestre(semestre);

                foreach (ObjetoCurso s in cursos)
                {
                    grid_Semestre.Rows.Add(s.Codigo, s.Creditos, s.Curso, s.obligatorio.ToString());
                }

            }


        }


        private void iniciarTablas()
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }









        /*========================================================Cursos============================================================*/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_semestre.Checked == true)
            {
                check_todos.Checked = false;
                cb_seleccionSemestre.Visible = true;
            }
            else
            {
                check_todos.Checked = true;
                cb_seleccionSemestre.Visible = false;
            }
        }

        private void check_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (check_todos.Checked == true)
            {
                check_semestre.Checked = false;
                cb_seleccionSemestre.Visible = false;
            }
            else
            {
                check_semestre.Checked = true;
                cb_seleccionSemestre.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 850;
            grid_Cursos.Rows.Clear();


            List<ObjetoCurso> Los_Cursos = new List<ObjetoCurso>();
            //tomar el texto
            string curso = txt_Curso.Text.ToUpper();

            if (check_todos.Checked == true)
            {

                Los_Cursos = mis_acciones.busqueda_Curso_todos(curso);
            }
            else//filtrado por semestre
            {
                //tomar el semestre
                int semestre = cb_seleccionSemestre.SelectedIndex + 1;
                if (semestre > 0)
                {



                }
                else//no selecciono semsetre, mostrar todos
                {
                    Los_Cursos = mis_acciones.busqueda_Curso_todos(curso);

                }

            }


            //agregar a la tabla
            foreach (ObjetoCurso s in Los_Cursos)
            {
                grid_Cursos.Rows.Add(s.Codigo, s.Creditos, s.Curso, s.obligatorio.ToString(), s.Semestre,s.cursos_Pre,s.Creditos_Pre);
            }




        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mis_acciones.GUARDAR(Aprobados);
        }

        private void cargarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargar_Lista_Aprobados();   
        }


        private void cargar_Lista_Aprobados()
        {
            int cred = 0;

            Aprobados = mis_acciones.CARGAR();
            Recargar_lista();



        }

        private void Recargar_lista()
        {
            int cred = 0;
            //mostrar los cursos agregados
            grid_Aprobados.Rows.Clear();
            foreach (ObjetoCurso s in Aprobados.Values)
            {
                grid_Aprobados.Rows.Add(0, s.Codigo, s.Creditos, s.Curso);
                cred += s.Creditos;

            }
            Creditos = cred;
            //actualizar creditos
            lb_Creditos.Text = Creditos.ToString();
            this.Width = 850;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //recorrer los columnas de cursos seleccionados
            ObjetoCurso micurso = new ObjetoCurso();
            for (int i = 0; i < grid_Aprobados.RowCount; i++)
            {
                if ((Boolean)grid_Aprobados.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    Aprobados.Remove(System.Convert.ToInt32(grid_Aprobados.Rows[i].Cells[1].EditedFormattedValue));
                    
                }

            }


            Recargar_lista();




        }

        private void txt_Curso_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
