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
            ((System.ComponentModel.ISupportInitialize)dataGrindLlamadas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(41, 51);
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
            btnSeleccionarLlamada.Location = new Point(767, 293);
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
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(410, 28);
            label4.TabIndex = 12;
            label4.Text = "Llamadas encontradas dentro del periodo:";
            // 
            // ConsultarLlamadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 828);
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
    }
}