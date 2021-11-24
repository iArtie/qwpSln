
namespace Pruebaxd.Formularios
{
    partial class FrmCalculo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ColumnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMontoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prestamo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaId,
            this.ColumnEstado,
            this.ColumnMonto,
            this.ColumnInteres,
            this.ColumnFechaDePago,
            this.ColumnFechaVence,
            this.ColumnMontoP});
            this.dataGridView1.Location = new System.Drawing.Point(28, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 225);
            this.dataGridView1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(99, 103);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(155, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Intereses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Terminos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ColumnaId
            // 
            this.ColumnaId.HeaderText = "ID";
            this.ColumnaId.MinimumWidth = 6;
            this.ColumnaId.Name = "ColumnaId";
            this.ColumnaId.Width = 125;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.MinimumWidth = 6;
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.Width = 125;
            // 
            // ColumnMonto
            // 
            this.ColumnMonto.HeaderText = "Monto del Prestamo";
            this.ColumnMonto.MinimumWidth = 6;
            this.ColumnMonto.Name = "ColumnMonto";
            this.ColumnMonto.Width = 125;
            // 
            // ColumnInteres
            // 
            this.ColumnInteres.HeaderText = "Interes";
            this.ColumnInteres.MinimumWidth = 6;
            this.ColumnInteres.Name = "ColumnInteres";
            this.ColumnInteres.Width = 125;
            // 
            // ColumnFechaDePago
            // 
            this.ColumnFechaDePago.HeaderText = "Fecha Pago";
            this.ColumnFechaDePago.MinimumWidth = 6;
            this.ColumnFechaDePago.Name = "ColumnFechaDePago";
            this.ColumnFechaDePago.Width = 125;
            // 
            // ColumnFechaVence
            // 
            this.ColumnFechaVence.HeaderText = "Fecha de Vencimiento";
            this.ColumnFechaVence.MinimumWidth = 6;
            this.ColumnFechaVence.Name = "ColumnFechaVence";
            this.ColumnFechaVence.Width = 125;
            // 
            // ColumnMontoP
            // 
            this.ColumnMontoP.HeaderText = "Monto por Pagar";
            this.ColumnMontoP.MinimumWidth = 6;
            this.ColumnMontoP.Name = "ColumnMontoP";
            this.ColumnMontoP.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(710, 520);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 73);
            this.button2.TabIndex = 0;
            this.button2.Text = "Busqueda por Estado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 73);
            this.button3.TabIndex = 1;
            this.button3.Text = "Busqueda por Total Principal";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 73);
            this.button4.TabIndex = 2;
            this.button4.Text = "Busqueda por Total de Interes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmCalculo";
            this.Text = "FrmCalculo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaVence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMontoP;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}