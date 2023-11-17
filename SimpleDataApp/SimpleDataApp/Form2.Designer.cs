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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.InserirBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.SendDataBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ClienteId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // InserirBtn
            // 
            this.InserirBtn.Location = new System.Drawing.Point(112, 220);
            this.InserirBtn.Name = "InserirBtn";
            this.InserirBtn.Size = new System.Drawing.Size(75, 23);
            this.InserirBtn.TabIndex = 8;
            this.InserirBtn.Text = "Insert";
            this.InserirBtn.UseVisualStyleBackColor = true;
            this.InserirBtn.Click += new System.EventHandler(this.InserirBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(849, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "INSERT";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(359, 166);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "EncId";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(346, 87);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(346, 129);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "UPDATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DELETE";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(602, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(519, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID encomenda";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(615, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Inserir novo registo de uma encomenda";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 39);
            this.label12.TabIndex = 23;
            this.label12.Text = "Selecione a linha que pertende \r\nalterar com o cursor e coloque o\r\nnovo valor no " +
    "campo \"Total\"";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Remover encomenda do registo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "EncId";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 27;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(804, 44);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 28;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // SendDataBtn
            // 
            this.SendDataBtn.Location = new System.Drawing.Point(849, 94);
            this.SendDataBtn.Name = "SendDataBtn";
            this.SendDataBtn.Size = new System.Drawing.Size(75, 55);
            this.SendDataBtn.TabIndex = 29;
            this.SendDataBtn.Text = "REFRESH\r\nand\r\nUPDATE";
            this.SendDataBtn.UseVisualStyleBackColor = true;
            this.SendDataBtn.Click += new System.EventHandler(this.SendDataBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 570);
            this.Controls.Add(this.SendDataBtn);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.InserirBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button InserirBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button SendDataBtn;
    }
}