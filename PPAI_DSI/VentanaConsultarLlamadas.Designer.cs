namespace PPAI_DSI
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaConsultarLlamadas));
            lblConsultaEncuestaLlamada = new Label();
            lblfechaDesde = new Label();
            lblFechaHasta = new Label();
            btnConsultarLlamadas = new Button();
            fechaDesde = new DateTimePicker();
            fechaHasta = new DateTimePicker();
            btnGenerarCSV = new Button();
            lblEncuestaRealizada = new Label();
            txtDuracionLlamada = new TextBox();
            lblDuracionLlamada = new Label();
            txtEstado = new TextBox();
            lblEstadoActual = new Label();
            lblNumeroCelular = new Label();
            lblNombreCompleto = new Label();
            lblDni = new Label();
            lblCliente = new Label();
            txtNroCelular = new TextBox();
            txtNombreCompleto = new TextBox();
            txtDni = new TextBox();
            lblDatosDeLaLlamada = new Label();
            lblLlamadasEncontradaDentroDelperiodo = new Label();
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
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrindLlamadas).BeginInit();
            boxHideLlamadasEncontradas.SuspendLayout();
            boxDatosLlamada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEncuesta).BeginInit();
            boxConsultaLlamada.SuspendLayout();
            SuspendLayout();
            // 
            // lblConsultaEncuestaLlamada
            // 
            lblConsultaEncuestaLlamada.AutoSize = true;
            lblConsultaEncuestaLlamada.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblConsultaEncuestaLlamada.Location = new Point(3, 1);
            lblConsultaEncuestaLlamada.Name = "lblConsultaEncuestaLlamada";
            lblConsultaEncuestaLlamada.Size = new Size(404, 37);
            lblConsultaEncuestaLlamada.TabIndex = 0;
            lblConsultaEncuestaLlamada.Text = "Consulta encuesta de Llamada";
            lblConsultaEncuestaLlamada.Click += label1_Click;
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
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.ImageAlign = ContentAlignment.TopCenter;
            lblFechaHasta.Location = new Point(400, 62);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(74, 15);
            lblFechaHasta.TabIndex = 4;
            lblFechaHasta.Text = "Fecha Hasta:";
            lblFechaHasta.Click += label3_Click;
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
            fechaDesde.MaxDate = new DateTime(2023, 11, 12, 19, 4, 29, 826);
            fechaDesde.Name = "fechaDesde";
            fechaDesde.Size = new Size(217, 23);
            fechaDesde.TabIndex = 8;
            fechaDesde.Value = new DateTime(2022, 11, 12, 19, 4, 29, 827);
            fechaDesde.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // fechaHasta
            // 
            fechaHasta.Location = new Point(480, 62);
            fechaHasta.MaxDate = new DateTime(2023, 11, 12, 19, 4, 29, 843);
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
            // lblEncuestaRealizada
            // 
            lblEncuestaRealizada.AutoSize = true;
            lblEncuestaRealizada.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblEncuestaRealizada.Location = new Point(22, 252);
            lblEncuestaRealizada.Name = "lblEncuestaRealizada";
            lblEncuestaRealizada.Size = new Size(156, 21);
            lblEncuestaRealizada.TabIndex = 42;
            lblEncuestaRealizada.Text = "Encuesta realizada:";
            lblEncuestaRealizada.Click += label5_Click;
            // 
            // txtDuracionLlamada
            // 
            txtDuracionLlamada.Location = new Point(223, 182);
            txtDuracionLlamada.Name = "txtDuracionLlamada";
            txtDuracionLlamada.ReadOnly = true;
            txtDuracionLlamada.Size = new Size(100, 23);
            txtDuracionLlamada.TabIndex = 41;
            // 
            // lblDuracionLlamada
            // 
            lblDuracionLlamada.AutoSize = true;
            lblDuracionLlamada.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDuracionLlamada.Location = new Point(22, 182);
            lblDuracionLlamada.Name = "lblDuracionLlamada";
            lblDuracionLlamada.Size = new Size(194, 21);
            lblDuracionLlamada.TabIndex = 40;
            lblDuracionLlamada.Text = "Duracion de la Llamada:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(612, 49);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(187, 23);
            txtEstado.TabIndex = 39;
            // 
            // lblEstadoActual
            // 
            lblEstadoActual.AutoSize = true;
            lblEstadoActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblEstadoActual.Location = new Point(479, 49);
            lblEstadoActual.Name = "lblEstadoActual";
            lblEstadoActual.Size = new Size(118, 21);
            lblEstadoActual.TabIndex = 38;
            lblEstadoActual.Text = "Estado Actual:";
            // 
            // lblNumeroCelular
            // 
            lblNumeroCelular.AutoSize = true;
            lblNumeroCelular.Location = new Point(123, 110);
            lblNumeroCelular.Name = "lblNumeroCelular";
            lblNumeroCelular.Size = new Size(94, 15);
            lblNumeroCelular.TabIndex = 37;
            lblNumeroCelular.Text = "Numero Celular:";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(107, 81);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(110, 15);
            lblNombreCompleto.TabIndex = 36;
            lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(187, 53);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 35;
            lblDni.Text = "DNI:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblCliente.Location = new Point(22, 47);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(68, 21);
            lblCliente.TabIndex = 34;
            lblCliente.Text = "Cliente:";
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
            // lblDatosDeLaLlamada
            // 
            lblDatosDeLaLlamada.AutoSize = true;
            lblDatosDeLaLlamada.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDatosDeLaLlamada.Location = new Point(6, 0);
            lblDatosDeLaLlamada.Name = "lblDatosDeLaLlamada";
            lblDatosDeLaLlamada.Size = new Size(205, 28);
            lblDatosDeLaLlamada.TabIndex = 24;
            lblDatosDeLaLlamada.Text = "Datos de la llamada:";
            lblDatosDeLaLlamada.Click += label15_Click;
            // 
            // lblLlamadasEncontradaDentroDelperiodo
            // 
            lblLlamadasEncontradaDentroDelperiodo.AutoSize = true;
            lblLlamadasEncontradaDentroDelperiodo.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblLlamadasEncontradaDentroDelperiodo.Location = new Point(6, 0);
            lblLlamadasEncontradaDentroDelperiodo.Name = "lblLlamadasEncontradaDentroDelperiodo";
            lblLlamadasEncontradaDentroDelperiodo.Size = new Size(410, 28);
            lblLlamadasEncontradaDentroDelperiodo.TabIndex = 12;
            lblLlamadasEncontradaDentroDelperiodo.Text = "Llamadas encontradas dentro del periodo:";
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
            dataGrindLlamadas.ReadOnly = true;
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
            DNI.ReadOnly = true;
            // 
            // nombreCompleto
            // 
            nombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreCompleto.HeaderText = "Cliente";
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.ReadOnly = true;
            // 
            // duracion
            // 
            duracion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            duracion.HeaderText = "Duracion";
            duracion.Name = "duracion";
            duracion.ReadOnly = true;
            // 
            // boxHideLlamadasEncontradas
            // 
            boxHideLlamadasEncontradas.Controls.Add(dataGrindLlamadas);
            boxHideLlamadasEncontradas.Controls.Add(btnSeleccionarLlamada);
            boxHideLlamadasEncontradas.Controls.Add(lblLlamadasEncontradaDentroDelperiodo);
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
            boxDatosLlamada.Controls.Add(lblEncuestaRealizada);
            boxDatosLlamada.Controls.Add(txtDuracionLlamada);
            boxDatosLlamada.Controls.Add(lblDuracionLlamada);
            boxDatosLlamada.Controls.Add(txtEstado);
            boxDatosLlamada.Controls.Add(lblEstadoActual);
            boxDatosLlamada.Controls.Add(lblNumeroCelular);
            boxDatosLlamada.Controls.Add(lblNombreCompleto);
            boxDatosLlamada.Controls.Add(lblDni);
            boxDatosLlamada.Controls.Add(lblCliente);
            boxDatosLlamada.Controls.Add(txtNroCelular);
            boxDatosLlamada.Controls.Add(txtNombreCompleto);
            boxDatosLlamada.Controls.Add(txtDni);
            boxDatosLlamada.Controls.Add(lblDatosDeLaLlamada);
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
            dataGridEncuesta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridEncuesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEncuesta.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Respuesta });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridEncuesta.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridEncuesta.Location = new Point(36, 276);
            dataGridEncuesta.Name = "dataGridEncuesta";
            dataGridEncuesta.ReadOnly = true;
            dataGridEncuesta.RowHeadersVisible = false;
            dataGridEncuesta.RowTemplate.Height = 25;
            dataGridEncuesta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEncuesta.Size = new Size(705, 218);
            dataGridEncuesta.TabIndex = 44;
            dataGridEncuesta.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Pregunta";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Respuesta
            // 
            Respuesta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Respuesta.HeaderText = "Respuesta";
            Respuesta.Name = "Respuesta";
            Respuesta.ReadOnly = true;
            // 
            // boxConsultaLlamada
            // 
            boxConsultaLlamada.Controls.Add(fechaHasta);
            boxConsultaLlamada.Controls.Add(fechaDesde);
            boxConsultaLlamada.Controls.Add(btnConsultarLlamadas);
            boxConsultaLlamada.Controls.Add(lblFechaHasta);
            boxConsultaLlamada.Controls.Add(lblfechaDesde);
            boxConsultaLlamada.Controls.Add(lblConsultaEncuestaLlamada);
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
            // btnCancelar
            // 
            btnCancelar.Location = new Point(973, 921);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 54);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // VentanaConsultarLlamadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1136, 1031);
            Controls.Add(btnCancelar);
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

        private Label lblConsultaEncuestaLlamada;
        private Label lblfechaDesde;
        private Label lblFechaHasta;
        private Button btnConsultarLlamadas;
        private DateTimePicker fechaDesde;
        private DateTimePicker fechaHasta;
        private Button btnGenerarCSV;
        private Label lblEncuestaRealizada;
        private TextBox txtDuracionLlamada;
        private Label lblDuracionLlamada;
        private TextBox txtEstado;
        private Label lblEstadoActual;
        private Label lblNumeroCelular;
        private Label lblNombreCompleto;
        private Label lblDni;
        private Label lblCliente;
        private TextBox txtNroCelular;
        private TextBox txtNombreCompleto;
        private TextBox txtDni;
        private Label lblDatosDeLaLlamada;
        private Label lblLlamadasEncontradaDentroDelperiodo;
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
        private Button btnCancelar;
    }
}