namespace SimpleDataApp
{
    partial class Form2
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
            this.Encomendagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.updateproductbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.EncLinhagrid = new System.Windows.Forms.DataGridView();
            this.deleteenclinha = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelInsert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Encomendagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncLinhagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Encomendagrid
            // 
            this.Encomendagrid.AllowUserToOrderColumns = true;
            this.Encomendagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Encomendagrid.Location = new System.Drawing.Point(16, 15);
            this.Encomendagrid.Margin = new System.Windows.Forms.Padding(4);
            this.Encomendagrid.Name = "Encomendagrid";
            this.Encomendagrid.RowHeadersWidth = 51;
            this.Encomendagrid.Size = new System.Drawing.Size(567, 645);
            this.Encomendagrid.TabIndex = 0;
            this.Encomendagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Encomenda_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modo:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(726, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update db";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.udpdatedb);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(662, 632);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.cierra);
            // 
            // updateproductbutton
            // 
            this.updateproductbutton.Location = new System.Drawing.Point(726, 561);
            this.updateproductbutton.Margin = new System.Windows.Forms.Padding(4);
            this.updateproductbutton.Name = "updateproductbutton";
            this.updateproductbutton.Size = new System.Drawing.Size(100, 28);
            this.updateproductbutton.TabIndex = 15;
            this.updateproductbutton.Text = "Update";
            this.updateproductbutton.UseVisualStyleBackColor = true;
            this.updateproductbutton.Click += new System.EventHandler(this.updateproductbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 489);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "ProdutoID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 519);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantidade";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(726, 489);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(726, 516);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(591, 453);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "UPDATE";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "DELETE";
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(650, 347);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(4);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(100, 28);
            this.deletebutton.TabIndex = 14;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deleter);
            // 
            // Insertbutton
            // 
            this.Insertbutton.Location = new System.Drawing.Point(650, 87);
            this.Insertbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(100, 28);
            this.Insertbutton.TabIndex = 22;
            this.Insertbutton.Text = "Insert";
            this.Insertbutton.UseVisualStyleBackColor = true;
            this.Insertbutton.Click += new System.EventHandler(this.Inserir_Encomendas);
            // 
            // EncLinhagrid
            // 
            this.EncLinhagrid.AllowUserToOrderColumns = true;
            this.EncLinhagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EncLinhagrid.Location = new System.Drawing.Point(981, 15);
            this.EncLinhagrid.Margin = new System.Windows.Forms.Padding(4);
            this.EncLinhagrid.Name = "EncLinhagrid";
            this.EncLinhagrid.RowHeadersWidth = 51;
            this.EncLinhagrid.Size = new System.Drawing.Size(429, 645);
            this.EncLinhagrid.TabIndex = 23;
            this.EncLinhagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EncLinha_CellContentClick);
            // 
            // deleteenclinha
            // 
            this.deleteenclinha.Location = new System.Drawing.Point(838, 347);
            this.deleteenclinha.Margin = new System.Windows.Forms.Padding(4);
            this.deleteenclinha.Name = "deleteenclinha";
            this.deleteenclinha.Size = new System.Drawing.Size(100, 28);
            this.deleteenclinha.TabIndex = 24;
            this.deleteenclinha.Text = "Delete";
            this.deleteenclinha.UseVisualStyleBackColor = true;
            this.deleteenclinha.Click += new System.EventHandler(this.linedeleter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(838, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Inserir_linhas);
            // 
            // labelInsert
            // 
            this.labelInsert.AutoSize = true;
            this.labelInsert.Location = new System.Drawing.Point(597, 67);
            this.labelInsert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(57, 16);
            this.labelInsert.TabIndex = 26;
            this.labelInsert.Text = "INSERT";
            this.labelInsert.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 673);
            this.Controls.Add(this.labelInsert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteenclinha);
            this.Controls.Add(this.EncLinhagrid);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateproductbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Encomendagrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Encomendagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncLinhagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Encomendagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button updateproductbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button Insertbutton;
        private System.Windows.Forms.DataGridView EncLinhagrid;
        private System.Windows.Forms.Button deleteenclinha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelInsert;
    }
}