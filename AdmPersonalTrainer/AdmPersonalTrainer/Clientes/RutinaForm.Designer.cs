
namespace AdmPersonalTrainer.Clientes
{
    partial class RutinaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFiltrarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.pnlDia = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRutina = new System.Windows.Forms.Panel();
            this.btnRutinaObjetivo = new System.Windows.Forms.Button();
            this.txtRutinaObjetivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEjercicioLinkVideo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEjercicioDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEjercicioAgregar = new System.Windows.Forms.Button();
            this.btnEjercicioModificar = new System.Windows.Forms.Button();
            this.btnEjercicioBorrar = new System.Windows.Forms.Button();
            this.pnlDiaFormEjercicio = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlDia.SuspendLayout();
            this.pnlRutina.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDiaFormEjercicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "GESTION DE RUTINAS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.panel3.Controls.Add(this.txtFiltrarCliente);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(16, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 67);
            this.panel3.TabIndex = 25;
            // 
            // txtFiltrarCliente
            // 
            this.txtFiltrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtFiltrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltrarCliente.Location = new System.Drawing.Point(94, 26);
            this.txtFiltrarCliente.Name = "txtFiltrarCliente";
            this.txtFiltrarCliente.Size = new System.Drawing.Size(202, 13);
            this.txtFiltrarCliente.TabIndex = 1;
            this.txtFiltrarCliente.TextChanged += new System.EventHandler(this.txtFiltarCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "FILTRAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(12, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "LISTA DE CLIENTES";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeight = 40;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(16, 160);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(329, 373);
            this.dgvClientes.TabIndex = 23;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // cbDias
            // 
            this.cbDias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(61, 13);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(291, 21);
            this.cbDias.TabIndex = 26;
            // 
            // pnlDia
            // 
            this.pnlDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.pnlDia.Controls.Add(this.label3);
            this.pnlDia.Controls.Add(this.cbDias);
            this.pnlDia.Location = new System.Drawing.Point(0, 3);
            this.pnlDia.Name = "pnlDia";
            this.pnlDia.Size = new System.Drawing.Size(359, 45);
            this.pnlDia.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Día:";
            // 
            // pnlRutina
            // 
            this.pnlRutina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.pnlRutina.Controls.Add(this.btnRutinaObjetivo);
            this.pnlRutina.Controls.Add(this.txtRutinaObjetivo);
            this.pnlRutina.Controls.Add(this.label4);
            this.pnlRutina.Location = new System.Drawing.Point(351, 87);
            this.pnlRutina.Name = "pnlRutina";
            this.pnlRutina.Size = new System.Drawing.Size(359, 180);
            this.pnlRutina.TabIndex = 27;
            // 
            // btnRutinaObjetivo
            // 
            this.btnRutinaObjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnRutinaObjetivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnRutinaObjetivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutinaObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutinaObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnRutinaObjetivo.Image = global::AdmPersonalTrainer.Properties.Resources.icons8_fit_30;
            this.btnRutinaObjetivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutinaObjetivo.Location = new System.Drawing.Point(96, 131);
            this.btnRutinaObjetivo.Name = "btnRutinaObjetivo";
            this.btnRutinaObjetivo.Size = new System.Drawing.Size(178, 37);
            this.btnRutinaObjetivo.TabIndex = 35;
            this.btnRutinaObjetivo.Text = "Cambiar objetivo";
            this.btnRutinaObjetivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRutinaObjetivo.UseVisualStyleBackColor = false;
            this.btnRutinaObjetivo.Click += new System.EventHandler(this.btnRutinaObjetivo_Click);
            // 
            // txtRutinaObjetivo
            // 
            this.txtRutinaObjetivo.Location = new System.Drawing.Point(6, 22);
            this.txtRutinaObjetivo.Multiline = true;
            this.txtRutinaObjetivo.Name = "txtRutinaObjetivo";
            this.txtRutinaObjetivo.Size = new System.Drawing.Size(346, 103);
            this.txtRutinaObjetivo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(7, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Objetivo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.txtEjercicioLinkVideo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEjercicioDescripcion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 209);
            this.panel1.TabIndex = 27;
            // 
            // txtEjercicioLinkVideo
            // 
            this.txtEjercicioLinkVideo.Location = new System.Drawing.Point(6, 173);
            this.txtEjercicioLinkVideo.Name = "txtEjercicioLinkVideo";
            this.txtEjercicioLinkVideo.Size = new System.Drawing.Size(346, 20);
            this.txtEjercicioLinkVideo.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(3, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Link del video:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Descripcion:";
            // 
            // txtEjercicioDescripcion
            // 
            this.txtEjercicioDescripcion.Location = new System.Drawing.Point(6, 59);
            this.txtEjercicioDescripcion.Multiline = true;
            this.txtEjercicioDescripcion.Name = "txtEjercicioDescripcion";
            this.txtEjercicioDescripcion.Size = new System.Drawing.Size(346, 92);
            this.txtEjercicioDescripcion.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ejercicio";
            // 
            // btnEjercicioAgregar
            // 
            this.btnEjercicioAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnEjercicioAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnEjercicioAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicioAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicioAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnEjercicioAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjercicioAgregar.Location = new System.Drawing.Point(0, 269);
            this.btnEjercicioAgregar.Name = "btnEjercicioAgregar";
            this.btnEjercicioAgregar.Size = new System.Drawing.Size(114, 47);
            this.btnEjercicioAgregar.TabIndex = 36;
            this.btnEjercicioAgregar.Text = "Agregar Ejercicio";
            this.btnEjercicioAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEjercicioModificar
            // 
            this.btnEjercicioModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnEjercicioModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnEjercicioModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicioModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicioModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnEjercicioModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjercicioModificar.Location = new System.Drawing.Point(122, 269);
            this.btnEjercicioModificar.Name = "btnEjercicioModificar";
            this.btnEjercicioModificar.Size = new System.Drawing.Size(114, 47);
            this.btnEjercicioModificar.TabIndex = 37;
            this.btnEjercicioModificar.Text = "Modificar Ejercicio";
            this.btnEjercicioModificar.UseVisualStyleBackColor = false;
            // 
            // btnEjercicioBorrar
            // 
            this.btnEjercicioBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnEjercicioBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnEjercicioBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicioBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicioBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnEjercicioBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjercicioBorrar.Location = new System.Drawing.Point(245, 269);
            this.btnEjercicioBorrar.Name = "btnEjercicioBorrar";
            this.btnEjercicioBorrar.Size = new System.Drawing.Size(114, 47);
            this.btnEjercicioBorrar.TabIndex = 38;
            this.btnEjercicioBorrar.Text = "Borrar Ejercicio";
            this.btnEjercicioBorrar.UseVisualStyleBackColor = false;
            // 
            // pnlDiaFormEjercicio
            // 
            this.pnlDiaFormEjercicio.Controls.Add(this.pnlDia);
            this.pnlDiaFormEjercicio.Controls.Add(this.btnEjercicioBorrar);
            this.pnlDiaFormEjercicio.Controls.Add(this.panel1);
            this.pnlDiaFormEjercicio.Controls.Add(this.btnEjercicioModificar);
            this.pnlDiaFormEjercicio.Controls.Add(this.btnEjercicioAgregar);
            this.pnlDiaFormEjercicio.Location = new System.Drawing.Point(351, 273);
            this.pnlDiaFormEjercicio.Name = "pnlDiaFormEjercicio";
            this.pnlDiaFormEjercicio.Size = new System.Drawing.Size(359, 330);
            this.pnlDiaFormEjercicio.TabIndex = 36;
            // 
            // RutinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1097, 615);
            this.Controls.Add(this.pnlDiaFormEjercicio);
            this.Controls.Add(this.pnlRutina);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RutinaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RutinaForm";
            this.Load += new System.EventHandler(this.RutinaForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlDia.ResumeLayout(false);
            this.pnlDia.PerformLayout();
            this.pnlRutina.ResumeLayout(false);
            this.pnlRutina.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDiaFormEjercicio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFiltrarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.Panel pnlDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRutina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRutinaObjetivo;
        private System.Windows.Forms.Button btnRutinaObjetivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEjercicioLinkVideo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEjercicioDescripcion;
        private System.Windows.Forms.Button btnEjercicioAgregar;
        private System.Windows.Forms.Button btnEjercicioModificar;
        private System.Windows.Forms.Button btnEjercicioBorrar;
        private System.Windows.Forms.Panel pnlDiaFormEjercicio;
    }
}