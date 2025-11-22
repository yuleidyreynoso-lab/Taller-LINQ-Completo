using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;


namespace Parte_3_LINQ_a_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Conexión a la base de datos usando tu DataContext generado por el .dbml
            DataClassesDataContext db = new DataClassesDataContext();

            // 1. Estudiantes menores de 20
            var menoresDe20 = from estudiante in db.Estudiantes
                              where estudiante.Edad < 20
                              select estudiante;

            string salida = "Estudiantes menores de 20 años:\n";
            foreach (var est in menoresDe20)
            {
                salida += $"{est.Id} - {est.Nombre} - {est.Edad}\n";
            }

            // 2. Estudiantes ordenados por nombre
            var ordenadosPorNombre = from estudiante in db.Estudiantes
                                     orderby estudiante.Nombre
                                     select estudiante;

            salida += "\nEstudiantes ordenados por nombre:\n";
            foreach (var est in ordenadosPorNombre)
            {
                salida += $"{est.Nombre}\n";
            }

            // 3. Estudiantes cuyo nombre empieza con A
            var nombresConA = from estudiante in db.Estudiantes
                              where estudiante.Nombre.StartsWith("A")
                              select estudiante;

            salida += "\nNombres que empiezan con A:\n";
            foreach (var est in nombresConA)
            {
                salida += $"{est.Nombre}\n";
            }

            MessageBox.Show(salida, "Resultados LINQ to SQL");
        }
    }
}
    

