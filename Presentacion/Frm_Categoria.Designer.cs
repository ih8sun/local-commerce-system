﻿namespace Presentacion
{
    partial class Frm_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Categoria));
            this.label8 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtconsultar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gdvCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 169;
            this.label8.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(107, 37);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(203, 20);
            this.txtcodigo.TabIndex = 168;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button4);
            this.GroupBox2.Controls.Add(this.Button5);
            this.GroupBox2.Controls.Add(this.Button3);
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.GroupBox2.Location = new System.Drawing.Point(21, 117);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(594, 100);
            this.GroupBox2.TabIndex = 166;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mantenimiento";
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // Button5
            // 
            this.Button5.ForeColor = System.Drawing.Color.Black;
            this.Button5.Image = ((System.Drawing.Image)(resources.GetObject("Button5.Image")));
            this.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button5.Location = new System.Drawing.Point(465, 29);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(100, 50);
            this.Button5.TabIndex = 3;
            this.Button5.Text = "Salir";
            this.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button3
            // 
            this.Button3.ForeColor = System.Drawing.Color.Black;
            this.Button3.Image = ((System.Drawing.Image)(resources.GetObject("Button3.Image")));
            this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button3.Location = new System.Drawing.Point(240, 29);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(113, 50);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "Modificar";
            this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.Location = new System.Drawing.Point(122, 29);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(113, 50);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Grabar";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.Location = new System.Drawing.Point(8, 29);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(113, 50);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Nuevo";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(107, 60);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(407, 20);
            this.txtdescripcion.TabIndex = 165;
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 164;
            this.Label1.Text = "Categoria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtestado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 95);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe de Categoria";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtconsultar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(21, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 76);
            this.groupBox3.TabIndex = 170;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar ";
            // 
            // txtconsultar
            // 
            this.txtconsultar.Location = new System.Drawing.Point(86, 32);
            this.txtconsultar.Name = "txtconsultar";
            this.txtconsultar.Size = new System.Drawing.Size(479, 20);
            this.txtconsultar.TabIndex = 138;
            this.txtconsultar.TextChanged += new System.EventHandler(this.txtconsultar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 138;
            this.label5.Text = "Categoria";
            // 
            // gdvCliente
            // 
            this.gdvCliente.AllowUserToAddRows = false;
            this.gdvCliente.BackgroundColor = System.Drawing.Color.White;
            this.gdvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCliente.Location = new System.Drawing.Point(21, 318);
            this.gdvCliente.Name = "gdvCliente";
            this.gdvCliente.ReadOnly = true;
            this.gdvCliente.Size = new System.Drawing.Size(594, 150);
            this.gdvCliente.TabIndex = 171;
            this.gdvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvCliente_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "Seleccionar";
            // 
            // Button4
            // 
            this.Button4.ForeColor = System.Drawing.Color.Black;
            this.Button4.Image = ((System.Drawing.Image)(resources.GetObject("Button4.Image")));
            this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button4.Location = new System.Drawing.Point(359, 29);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(98, 50);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "Estado";
            this.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 172;
            this.label3.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Enabled = false;
            this.txtestado.Location = new System.Drawing.Point(86, 70);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(203, 20);
            this.txtestado.TabIndex = 172;
            // 
            // Frm_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(630, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gdvCliente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Frm_Categoria_Load);
            this.GroupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtcodigo;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtdescripcion;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtconsultar;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gdvCliente;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.TextBox txtestado;
        internal System.Windows.Forms.Label label3;
    }
}