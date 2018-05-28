namespace databaseStudensStady2
{
    partial class Form1
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
            this.btnList = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.tbListStudents = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(426, 38);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(91, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "btnList";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(43, 236);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(43, 288);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(100, 20);
            this.tbDelete.TabIndex = 2;
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(183, 236);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(100, 20);
            this.tbGroup.TabIndex = 3;
            // 
            // tbListStudents
            // 
            this.tbListStudents.Location = new System.Drawing.Point(33, 40);
            this.tbListStudents.Multiline = true;
            this.tbListStudents.Name = "tbListStudents";
            this.tbListStudents.Size = new System.Drawing.Size(373, 110);
            this.tbListStudents.TabIndex = 4;
            this.tbListStudents.TextChanged += new System.EventHandler(this.tbListStudents_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(341, 285);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(65, 23);
            this.btnDelet.TabIndex = 6;
            this.btnDelet.Text = "btnDelet";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbListStudents);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.tbDelete);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDelete;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.TextBox tbListStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelet;
    }
}

