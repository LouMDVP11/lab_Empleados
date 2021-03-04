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
    public partial class frmAsistencia : Form
    {
        public List<clsEmpleado> lstEmpleados;
        public List<clsAsistencia> lstAsistencias;
        public frmAsistencia()
        {
            InitializeComponent();
        }
        public void Actualizar()
        {
            this.dtgListado.DataSource = null;
            this.dtgListado.DataSource = this.lstAsistencias;
            this.dtgListado.Refresh();
        }
        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            foreach (var em in lstEmpleados)
                cmbNumero.Items.Add(em.Codigo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbNumero.SelectedIndex > -1 && cmbMes.SelectedIndex > -1)
            {
                FileStream stream = new FileStream("Asistencias.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                clsAsistencia nuevaAsistencia = new clsAsistencia();
                nuevaAsistencia.Codigo = Convert.ToInt32(cmbNumero.SelectedItem);
                nuevaAsistencia.HorasMes = Convert.ToInt32(nudHoras.Value);
                nuevaAsistencia.Mes = Convert.ToString(cmbMes.SelectedItem);
                nuevaAsistencia.TotalPagado = nuevaAsistencia.HorasMes * lstEmpleados[cmbNumero.SelectedIndex].Sueldo;
                writer.WriteLine(nuevaAsistencia.Codigo);
                writer.WriteLine(nuevaAsistencia.HorasMes);
                writer.WriteLine(nuevaAsistencia.Mes);
                writer.WriteLine(nuevaAsistencia.TotalPagado);
                writer.Close();
                this.lstAsistencias.Add(nuevaAsistencia);
                MessageBox.Show("Salario emitido agregado exitosamente.");
                cmbMes.SelectedIndex = -1;
                cmbNumero.SelectedIndex = -1;
                nudHoras.Value = 1;
                txtNombre.Clear();
                Actualizar();
            }
            else MessageBox.Show("Debe seleccionar información para todos los datos.");
        }

        private void cmbNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = lstEmpleados[cmbNumero.SelectedIndex].Nombre;
        }
    }
}
