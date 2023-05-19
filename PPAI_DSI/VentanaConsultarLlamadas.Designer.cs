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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaConsultarLlamadas));
            label1 = new Label();
            label2 = new Label();
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
            txtDNI = new TextBox();
            label8 = new Label();
            treeView3 = new TreeView();
            label13 = new Label();
            treeView2 = new TreeView();
            label14 = new Label();
            treeView1 = new TreeView();
            label15 = new Label();
            label4 = new Label();
            btnSeleccionarLlamada = new Button();
            dataGrindLlamadas = new DataGridView();
            boxHideLlamadasEncontradas = new GroupBox();
            boxDatosLlamada = new GroupBox();
            boxConsultaLlamada = new GroupBox();
            DNI = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            duracion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrindLlamadas).BeginInit();
            boxHideLlamadasEncontradas.SuspendLayout();
            boxDatosLlamada.SuspendLayout();
            boxConsultaLlamada.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 0;
            label1.Text = "Consulta de Llamada";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 62);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha desde:";
            label2.Click += label2_Click;
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
            btnGenerarCSV.Location = new Point(747, 415);
            btnGenerarCSV.Name = "btnGenerarCSV";
            btnGenerarCSV.Size = new Size(151, 44);
            btnGenerarCSV.TabIndex = 43;
            btnGenerarCSV.Text = "Generar CSV";
            btnGenerarCSV.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(22, 252);
            label5.Name = "label5";
            label5.Size = new Size(214, 21);
            label5.TabIndex = 42;
            label5.Text = "Datos de respuesta cliente:";
            // 
            // txtDuracionLlamada
            // 
            txtDuracionLlamada.Location = new Point(223, 182);
            txtDuracionLlamada.Name = "txtDuracionLlamada";
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
            txtNroCelular.Size = new Size(187, 23);
            txtNroCelular.TabIndex = 33;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(223, 78);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(187, 23);
            txtNombreCompleto.TabIndex = 32;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(223, 49);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(187, 23);
            txtDNI.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(614, 294);
            label8.Name = "label8";
            label8.Size = new Size(147, 15);
            label8.TabIndex = 30;
            label8.Text = "Descripcion de la encuesta";
            // 
            // treeView3
            // 
            treeView3.Location = new Point(765, 294);
            treeView3.Name = "treeView3";
            treeView3.Size = new Size(121, 97);
            treeView3.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(310, 294);
            label13.Name = "label13";
            label13.Size = new Size(160, 15);
            label13.TabIndex = 28;
            label13.Text = "Descripcion de las respuestas";
            // 
            // treeView2
            // 
            treeView2.Location = new Point(476, 294);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(121, 97);
            treeView2.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 294);
            label14.Name = "label14";
            label14.Size = new Size(145, 15);
            label14.TabIndex = 26;
            label14.Text = "Respuestas Seleccionadas:";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(173, 294);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 25;
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
            dataGrindLlamadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrindLlamadas.Columns.AddRange(new DataGridViewColumn[] { DNI, nombreCompleto, duracion });
            dataGrindLlamadas.Location = new Point(1, 44);
            dataGrindLlamadas.Name = "dataGrindLlamadas";
            dataGrindLlamadas.RowTemplate.Height = 25;
            dataGrindLlamadas.Size = new Size(749, 284);
            dataGrindLlamadas.TabIndex = 14;
            dataGrindLlamadas.CellContentClick += dataGrindLlamadas_CellContentClick;
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
            boxDatosLlamada.Controls.Add(txtDNI);
            boxDatosLlamada.Controls.Add(label8);
            boxDatosLlamada.Controls.Add(treeView3);
            boxDatosLlamada.Controls.Add(label13);
            boxDatosLlamada.Controls.Add(treeView2);
            boxDatosLlamada.Controls.Add(label14);
            boxDatosLlamada.Controls.Add(treeView1);
            boxDatosLlamada.Controls.Add(label15);
            boxDatosLlamada.Location = new Point(7, 476);
            boxDatosLlamada.Name = "boxDatosLlamada";
            boxDatosLlamada.Size = new Size(951, 525);
            boxDatosLlamada.TabIndex = 45;
            boxDatosLlamada.TabStop = false;
            boxDatosLlamada.Enter += groupBox1_Enter_1;
            // 
            // boxConsultaLlamada
            // 
            boxConsultaLlamada.Controls.Add(fechaHasta);
            boxConsultaLlamada.Controls.Add(fechaDesde);
            boxConsultaLlamada.Controls.Add(btnConsultarLlamadas);
            boxConsultaLlamada.Controls.Add(label3);
            boxConsultaLlamada.Controls.Add(label2);
            boxConsultaLlamada.Controls.Add(label1);
            boxConsultaLlamada.Location = new Point(9, 8);
            boxConsultaLlamada.Name = "boxConsultaLlamada";
            boxConsultaLlamada.Size = new Size(927, 110);
            boxConsultaLlamada.TabIndex = 46;
            boxConsultaLlamada.TabStop = false;
            boxConsultaLlamada.Text = "groupBox1";
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
            // ConsultarLlamadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 1061);
            Controls.Add(boxHideLlamadasEncontradas);
            Controls.Add(boxDatosLlamada);
            Controls.Add(boxConsultaLlamada);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConsultarLlamadas";
            Text = "Consulta Encuesta";
            Load += ConsultarLlamadas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrindLlamadas).EndInit();
            boxHideLlamadasEncontradas.ResumeLayout(false);
            boxHideLlamadasEncontradas.PerformLayout();
            boxDatosLlamada.ResumeLayout(false);
            boxDatosLlamada.PerformLayout();
            boxConsultaLlamada.ResumeLayout(false);
            boxConsultaLlamada.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
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
        private TextBox txtDNI;
        private Label label8;
        private TreeView treeView3;
        private Label label13;
        private TreeView treeView2;
        private Label label14;
        private TreeView treeView1;
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
    }
}