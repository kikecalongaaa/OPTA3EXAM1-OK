namespace ExamenP.forms
{
    partial class FRMCiudad
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boidcde = new System.Windows.Forms.TextBox();
            this.BoxCiudad = new System.Windows.Forms.TextBox();
            this.BOXdpto = new System.Windows.Forms.TextBox();
            this.BoxPOSTAL = new System.Windows.Forms.TextBox();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ciudad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Codigo Postal";
            // 
            // boidcde
            // 
            this.boidcde.BackColor = System.Drawing.Color.Cyan;
            this.boidcde.Enabled = false;
            this.boidcde.Location = new System.Drawing.Point(309, 40);
            this.boidcde.Name = "boidcde";
            this.boidcde.Size = new System.Drawing.Size(142, 22);
            this.boidcde.TabIndex = 4;
            this.boidcde.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BoxCiudad
            // 
            this.BoxCiudad.BackColor = System.Drawing.Color.Cyan;
            this.BoxCiudad.Enabled = false;
            this.BoxCiudad.Location = new System.Drawing.Point(309, 104);
            this.BoxCiudad.Name = "BoxCiudad";
            this.BoxCiudad.Size = new System.Drawing.Size(142, 22);
            this.BoxCiudad.TabIndex = 5;
            // 
            // BOXdpto
            // 
            this.BOXdpto.BackColor = System.Drawing.Color.Cyan;
            this.BOXdpto.Enabled = false;
            this.BOXdpto.Location = new System.Drawing.Point(309, 156);
            this.BOXdpto.Name = "BOXdpto";
            this.BOXdpto.Size = new System.Drawing.Size(144, 22);
            this.BOXdpto.TabIndex = 6;
            // 
            // BoxPOSTAL
            // 
            this.BoxPOSTAL.BackColor = System.Drawing.Color.Cyan;
            this.BoxPOSTAL.Enabled = false;
            this.BoxPOSTAL.Location = new System.Drawing.Point(309, 220);
            this.BoxPOSTAL.Name = "BoxPOSTAL";
            this.BoxPOSTAL.Size = new System.Drawing.Size(144, 22);
            this.BoxPOSTAL.TabIndex = 7;
            // 
            // btn_añadir
            // 
            this.btn_añadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_añadir.Location = new System.Drawing.Point(654, 12);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(138, 64);
            this.btn_añadir.TabIndex = 8;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = false;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_modificar.Location = new System.Drawing.Point(654, 82);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(138, 44);
            this.btn_modificar.TabIndex = 9;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_eliminar.Location = new System.Drawing.Point(654, 125);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(138, 53);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Guardar.Location = new System.Drawing.Point(654, 184);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(138, 43);
            this.btn_Guardar.TabIndex = 11;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Cancelar.Location = new System.Drawing.Point(654, 245);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(138, 48);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(40, 299);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(819, 151);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // FRMCiudad
            // 
            this.ClientSize = new System.Drawing.Size(902, 474);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.BoxPOSTAL);
            this.Controls.Add(this.BOXdpto);
            this.Controls.Add(this.BoxCiudad);
            this.Controls.Add(this.boidcde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FRMCiudad";
            this.Load += new System.EventHandler(this.FCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxID_Ciudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxCiudad_Ciudad;
        private System.Windows.Forms.TextBox BoxCodigoP_Ciudad;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boidcde;
        private System.Windows.Forms.TextBox BoxCiudad;
        private System.Windows.Forms.TextBox BOXdpto;
        private System.Windows.Forms.TextBox BoxPOSTAL;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}