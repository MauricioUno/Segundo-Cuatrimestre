namespace Uño.Mauricio._2C
{
    partial class View
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpAltaAlumno = new GroupBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            btnCreaAlumno = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            grpAsignaMateria = new GroupBox();
            btnAsignar = new Button();
            lblMateria = new Label();
            cmbMaterias = new ComboBox();
            lstAlumnosInscriptosProgramacion = new ListBox();
            lstAlumnosInscriptosLaboratorio = new ListBox();
            lstAlumnosCreados = new ListBox();
            lblAlumnosCreados = new Label();
            lblInscriptosProgra = new Label();
            lblInscriptosLabo = new Label();
            grpAltaAlumno.SuspendLayout();
            grpAsignaMateria.SuspendLayout();
            SuspendLayout();
            // 
            // grpAltaAlumno
            // 
            grpAltaAlumno.Controls.Add(lblNombre);
            grpAltaAlumno.Controls.Add(lblApellido);
            grpAltaAlumno.Controls.Add(lblDni);
            grpAltaAlumno.Controls.Add(btnCreaAlumno);
            grpAltaAlumno.Controls.Add(txtNombre);
            grpAltaAlumno.Controls.Add(txtApellido);
            grpAltaAlumno.Controls.Add(txtDni);
            grpAltaAlumno.Location = new Point(300, 12);
            grpAltaAlumno.Name = "grpAltaAlumno";
            grpAltaAlumno.Size = new Size(400, 180);
            grpAltaAlumno.TabIndex = 0;
            grpAltaAlumno.TabStop = false;
            grpAltaAlumno.Text = "Alta Alumno";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(274, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(137, 48);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 20);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "APELLIDO:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(0, 48);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI:";
            // 
            // btnCreaAlumno
            // 
            btnCreaAlumno.Location = new Point(137, 135);
            btnCreaAlumno.Name = "btnCreaAlumno";
            btnCreaAlumno.Size = new Size(125, 29);
            btnCreaAlumno.TabIndex = 3;
            btnCreaAlumno.Text = "Crear Alumno";
            btnCreaAlumno.UseVisualStyleBackColor = true;
            btnCreaAlumno.Click += btnCreaAlumno_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(274, 71);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(137, 71);
            txtApellido.MaxLength = 15;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(0, 71);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 0;
            // 
            // grpAsignaMateria
            // 
            grpAsignaMateria.Controls.Add(btnAsignar);
            grpAsignaMateria.Controls.Add(lblMateria);
            grpAsignaMateria.Controls.Add(cmbMaterias);
            grpAsignaMateria.Location = new Point(325, 250);
            grpAsignaMateria.Name = "grpAsignaMateria";
            grpAsignaMateria.Size = new Size(250, 200);
            grpAsignaMateria.TabIndex = 1;
            grpAsignaMateria.TabStop = false;
            grpAsignaMateria.Text = "Asignar Materia";
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(40, 139);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(170, 55);
            btnAsignar.TabIndex = 2;
            btnAsignar.Text = "Asignar al alumno seleccionado";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(86, 55);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(70, 20);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "MATERIA";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(50, 78);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(150, 28);
            cmbMaterias.TabIndex = 0;
            // 
            // lstAlumnosInscriptosProgramacion
            // 
            lstAlumnosInscriptosProgramacion.FormattingEnabled = true;
            lstAlumnosInscriptosProgramacion.ItemHeight = 20;
            lstAlumnosInscriptosProgramacion.Location = new Point(613, 232);
            lstAlumnosInscriptosProgramacion.Name = "lstAlumnosInscriptosProgramacion";
            lstAlumnosInscriptosProgramacion.Size = new Size(169, 264);
            lstAlumnosInscriptosProgramacion.TabIndex = 3;
            // 
            // lstAlumnosInscriptosLaboratorio
            // 
            lstAlumnosInscriptosLaboratorio.FormattingEnabled = true;
            lstAlumnosInscriptosLaboratorio.ItemHeight = 20;
            lstAlumnosInscriptosLaboratorio.Location = new Point(801, 232);
            lstAlumnosInscriptosLaboratorio.Name = "lstAlumnosInscriptosLaboratorio";
            lstAlumnosInscriptosLaboratorio.Size = new Size(169, 264);
            lstAlumnosInscriptosLaboratorio.TabIndex = 4;
            // 
            // lstAlumnosCreados
            // 
            lstAlumnosCreados.FormattingEnabled = true;
            lstAlumnosCreados.ItemHeight = 20;
            lstAlumnosCreados.Location = new Point(12, 232);
            lstAlumnosCreados.Name = "lstAlumnosCreados";
            lstAlumnosCreados.Size = new Size(289, 264);
            lstAlumnosCreados.TabIndex = 5;
            // 
            // lblAlumnosCreados
            // 
            lblAlumnosCreados.AutoSize = true;
            lblAlumnosCreados.Location = new Point(12, 209);
            lblAlumnosCreados.Name = "lblAlumnosCreados";
            lblAlumnosCreados.Size = new Size(128, 20);
            lblAlumnosCreados.TabIndex = 6;
            lblAlumnosCreados.Text = "Alumnos Creados:";
            // 
            // lblInscriptosProgra
            // 
            lblInscriptosProgra.AutoSize = true;
            lblInscriptosProgra.Location = new Point(613, 209);
            lblInscriptosProgra.Name = "lblInscriptosProgra";
            lblInscriptosProgra.Size = new Size(123, 20);
            lblInscriptosProgra.TabIndex = 7;
            lblInscriptosProgra.Text = "Inscriptos Progra:";
            // 
            // lblInscriptosLabo
            // 
            lblInscriptosLabo.AutoSize = true;
            lblInscriptosLabo.Location = new Point(801, 209);
            lblInscriptosLabo.Name = "lblInscriptosLabo";
            lblInscriptosLabo.Size = new Size(112, 20);
            lblInscriptosLabo.TabIndex = 8;
            lblInscriptosLabo.Text = "Inscriptos Labo:";
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(lblInscriptosLabo);
            Controls.Add(lblInscriptosProgra);
            Controls.Add(lblAlumnosCreados);
            Controls.Add(lstAlumnosCreados);
            Controls.Add(lstAlumnosInscriptosLaboratorio);
            Controls.Add(lstAlumnosInscriptosProgramacion);
            Controls.Add(grpAsignaMateria);
            Controls.Add(grpAltaAlumno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View";
            Load += View_Load;
            grpAltaAlumno.ResumeLayout(false);
            grpAltaAlumno.PerformLayout();
            grpAsignaMateria.ResumeLayout(false);
            grpAsignaMateria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpAltaAlumno;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Button btnCreaAlumno;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private GroupBox grpAsignaMateria;
        private Button btnAsignar;
        private Label lblMateria;
        private ComboBox cmbMaterias;
        private ListBox lstAlumnosInscriptosProgramacion;
        private ListBox lstAlumnosInscriptosLaboratorio;
        private ListBox lstAlumnosCreados;
        private Label lblAlumnosCreados;
        private Label lblInscriptosProgra;
        private Label lblInscriptosLabo;
    }
}