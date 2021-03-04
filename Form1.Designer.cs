namespace lab_Empleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.dtgAsistencia = new System.Windows.Forms.DataGridView();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.añadirEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbNum = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbSalario = new System.Windows.Forms.RadioButton();
            this.rbSalario2 = new System.Windows.Forms.RadioButton();
            this.rbNombre2 = new System.Windows.Forms.RadioButton();
            this.rbNum2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsistencia)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(447, 458);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(111, 34);
            this.btnCargarDatos.TabIndex = 0;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(37, 87);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.RowHeadersWidth = 51;
            this.dtgEmpleados.RowTemplate.Height = 24;
            this.dtgEmpleados.Size = new System.Drawing.Size(524, 113);
            this.dtgEmpleados.TabIndex = 1;
            // 
            // dtgAsistencia
            // 
            this.dtgAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAsistencia.Location = new System.Drawing.Point(34, 262);
            this.dtgAsistencia.Name = "dtgAsistencia";
            this.dtgAsistencia.RowHeadersWidth = 51;
            this.dtgAsistencia.RowTemplate.Height = 24;
            this.dtgAsistencia.Size = new System.Drawing.Size(524, 177);
            this.dtgAsistencia.TabIndex = 2;
            // 
            // cmbNumero
            // 
            this.cmbNumero.FormattingEnabled = true;
            this.cmbNumero.Location = new System.Drawing.Point(70, 221);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(98, 24);
            this.cmbNumero.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vista General de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirEmpleadoToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // añadirEmpleadoToolStripMenuItem
            // 
            this.añadirEmpleadoToolStripMenuItem.Name = "añadirEmpleadoToolStripMenuItem";
            this.añadirEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.añadirEmpleadoToolStripMenuItem.Text = "Empleados";
            this.añadirEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.añadirEmpleadoToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.pagosToolStripMenuItem.Text = "Emisión de Salarios";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // rbNum
            // 
            this.rbNum.AutoSize = true;
            this.rbNum.Location = new System.Drawing.Point(23, 23);
            this.rbNum.Name = "rbNum";
            this.rbNum.Size = new System.Drawing.Size(103, 21);
            this.rbNum.TabIndex = 18;
            this.rbNum.TabStop = true;
            this.rbNum.Text = "Por número";
            this.rbNum.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(23, 50);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(79, 21);
            this.rbNombre.TabIndex = 19;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbSalario
            // 
            this.rbSalario.AutoSize = true;
            this.rbSalario.Location = new System.Drawing.Point(23, 77);
            this.rbSalario.Name = "rbSalario";
            this.rbSalario.Size = new System.Drawing.Size(73, 21);
            this.rbSalario.TabIndex = 20;
            this.rbSalario.TabStop = true;
            this.rbSalario.Text = "Salario";
            this.rbSalario.UseVisualStyleBackColor = true;
            // 
            // rbSalario2
            // 
            this.rbSalario2.AutoSize = true;
            this.rbSalario2.Location = new System.Drawing.Point(16, 75);
            this.rbSalario2.Name = "rbSalario2";
            this.rbSalario2.Size = new System.Drawing.Size(73, 21);
            this.rbSalario2.TabIndex = 23;
            this.rbSalario2.TabStop = true;
            this.rbSalario2.Text = "Salario";
            this.rbSalario2.UseVisualStyleBackColor = true;
            // 
            // rbNombre2
            // 
            this.rbNombre2.AutoSize = true;
            this.rbNombre2.Location = new System.Drawing.Point(16, 48);
            this.rbNombre2.Name = "rbNombre2";
            this.rbNombre2.Size = new System.Drawing.Size(79, 21);
            this.rbNombre2.TabIndex = 22;
            this.rbNombre2.TabStop = true;
            this.rbNombre2.Text = "Nombre";
            this.rbNombre2.UseVisualStyleBackColor = true;
            // 
            // rbNum2
            // 
            this.rbNum2.AutoSize = true;
            this.rbNum2.Location = new System.Drawing.Point(16, 21);
            this.rbNum2.Name = "rbNum2";
            this.rbNum2.Size = new System.Drawing.Size(103, 21);
            this.rbNum2.TabIndex = 21;
            this.rbNum2.TabStop = true;
            this.rbNum2.Text = "Por número";
            this.rbNum2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbNum);
            this.groupBox1.Controls.Add(this.rbSalario);
            this.groupBox1.Location = new System.Drawing.Point(582, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 105);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNum2);
            this.groupBox2.Controls.Add(this.rbNombre2);
            this.groupBox2.Controls.Add(this.rbSalario2);
            this.groupBox2.Location = new System.Drawing.Point(582, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 105);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orden";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(267, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 511);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNumero);
            this.Controls.Add(this.dtgAsistencia);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información general";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsistencia)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.DataGridView dtgAsistencia;
        private System.Windows.Forms.ComboBox cmbNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbNum;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbSalario;
        private System.Windows.Forms.RadioButton rbSalario2;
        private System.Windows.Forms.RadioButton rbNombre2;
        private System.Windows.Forms.RadioButton rbNum2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

