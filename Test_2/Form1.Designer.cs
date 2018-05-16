namespace Test_2
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
            this.cbOne = new System.Windows.Forms.ComboBox();
            this.cbTwo = new System.Windows.Forms.ComboBox();
            this.tbOne = new System.Windows.Forms.TextBox();
            this.tbTwo = new System.Windows.Forms.TextBox();
            this.tbAnalize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbOne
            // 
            this.cbOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOne.FormattingEnabled = true;
            this.cbOne.Location = new System.Drawing.Point(205, 97);
            this.cbOne.Name = "cbOne";
            this.cbOne.Size = new System.Drawing.Size(121, 21);
            this.cbOne.TabIndex = 0;
            this.cbOne.SelectedIndexChanged += new System.EventHandler(this.cbOne_SelectedIndexChanged);
            // 
            // cbTwo
            // 
            this.cbTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTwo.FormattingEnabled = true;
            this.cbTwo.Location = new System.Drawing.Point(205, 157);
            this.cbTwo.Name = "cbTwo";
            this.cbTwo.Size = new System.Drawing.Size(121, 21);
            this.cbTwo.TabIndex = 1;
            this.cbTwo.SelectedIndexChanged += new System.EventHandler(this.cbTwo_SelectedIndexChanged);
            // 
            // tbOne
            // 
            this.tbOne.BackColor = System.Drawing.SystemColors.Window;
            this.tbOne.Location = new System.Drawing.Point(431, 100);
            this.tbOne.Name = "tbOne";
            this.tbOne.ReadOnly = true;
            this.tbOne.Size = new System.Drawing.Size(215, 20);
            this.tbOne.TabIndex = 2;
            // 
            // tbTwo
            // 
            this.tbTwo.BackColor = System.Drawing.SystemColors.Window;
            this.tbTwo.Location = new System.Drawing.Point(431, 157);
            this.tbTwo.Name = "tbTwo";
            this.tbTwo.ReadOnly = true;
            this.tbTwo.Size = new System.Drawing.Size(215, 20);
            this.tbTwo.TabIndex = 3;
            // 
            // tbAnalize
            // 
            this.tbAnalize.BackColor = System.Drawing.SystemColors.Window;
            this.tbAnalize.Location = new System.Drawing.Point(364, 230);
            this.tbAnalize.Name = "tbAnalize";
            this.tbAnalize.ReadOnly = true;
            this.tbAnalize.Size = new System.Drawing.Size(336, 20);
            this.tbAnalize.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите первое животное";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите второе животное";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(452, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вес второго животного:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(443, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вес первого животного:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(352, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Логический результат сравнения веса выбранных животных:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выберете единицы отображения веса";
            // 
            // cbUnit
            // 
            this.cbUnit.BackColor = System.Drawing.SystemColors.Window;
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(258, 35);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(68, 21);
            this.cbUnit.TabIndex = 12;
            this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.cbUnit_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAnalize);
            this.Controls.Add(this.tbTwo);
            this.Controls.Add(this.tbOne);
            this.Controls.Add(this.cbTwo);
            this.Controls.Add(this.cbOne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Программа сказочного издевательства над бедными животными";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOne;
        private System.Windows.Forms.ComboBox cbTwo;
        private System.Windows.Forms.TextBox tbTwo;
        private System.Windows.Forms.TextBox tbAnalize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox tbOne;
    }
}

