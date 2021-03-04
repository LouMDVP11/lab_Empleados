using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_Empleados
{
    public partial class Form1 : Form
    {
        List<clsEmpleado> lstEmpleados = new List<clsEmpleado>();
        List<clsAsistencia> lstAsistencias = new List<clsAsistencia>();
        List<clsIntermedia> lstIntermedias = new List<clsIntermedia>();

        public Form1()
        {
            InitializeComponent();

        }
        
        private void añadirEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.lstEmpleados = this.lstEmpleados;
            empleado.ShowDialog();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsistencia asistencia = new frmAsistencia();
            asistencia.lstEmpleados = this.lstEmpleados;
            asistencia.lstAsistencias = this.lstAsistencias;
            asistencia.lstIntermedias = this.lstIntermedias;
            asistencia.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Empleados.txt", FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream("Intermedias.txt", FileMode.Open, FileAccess.Read);
            FileStream stream3 = new FileStream("Asistencias.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            StreamReader reader2 = new StreamReader(stream2);
            StreamReader reader3 = new StreamReader(stream3);
            while (reader.Peek() > -1)
            {
                clsEmpleado empleadoTemp = new clsEmpleado();
                empleadoTemp.Codigo = Convert.ToInt32(reader.ReadLine());
                empleadoTemp.Nombre = reader.ReadLine();
                empleadoTemp.Sueldo = Convert.ToDouble(reader.ReadLine());
                lstEmpleados.Add(empleadoTemp);
            }
            reader.Close();
            while (reader2.Peek() > -1)
            {
                clsIntermedia interTemp = new clsIntermedia();
                interTemp.Codigo = Convert.ToInt32(reader2.ReadLine());
                interTemp.TotalPagado = Convert.ToDouble(reader2.ReadLine());
                lstIntermedias.Add(interTemp);
            }
            reader2.Close();
            while (reader3.Peek() > -1)
            {
                clsAsistencia asistenciaTemp = new clsAsistencia();
                asistenciaTemp.Codigo = Convert.ToInt32(reader3.ReadLine());
                asistenciaTemp.HorasMes = Convert.ToInt32(reader3.ReadLine());
                asistenciaTemp.Mes = reader3.ReadLine();
                lstAsistencias.Add(asistenciaTemp);
            }
            reader3.Close();
        }
    }
}
