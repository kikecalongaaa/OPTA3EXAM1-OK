namespace ExamenP.forms
{
    partial class FRMPersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boxnom = new System.Windows.Forms.TextBox();
            this.boxape = new System.Windows.Forms.TextBox();
            this.boxNrodedoc = new System.Windows.Forms.TextBox();
            this.BoxTipodeDoc = new System.Windows.Forms.TextBox();
            this.boxdireccion = new System.Windows.Forms.TextBox();
            this.BoxCelTel = new System.Windows.Forms.TextBox();
            this.BoxCorreo = new System.Windows.Forms.TextBox();
            this.BoxEstado = new System.Windows.Forms.TextBox();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro de Doc.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Doc";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(737, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(737, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cel o Tel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(738, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 31);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(187, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 9;
            // 
            // boxnom
            // 
            this.boxnom.BackColor = System.Drawing.Color.Yellow;
            this.boxnom.Enabled = false;
            this.boxnom.ForeColor = System.Drawing.SystemColors.Window;
            this.boxnom.Location = new System.Drawing.Point(187, 91);
            this.boxnom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxnom.Name = "boxnom";
            this.boxnom.Size = new System.Drawing.Size(132, 22);
            this.boxnom.TabIndex = 10;
            // 
            // boxape
            // 
            this.boxape.BackColor = System.Drawing.Color.Yellow;
            this.boxape.Enabled = false;
            this.boxape.ForeColor = System.Drawing.SystemColors.Window;
            this.boxape.Location = new System.Drawing.Point(187, 150);
            this.boxape.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxape.Name = "boxape";
            this.boxape.Size = new System.Drawing.Size(132, 22);
            this.boxape.TabIndex = 11;
            // 
            // boxNrodedoc
            // 
            this.boxNrodedoc.BackColor = System.Drawing.Color.Yellow;
            this.boxNrodedoc.Enabled = false;
            this.boxNrodedoc.Location = new System.Drawing.Point(548, 38);
            this.boxNrodedoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxNrodedoc.Name = "boxNrodedoc";
            this.boxNrodedoc.Size = new System.Drawing.Size(132, 22);
            this.boxNrodedoc.TabIndex = 12;
            // 
            // BoxTipodeDoc
            // 
            this.BoxTipodeDoc.BackColor = System.Drawing.Color.Yellow;
            this.BoxTipodeDoc.Enabled = false;
            this.BoxTipodeDoc.Location = new System.Drawing.Point(548, 97);
            this.BoxTipodeDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxTipodeDoc.Name = "BoxTipodeDoc";
            this.BoxTipodeDoc.Size = new System.Drawing.Size(132, 22);
            this.BoxTipodeDoc.TabIndex = 13;
            // 
            // boxdireccion
            // 
            this.boxdireccion.BackColor = System.Drawing.Color.Yellow;
            this.boxdireccion.Enabled = false;
            this.boxdireccion.Location = new System.Drawing.Point(548, 149);
            this.boxdireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxdireccion.Name = "boxdireccion";
            this.boxdireccion.Size = new System.Drawing.Size(132, 22);
            this.boxdireccion.TabIndex = 14;
            // 
            // BoxCelTel
            // 
            this.BoxCelTel.BackColor = System.Drawing.Color.Yellow;
            this.BoxCelTel.Enabled = false;
            this.BoxCelTel.Location = new System.Drawing.Point(876, 44);
            this.BoxCelTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxCelTel.Name = "BoxCelTel";
            this.BoxCelTel.Size = new System.Drawing.Size(132, 22);
            this.BoxCelTel.TabIndex = 15;
            // 
            // BoxCorreo
            // 
            this.BoxCorreo.BackColor = System.Drawing.Color.Yellow;
            this.BoxCorreo.Enabled = false;
            this.BoxCorreo.Location = new System.Drawing.Point(876, 98);
            this.BoxCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxCorreo.Name = "BoxCorreo";
            this.BoxCorreo.Size = new System.Drawing.Size(132, 22);
            this.BoxCorreo.TabIndex = 16;
            // 
            // BoxEstado
            // 
            this.BoxEstado.BackColor = System.Drawing.Color.Yellow;
            this.BoxEstado.Enabled = false;
            this.BoxEstado.Location = new System.Drawing.Point(876, 148);
            this.BoxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxEstado.Name = "BoxEstado";
            this.BoxEstado.Size = new System.Drawing.Size(132, 22);
            this.BoxEstado.TabIndex = 17;
            // 
            // btn_añadir
            // 
            this.btn_añadir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_añadir.Location = new System.Drawing.Point(53, 243);
            this.btn_añadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(100, 28);
            this.btn_añadir.TabIndex = 18;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = false;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_modificar.Location = new System.Drawing.Point(236, 243);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 28);
            this.btn_modificar.TabIndex = 19;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_eliminar.Location = new System.Drawing.Point(447, 243);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 28);
            this.btn_eliminar.TabIndex = 20;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_guardar.Location = new System.Drawing.Point(684, 243);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 34);
            this.btn_guardar.TabIndex = 21;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancelar.Location = new System.Drawing.Point(880, 243);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 34);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 308);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(927, 233);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FRMPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.BoxEstado);
            this.Controls.Add(this.BoxCorreo);
            this.Controls.Add(this.BoxCelTel);
            this.Controls.Add(this.boxdireccion);
            this.Controls.Add(this.BoxTipodeDoc);
            this.Controls.Add(this.boxNrodedoc);
            this.Controls.Add(this.boxape);
            this.Controls.Add(this.boxnom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMPersona";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.FPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox boxnom;
        private System.Windows.Forms.TextBox boxape;
        private System.Windows.Forms.TextBox boxNrodedoc;
        private System.Windows.Forms.TextBox BoxTipodeDoc;
        private System.Windows.Forms.TextBox boxdireccion;
        private System.Windows.Forms.TextBox BoxCelTel;
        private System.Windows.Forms.TextBox BoxCorreo;
        private System.Windows.Forms.TextBox BoxEstado;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}