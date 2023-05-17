namespace PPAI_DSI
{
    partial class ConsultarLlamadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarLlamadas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConsultarLlamadas = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGrindLlamadas = new DataGridView();
            IdLlamada = new DataGridViewTextBoxColumn();
            DescripcionOperador = new DataGridViewTextBoxColumn();
            duracion = new DataGridViewTextBoxColumn();
            detalleAccionRequerida = new DataGridViewTextBoxColumn();
            ObservacionAuditor = new DataGridViewTextBoxColumn();
            btnSeleccionarLlamada = new Button();
            label4 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGrindLlamadas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(20, 51);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 0;
            label1.Text = "Consulta de Llamada";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 130);
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
            label3.Location = new Point(424, 130);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha Hasta:";
            label3.Click += label3_Click;
            // 
            // btnConsultarLlamadas
            // 
            btnConsultarLlamadas.Location = new Point(767, 119);
            btnConsultarLlamadas.Name = "btnConsultarLlamadas";
            btnConsultarLlamadas.Size = new Size(153, 48);
            btnConsultarLlamadas.TabIndex = 5;
            btnConsultarLlamadas.Text = "Consultar Llamadas";
            btnConsultarLlamadas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultarLlamadas.UseVisualStyleBackColor = true;
            btnConsultarLlamadas.Click += btnConsultarLlamadas_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(504, 130);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(217, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // dataGrindLlamadas
            // 
            dataGrindLlamadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrindLlamadas.Columns.AddRange(new DataGridViewColumn[] { IdLlamada, DescripcionOperador, duracion, detalleAccionRequerida, ObservacionAuditor });
            dataGrindLlamadas.Location = new Point(12, 254);
            dataGrindLlamadas.Name = "dataGrindLlamadas";
            dataGrindLlamadas.RowTemplate.Height = 25;
            dataGrindLlamadas.Size = new Size(749, 324);
            dataGrindLlamadas.TabIndex = 14;
            // 
            // IdLlamada
            // 
            IdLlamada.HeaderText = "IdLlamada";
            IdLlamada.Name = "IdLlamada";
            // 
            // DescripcionOperador
            // 
            DescripcionOperador.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DescripcionOperador.HeaderText = "Descripcion Operador";
            DescripcionOperador.Name = "DescripcionOperador";
            DescripcionOperador.Width = 134;
            // 
            // duracion
            // 
            duracion.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            duracion.HeaderText = "duracion";
            duracion.Name = "duracion";
            duracion.Width = 79;
            // 
            // detalleAccionRequerida
            // 
            detalleAccionRequerida.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            detalleAccionRequerida.HeaderText = "detalleAccionRequerida";
            detalleAccionRequerida.Name = "detalleAccionRequerida";
            detalleAccionRequerida.Width = 157;
            // 
            // ObservacionAuditor
            // 
            ObservacionAuditor.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ObservacionAuditor.HeaderText = "ObservacionAuditor";
            ObservacionAuditor.Name = "ObservacionAuditor";
            ObservacionAuditor.Width = 138;
            // 
            // btnSeleccionarLlamada
            // 
            btnSeleccionarLlamada.Location = new Point(769, 377);
            btnSeleccionarLlamada.Name = "btnSeleccionarLlamada";
            btnSeleccionarLlamada.Size = new Size(151, 44);
            btnSeleccionarLlamada.TabIndex = 13;
            btnSeleccionarLlamada.Text = "Seleccionar Llamada";
            btnSeleccionarLlamada.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(12, 199);
            label4.Name = "label4";
            label4.Size = new Size(410, 28);
            label4.TabIndex = 12;
            label4.Text = "Llamadas encontradas dentro del periodo:";
            // 
            // btnGenerarCSV
            // 
            btnGenerarCSV.Location = new Point(821, 1027);
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
            label5.Location = new Point(83, 862);
            label5.Name = "label5";
            label5.Size = new Size(214, 21);
            label5.TabIndex = 42;
            label5.Text = "Datos de respuesta cliente:";
            // 
            // txtDuracionLlamada
            // 
            txtDuracionLlamada.Location = new Point(284, 792);
            txtDuracionLlamada.Name = "txtDuracionLlamada";
            txtDuracionLlamada.Size = new Size(100, 23);
            txtDuracionLlamada.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(83, 792);
            label6.Name = "label6";
            label6.Size = new Size(194, 21);
            label6.TabIndex = 40;
            label6.Text = "Duracion de la Llamada:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(673, 659);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(187, 23);
            txtEstado.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label12.Location = new Point(540, 659);
            label12.Name = "label12";
            label12.Size = new Size(118, 21);
            label12.TabIndex = 38;
            label12.Text = "Estado Actual:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(184, 720);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 37;
            label11.Text = "Numero Celular:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(168, 691);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 36;
            label10.Text = "Nombre Completo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 663);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 35;
            label7.Text = "DNI:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(83, 657);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 34;
            label9.Text = "Cliente:";
            // 
            // txtNroCelular
            // 
            txtNroCelular.Location = new Point(284, 717);
            txtNroCelular.Name = "txtNroCelular";
            txtNroCelular.Size = new Size(187, 23);
            txtNroCelular.TabIndex = 33;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(284, 688);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(187, 23);
            txtNombreCompleto.TabIndex = 32;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(284, 659);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(187, 23);
            txtDNI.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(700, 902);
            label8.Name = "label8";
            label8.Size = new Size(147, 15);
            label8.TabIndex = 30;
            label8.Text = "Descripcion de la encuesta";
            // 
            // treeView3
            // 
            treeView3.Location = new Point(851, 902);
            treeView3.Name = "treeView3";
            treeView3.Size = new Size(121, 97);
            treeView3.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(396, 902);
            label13.Name = "label13";
            label13.Size = new Size(160, 15);
            label13.TabIndex = 28;
            label13.Text = "Descripcion de las respuestas";
            // 
            // treeView2
            // 
            treeView2.Location = new Point(562, 902);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(121, 97);
            treeView2.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(108, 902);
            label14.Name = "label14";
            label14.Size = new Size(145, 15);
            label14.TabIndex = 26;
            label14.Text = "Respuestas Seleccionadas:";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(259, 902);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 25;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label15.Location = new Point(20, 610);
            label15.Name = "label15";
            label15.Size = new Size(205, 28);
            label15.TabIndex = 24;
            label15.Text = "Datos de la llamada:";
            // 
            // ConsultarLlamadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 1094);
            Controls.Add(btnGenerarCSV);
            Controls.Add(label5);
            Controls.Add(txtDuracionLlamada);
            Controls.Add(label6);
            Controls.Add(txtEstado);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(txtNroCelular);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtDNI);
            Controls.Add(label8);
            Controls.Add(treeView3);
            Controls.Add(label13);
            Controls.Add(treeView2);
            Controls.Add(label14);
            Controls.Add(treeView1);
            Controls.Add(label15);
            Controls.Add(dataGrindLlamadas);
            Controls.Add(btnSeleccionarLlamada);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnConsultarLlamadas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConsultarLlamadas";
            Text = "Consulta Encuesta";
            Load += ConsultarLlamadas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrindLlamadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConsultarLlamadas;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGrindLlamadas;
        private DataGridViewTextBoxColumn IdLlamada;
        private DataGridViewTextBoxColumn DescripcionOperador;
        private DataGridViewTextBoxColumn duracion;
        private DataGridViewTextBoxColumn detalleAccionRequerida;
        private DataGridViewTextBoxColumn ObservacionAuditor;
        private Button btnSeleccionarLlamada;
        private Label label4;
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
    }
}