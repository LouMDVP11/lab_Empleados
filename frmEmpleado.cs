﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_Empleados
{
    public partial class frmEmpleado : Form
    {
        public List<clsEmpleado> lstEmpleados;
        public frmEmpleado()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar)){
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)){ //permitir teclas de control como retroceso
                e.Handled = false;
            }
            else{
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int contPuntos = 0;
            string cadena = txtSalario.Text;
            char letra;
            for (int x = 0; x < cadena.Length; x++) {
                letra = cadena[x];
                if (letra.Equals('.')) contPuntos++;
            }

            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                //permitir teclas de control como retroceso
                e.Handled = false;
            else if (contPuntos == 0 && e.KeyChar == '.')
                //permitir un punto si no han ingresado uno anteriormente
                e.Handled = false;
            else
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
        }

        private void frmEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
