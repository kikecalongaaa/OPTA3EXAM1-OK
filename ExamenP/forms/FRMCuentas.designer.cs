namespace ExamenP.forms
{
    partial class FRMCuentas
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
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GRIDCUENTA = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.BOXCUENTA = new System.Windows.Forms.TextBox();
            this.BOXFECHAALTA = new System.Windows.Forms.TextBox();
            this.boxtipcuent = new System.Windows.Forms.TextBox();
            this.boxestado = new System.Windows.Forms.TextBox();
            this.boxsaldo = new System.Windows.Forms.TextBox();
            this.Boxnrocuenta = new System.Windows.Forms.TextBox();
            this.boxnrocontrato = new System.Windows.Forms.TextBox();
            this.boxcosto = new System.Windows.Forms.TextBox();
            this.boxprom = new System.Windows.Forms.TextBox();
            this.boxmoneda = new System.Windows.Forms.TextBox();
            this.boxestado1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDCUENTA)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ID.Location = new System.Drawing.Point(12, 18);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(31, 25);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro de cuenta";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha alta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nro de cuenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Costo Mantenimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(12, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Promedio acreditacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(12, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Moneda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(12, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nro contrato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(12, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estado1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(11, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tipo cuenta";
            // 
            // GRIDCUENTA
            // 
            this.GRIDCUENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDCUENTA.Location = new System.Drawing.Point(421, 18);
            this.GRIDCUENTA.Name = "GRIDCUENTA";
            this.GRIDCUENTA.Size = new System.Drawing.Size(352, 333);
            this.GRIDCUENTA.TabIndex = 12;
            this.GRIDCUENTA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(687, 511);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 42);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_guardar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(562, 511);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 42);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(427, 511);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(94, 42);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_modificar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(270, 511);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(89, 42);
            this.btn_modificar.TabIndex = 17;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_añadir
            // 
            this.btn_añadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_añadir.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir.Location = new System.Drawing.Point(127, 511);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(90, 42);
            this.btn_añadir.TabIndex = 16;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = false;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // BOXCUENTA
            // 
            this.BOXCUENTA.Enabled = false;
            this.BOXCUENTA.Location = new System.Drawing.Point(181, 60);
            this.BOXCUENTA.Name = "BOXCUENTA";
            this.BOXCUENTA.Size = new System.Drawing.Size(212, 20);
            this.BOXCUENTA.TabIndex = 21;
            this.BOXCUENTA.TextChanged += new System.EventHandler(this.BOXCUENTA_TextChanged);
            // 
            // BOXFECHAALTA
            // 
            this.BOXFECHAALTA.Enabled = false;
            this.BOXFECHAALTA.Location = new System.Drawing.Point(181, 94);
            this.BOXFECHAALTA.Name = "BOXFECHAALTA";
            this.BOXFECHAALTA.Size = new System.Drawing.Size(212, 20);
            this.BOXFECHAALTA.TabIndex = 22;
            // 
            // boxtipcuent
            // 
            this.boxtipcuent.Enabled = false;
            this.boxtipcuent.Location = new System.Drawing.Point(181, 123);
            this.boxtipcuent.Name = "boxtipcuent";
            this.boxtipcuent.Size = new System.Drawing.Size(212, 20);
            this.boxtipcuent.TabIndex = 23;
            // 
            // boxestado
            // 
            this.boxestado.Enabled = false;
            this.boxestado.Location = new System.Drawing.Point(181, 153);
            this.boxestado.Name = "boxestado";
            this.boxestado.Size = new System.Drawing.Size(212, 20);
            this.boxestado.TabIndex = 24;
            // 
            // boxsaldo
            // 
            this.boxsaldo.Enabled = false;
            this.boxsaldo.Location = new System.Drawing.Point(181, 189);
            this.boxsaldo.Name = "boxsaldo";
            this.boxsaldo.Size = new System.Drawing.Size(212, 20);
            this.boxsaldo.TabIndex = 25;
            this.boxsaldo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Boxnrocuenta
            // 
            this.Boxnrocuenta.Enabled = false;
            this.Boxnrocuenta.Location = new System.Drawing.Point(181, 225);
            this.Boxnrocuenta.Name = "Boxnrocuenta";
            this.Boxnrocuenta.Size = new System.Drawing.Size(212, 20);
            this.Boxnrocuenta.TabIndex = 26;
            // 
            // boxnrocontrato
            // 
            this.boxnrocontrato.Enabled = false;
            this.boxnrocontrato.Location = new System.Drawing.Point(181, 259);
            this.boxnrocontrato.Name = "boxnrocontrato";
            this.boxnrocontrato.Size = new System.Drawing.Size(212, 20);
            this.boxnrocontrato.TabIndex = 27;
            // 
            // boxcosto
            // 
            this.boxcosto.Enabled = false;
            this.boxcosto.Location = new System.Drawing.Point(215, 295);
            this.boxcosto.Name = "boxcosto";
            this.boxcosto.Size = new System.Drawing.Size(178, 20);
            this.boxcosto.TabIndex = 28;
            // 
            // boxprom
            // 
            this.boxprom.Enabled = false;
            this.boxprom.Location = new System.Drawing.Point(215, 331);
            this.boxprom.Name = "boxprom";
            this.boxprom.Size = new System.Drawing.Size(178, 20);
            this.boxprom.TabIndex = 29;
            // 
            // boxmoneda
            // 
            this.boxmoneda.Enabled = false;
            this.boxmoneda.Location = new System.Drawing.Point(181, 363);
            this.boxmoneda.Name = "boxmoneda";
            this.boxmoneda.Size = new System.Drawing.Size(212, 20);
            this.boxmoneda.TabIndex = 30;
            // 
            // boxestado1
            // 
            this.boxestado1.Enabled = false;
            this.boxestado1.Location = new System.Drawing.Point(181, 393);
            this.boxestado1.Name = "boxestado1";
            this.boxestado1.Size = new System.Drawing.Size(212, 20);
            this.boxestado1.TabIndex = 31;
            // 
            // FCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 576);
            this.Controls.Add(this.boxestado1);
            this.Controls.Add(this.boxmoneda);
            this.Controls.Add(this.boxprom);
            this.Controls.Add(this.boxcosto);
            this.Controls.Add(this.boxnrocontrato);
            this.Controls.Add(this.Boxnrocuenta);
            this.Controls.Add(this.boxsaldo);
            this.Controls.Add(this.boxestado);
            this.Controls.Add(this.boxtipcuent);
            this.Controls.Add(this.BOXFECHAALTA);
            this.Controls.Add(this.BOXCUENTA);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.GRIDCUENTA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "FCuentas";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDCUENTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView GRIDCUENTA;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.TextBox BOXCUENTA;
        private System.Windows.Forms.TextBox BOXFECHAALTA;
        private System.Windows.Forms.TextBox boxtipcuent;
        private System.Windows.Forms.TextBox boxestado;
        private System.Windows.Forms.TextBox boxsaldo;
        private System.Windows.Forms.TextBox Boxnrocuenta;
        private System.Windows.Forms.TextBox boxnrocontrato;
        private System.Windows.Forms.TextBox boxcosto;
        private System.Windows.Forms.TextBox boxprom;
        private System.Windows.Forms.TextBox boxmoneda;
        private System.Windows.Forms.TextBox boxestado1;
    }
}