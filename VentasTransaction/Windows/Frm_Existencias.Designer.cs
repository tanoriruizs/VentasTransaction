﻿namespace VentasTransaction
{
    partial class Frm_Existencias
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 268);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(256, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(537, 271);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Existencias";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Frm_Existencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Name = "Frm_Existencias";
            this.Text = "Existencias";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}