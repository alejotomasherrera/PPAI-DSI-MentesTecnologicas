﻿namespace PPAI_DSI
{
    partial class VentanaConsultarLlamadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaConsultarLlamadas));
            label1 = new Label();
            lblfechaDesde = new Label();
            label3 = new Label();
            btnConsultarLlamadas = new Button();
            fechaDesde = new DateTimePicker();
            fechaHasta = new DateTimePicker();
            btnGenerarCSV = new Button();
            label5 = new Label();
            txtDuracionLlamada = new TextBox();
            label6 = new Label();
            txtEstado = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtNroCelular = new TextBox();
            txtNombreCompleto = new TextBox();
            txtDni = new TextBox();
            label15 = new Label();
            label4 = new Label();
            btnSeleccionarLlamada = new Button();
            dataGrindLlamadas = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            duracion = new DataGridViewTextBoxColumn();
            boxHideLlamadasEncontradas = new GroupBox();
            boxDatosLlamada = new GroupBox();
            dataGridEncuesta = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Respuesta = new DataGridViewTextBoxColumn();
            boxConsultaLlamada = new GroupBox();
            Pregunta = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrindLlamadas).BeginInit();
            boxHideLlamadasEncontradas.SuspendLayout();
            boxDatosLlamada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEncuesta).BeginInit();
            boxConsultaLlamada.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(404, 37);
            label1.TabIndex = 0;
            label1.Text = "Consulta encuesta de Llamada";
            label1.Click += label1_Click;
            // 
            // lblfechaDesde
            // 
            lblfechaDesde.AutoSize = true;
            lblfechaDesde.Location = new Point(44, 62);
            lblfechaDesde.Name = "lblfechaDesde";
            lblfechaDesde.Size = new Size(75, 15);
            lblfechaDesde.TabIndex = 3;
            lblfechaDesde.Text = "Fecha desde:";
            lblfechaDesde.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(400, 62);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha Hasta:";
            label3.Click += label3_Click;
            // 
            // btnConsultarLlamadas
            // 
            btnConsultarLlamadas.Location = new Point(743, 51);
            btnConsultarLlamadas.Name = "btnConsultarLlamadas";
            btnConsultarLlamadas.Size = new Size(153, 48);
            btnConsultarLlamadas.TabIndex = 5;
            btnConsultarLlamadas.Text = "Consultar Llamadas";
            btnConsultarLlamadas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultarLlamadas.UseVisualStyleBackColor = true;
            btnConsultarLlamadas.Click += btnConsultarLlamadas_Click;
            // 
            // fechaDesde
            // 
            fechaDesde.Location = new Point(125, 62);
            fechaDesde.Name = "fechaDesde";
            fechaDesde.Size = new Size(217, 23);
            fechaDesde.TabIndex = 8;
            fechaDesde.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // fechaHasta
            // 
            fechaHasta.Location = new Point(480, 62);
            fechaHasta.Name = "fechaHasta";
            fechaHasta.Size = new Size(217, 23);
            fechaHasta.TabIndex = 11;
            fechaHasta.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // btnGenerarCSV
            // 
            btnGenerarCSV.Location = new Point(778, 450);
            btnGenerarCSV.Name = "btnGenerarCSV";
            btnGenerarCSV.Size = new Size(151, 44);
            btnGenerarCSV.TabIndex = 43;
            btnGenerarCSV.Text = "Generar CSV";
            btnGenerarCSV.UseVisualStyleBackColor = true;
            btnGenerarCSV.Click += btnGenerarCSV_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(22, 252);
            label5.Name = "label5";
            label5.Size = new Size(156, 21);
            label5.TabIndex = 42;
            label5.Text = "Encuesta realizada:";
            label5.Click += label5_Click;
            // 
            // txtDuracionLlamada
            // 
            txtDuracionLlamada.Location = new Point(223, 182);
            txtDuracionLlamada.Name = "txtDuracionLlamada";
            txtDuracionLlamada.ReadOnly = true;
            txtDuracionLlamada.Size = new Size(100, 23);
            txtDuracionLlamada.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(22, 182);
            label6.Name = "label6";
            label6.Size = new Size(194, 21);
            label6.TabIndex = 40;
            label6.Text = "Duracion de la Llamada:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(612, 49);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(187, 23);
            txtEstado.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label12.Location = new Point(479, 49);
            label12.Name = "label12";
            label12.Size = new Size(118, 21);
            label12.TabIndex = 38;
            label12.Text = "Estado Actual:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(123, 110);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 37;
            label11.Text = "Numero Celular:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(107, 81);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 36;
            label10.Text = "Nombre Completo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(187, 53);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 35;
            label7.Text = "DNI:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(22, 47);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 34;
            label9.Text = "Cliente:";
            // 
            // txtNroCelular
            // 
            txtNroCelular.Location = new Point(223, 107);
            txtNroCelular.Name = "txtNroCelular";
            txtNroCelular.ReadOnly = true;
            txtNroCelular.Size = new Size(187, 23);
            txtNroCelular.TabIndex = 33;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(223, 78);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.ReadOnly = true;
            txtNombreCompleto.Size = new Size(187, 23);
            txtNombreCompleto.TabIndex = 32;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(223, 45);
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(187, 23);
            txtDni.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label15.Location = new Point(6, 0);
            label15.Name = "label15";
            label15.Size = new Size(205, 28);
            label15.TabIndex = 24;
            label15.Text = "Datos de la llamada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(6, 0);
            label4.Name = "label4";
            label4.Size = new Size(410, 28);
            label4.TabIndex = 12;
            label4.Text = "Llamadas encontradas dentro del periodo:";
            // 
            // btnSeleccionarLlamada
            // 
            btnSeleccionarLlamada.Location = new Point(758, 167);
            btnSeleccionarLlamada.Name = "btnSeleccionarLlamada";
            btnSeleccionarLlamada.Size = new Size(151, 44);
            btnSeleccionarLlamada.TabIndex = 13;
            btnSeleccionarLlamada.Text = "Seleccionar Llamada";
            btnSeleccionarLlamada.UseVisualStyleBackColor = true;
            btnSeleccionarLlamada.Click += btnSeleccionarLlamada_Click;
            // 
            // dataGrindLlamadas
            // 
            dataGrindLlamadas.AllowUserToAddRows = false;
            dataGrindLlamadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrindLlamadas.Columns.AddRange(new DataGridViewColumn[] { DNI, nombreCompleto, duracion });
            dataGrindLlamadas.Location = new Point(1, 44);
            dataGrindLlamadas.Name = "dataGrindLlamadas";
            dataGrindLlamadas.RowTemplate.Height = 25;
            dataGrindLlamadas.Size = new Size(749, 284);
            dataGrindLlamadas.TabIndex = 14;
            dataGrindLlamadas.CellContentClick += dataGrindLlamadas_CellContentClick;
            // 
            // DNI
            // 
            DNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            // 
            // nombreCompleto
            // 
            nombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreCompleto.HeaderText = "Cliente";
            nombreCompleto.Name = "nombreCompleto";
            // 
            // duracion
            // 
            duracion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            duracion.HeaderText = "Duracion";
            duracion.Name = "duracion";
            // 
            // boxHideLlamadasEncontradas
            // 
            boxHideLlamadasEncontradas.Controls.Add(dataGrindLlamadas);
            boxHideLlamadasEncontradas.Controls.Add(btnSeleccionarLlamada);
            boxHideLlamadasEncontradas.Controls.Add(label4);
            boxHideLlamadasEncontradas.Location = new Point(12, 126);
            boxHideLlamadasEncontradas.Name = "boxHideLlamadasEncontradas";
            boxHideLlamadasEncontradas.Size = new Size(928, 344);
            boxHideLlamadasEncontradas.TabIndex = 44;
            boxHideLlamadasEncontradas.TabStop = false;
            boxHideLlamadasEncontradas.Text = "groupBox1";
            boxHideLlamadasEncontradas.Enter += groupBox1_Enter;
            // 
            // boxDatosLlamada
            // 
            boxDatosLlamada.Controls.Add(dataGridEncuesta);
            boxDatosLlamada.Controls.Add(btnGenerarCSV);
            boxDatosLlamada.Controls.Add(label5);
            boxDatosLlamada.Controls.Add(txtDuracionLlamada);
            boxDatosLlamada.Controls.Add(label6);
            boxDatosLlamada.Controls.Add(txtEstado);
            boxDatosLlamada.Controls.Add(label12);
            boxDatosLlamada.Controls.Add(label11);
            boxDatosLlamada.Controls.Add(label10);
            boxDatosLlamada.Controls.Add(label7);
            boxDatosLlamada.Controls.Add(label9);
            boxDatosLlamada.Controls.Add(txtNroCelular);
            boxDatosLlamada.Controls.Add(txtNombreCompleto);
            boxDatosLlamada.Controls.Add(txtDni);
            boxDatosLlamada.Controls.Add(label15);
            boxDatosLlamada.Location = new Point(7, 476);
            boxDatosLlamada.Name = "boxDatosLlamada";
            boxDatosLlamada.Size = new Size(951, 525);
            boxDatosLlamada.TabIndex = 45;
            boxDatosLlamada.TabStop = false;
            boxDatosLlamada.Enter += groupBox1_Enter_1;
            // 
            // dataGridEncuesta
            // 
            dataGridEncuesta.AllowUserToAddRows = false;
            dataGridEncuesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEncuesta.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Respuesta });
            dataGridEncuesta.Location = new Point(36, 276);
            dataGridEncuesta.Name = "dataGridEncuesta";
            dataGridEncuesta.RowTemplate.Height = 25;
            dataGridEncuesta.Size = new Size(705, 218);
            dataGridEncuesta.TabIndex = 44;
            dataGridEncuesta.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Pregunta";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Respuesta
            // 
            Respuesta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Respuesta.HeaderText = "Respuesta";
            Respuesta.Name = "Respuesta";
            // 
            // boxConsultaLlamada
            // 
            boxConsultaLlamada.Controls.Add(fechaHasta);
            boxConsultaLlamada.Controls.Add(fechaDesde);
            boxConsultaLlamada.Controls.Add(btnConsultarLlamadas);
            boxConsultaLlamada.Controls.Add(label3);
            boxConsultaLlamada.Controls.Add(lblfechaDesde);
            boxConsultaLlamada.Controls.Add(label1);
            boxConsultaLlamada.Location = new Point(9, 8);
            boxConsultaLlamada.Name = "boxConsultaLlamada";
            boxConsultaLlamada.Size = new Size(927, 110);
            boxConsultaLlamada.TabIndex = 46;
            boxConsultaLlamada.TabStop = false;
            boxConsultaLlamada.Text = "groupBox1";
            // 
            // Pregunta
            // 
            Pregunta.HeaderText = "Pregunta";
            Pregunta.Name = "Pregunta";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Pregunta";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // button1
            // 
            button1.Location = new Point(973, 921);
            button1.Name = "button1";
            button1.Size = new Size(135, 54);
            button1.TabIndex = 47;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VentanaConsultarLlamadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1136, 1031);
            Controls.Add(button1);
            Controls.Add(boxDatosLlamada);
            Controls.Add(boxHideLlamadasEncontradas);
            Controls.Add(boxConsultaLlamada);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VentanaConsultarLlamadas";
            Text = "Consulta Encuesta";
            Load += ConsultarLlamadas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrindLlamadas).EndInit();
            boxHideLlamadasEncontradas.ResumeLayout(false);
            boxHideLlamadasEncontradas.PerformLayout();
            boxDatosLlamada.ResumeLayout(false);
            boxDatosLlamada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEncuesta).EndInit();
            boxConsultaLlamada.ResumeLayout(false);
            boxConsultaLlamada.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblfechaDesde;
        private Label label3;
        private Button btnConsultarLlamadas;
        private DateTimePicker fechaDesde;
        private DateTimePicker fechaHasta;
        private Button btnGenerarCSV;
        private Label label5;
        private TextBox txtDuracionLlamada;
        private Label label6;
        private TextBox txtEstado;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label9;
        private TextBox txtNroCelular;
        private TextBox txtNombreCompleto;
        private TextBox txtDni;
        private Label label15;
        private Label label4;
        private Button btnSeleccionarLlamada;
        private DataGridView dataGrindLlamadas;
        private GroupBox boxHideLlamadasEncontradas;
        private GroupBox boxDatosLlamada;
        private GroupBox boxConsultaLlamada;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn nombreCompleto;
        private DataGridViewTextBoxColumn duracion;
        private DataGridView dataGridEncuesta;
        private DataGridViewTextBoxColumn Pregunta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Respuesta;
        private Button button1;
    }
}