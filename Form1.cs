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
        public List<clsEmpleado> lstEmpleados = new List<clsEmpleado>();
        public List<clsAsistencia> lstAsistencias = new List<clsAsistencia>();
        Boolean isInfocus = true;
        public Form1()
        {
            InitializeComponent();

        }
        
        private void añadirEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.lstEmpleados = this.lstEmpleados;
            isInfocus = false;
            empleado.Actualizar();
            empleado.ShowDialog();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsistencia asistencia = new frmAsistencia();
            asistencia.lstEmpleados = this.lstEmpleados;
            asistencia.lstAsistencias = this.lstAsistencias;
            asistencia.ShowDialog();
        }
        public void actualizar()
        {
            this.dtgEmpleados.DataSource = null;
            this.dtgEmpleados.DataSource = this.lstEmpleados;
            this.dtgEmpleados.Refresh();
            this.dtgAsistencia.DataSource = null;
            this.dtgAsistencia.DataSource = this.lstAsistencias;
            this.dtgAsistencia.Refresh();
            if(lstEmpleados.Count>0)
            foreach (var em in lstEmpleados) {
                cmbNumero.Items.Add(em.Codigo);
                cmbNombre.Items.Add(em.Nombre);
            }
        }
        private void loadData() {
            FileStream stream = new FileStream("Empleados.txt", FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream("Asistencias.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            StreamReader reader2 = new StreamReader(stream2);
            lstEmpleados.Clear();
            lstAsistencias.Clear();
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
                clsAsistencia asistenciaTemp = new clsAsistencia();
                asistenciaTemp.Codigo = Convert.ToInt32(reader2.ReadLine());
                asistenciaTemp.HorasMes = Convert.ToInt32(reader2.ReadLine());
                asistenciaTemp.Mes = reader2.ReadLine();
                asistenciaTemp.TotalPagado = Convert.ToDouble(reader2.ReadLine());
                lstAsistencias.Add(asistenciaTemp);
            }
            reader2.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            this.actualizar();
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
            actualizar();
        }

        private void cmbNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNombre.SelectedIndex = cmbNumero.SelectedIndex;
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNumero.SelectedIndex = cmbNombre.SelectedIndex;
        }
    }
}
