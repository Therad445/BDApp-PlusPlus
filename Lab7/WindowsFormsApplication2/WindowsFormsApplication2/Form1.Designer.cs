namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sotrudnik = new System.Windows.Forms.RadioButton();
            this.Postavshik = new System.Windows.Forms.RadioButton();
            this.Otdel = new System.Windows.Forms.RadioButton();
            this.Magazin = new System.Windows.Forms.RadioButton();
            this.Dogovor = new System.Windows.Forms.RadioButton();
            this.sysreq = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(833, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(725, 51);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(833, 51);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1525, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(459, 372);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пусто";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sotrudnik);
            this.groupBox1.Controls.Add(this.Postavshik);
            this.groupBox1.Controls.Add(this.Otdel);
            this.groupBox1.Controls.Add(this.Magazin);
            this.groupBox1.Controls.Add(this.Dogovor);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(526, 64);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Команды";
            // 
            // Sotrudnik
            // 
            this.Sotrudnik.AutoSize = true;
            this.Sotrudnik.Location = new System.Drawing.Point(430, 25);
            this.Sotrudnik.Margin = new System.Windows.Forms.Padding(4);
            this.Sotrudnik.Name = "Sotrudnik";
            this.Sotrudnik.Size = new System.Drawing.Size(85, 20);
            this.Sotrudnik.TabIndex = 4;
            this.Sotrudnik.TabStop = true;
            this.Sotrudnik.Text = "Пациент";
            this.Sotrudnik.UseVisualStyleBackColor = true;
            // 
            // Postavshik
            // 
            this.Postavshik.AutoSize = true;
            this.Postavshik.Location = new System.Drawing.Point(313, 25);
            this.Postavshik.Margin = new System.Windows.Forms.Padding(4);
            this.Postavshik.Name = "Postavshik";
            this.Postavshik.Size = new System.Drawing.Size(109, 20);
            this.Postavshik.TabIndex = 3;
            this.Postavshik.TabStop = true;
            this.Postavshik.Text = "Исполнение";
            this.Postavshik.UseVisualStyleBackColor = true;
            // 
            // Otdel
            // 
            this.Otdel.AutoSize = true;
            this.Otdel.Location = new System.Drawing.Point(178, 25);
            this.Otdel.Margin = new System.Windows.Forms.Padding(4);
            this.Otdel.Name = "Otdel";
            this.Otdel.Size = new System.Drawing.Size(127, 20);
            this.Otdel.TabIndex = 2;
            this.Otdel.TabStop = true;
            this.Otdel.Text = "Выход_техника";
            this.Otdel.UseVisualStyleBackColor = true;
            // 
            // Magazin
            // 
            this.Magazin.AutoSize = true;
            this.Magazin.Location = new System.Drawing.Point(92, 25);
            this.Magazin.Margin = new System.Windows.Forms.Padding(4);
            this.Magazin.Name = "Magazin";
            this.Magazin.Size = new System.Drawing.Size(78, 20);
            this.Magazin.TabIndex = 1;
            this.Magazin.TabStop = true;
            this.Magazin.Text = "Выдача";
            this.Magazin.UseVisualStyleBackColor = true;
            // 
            // Dogovor
            // 
            this.Dogovor.AutoSize = true;
            this.Dogovor.Location = new System.Drawing.Point(9, 25);
            this.Dogovor.Margin = new System.Windows.Forms.Padding(4);
            this.Dogovor.Name = "Dogovor";
            this.Dogovor.Size = new System.Drawing.Size(75, 20);
            this.Dogovor.TabIndex = 0;
            this.Dogovor.TabStop = true;
            this.Dogovor.Text = "Заявки";
            this.Dogovor.UseVisualStyleBackColor = true;
            // 
            // sysreq
            // 
            this.sysreq.Location = new System.Drawing.Point(1525, 407);
            this.sysreq.Margin = new System.Windows.Forms.Padding(4);
            this.sysreq.Name = "sysreq";
            this.sysreq.Size = new System.Drawing.Size(100, 28);
            this.sysreq.TabIndex = 13;
            this.sysreq.Text = "sysreq";
            this.sysreq.UseVisualStyleBackColor = true;
            this.sysreq.Click += new System.EventHandler(this.sysreq_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(931, 373);
            this.dataGridView1.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1695, 405);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 15;
            this.button6.Text = "get";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 642);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sysreq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Sotrudnik;
        private System.Windows.Forms.RadioButton Postavshik;
        private System.Windows.Forms.RadioButton Otdel;
        private System.Windows.Forms.RadioButton Magazin;
        private System.Windows.Forms.RadioButton Dogovor;
        private System.Windows.Forms.Button sysreq;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

