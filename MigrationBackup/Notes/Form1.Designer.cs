namespace Notes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newnote = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.notebox = new System.Windows.Forms.Label();
            this.remindtime = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.remind = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.insertnote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // newnote
            // 
            this.newnote.AutoSize = true;
            this.newnote.Location = new System.Drawing.Point(364, 9);
            this.newnote.Name = "newnote";
            this.newnote.Size = new System.Drawing.Size(55, 13);
            this.newnote.TabIndex = 1;
            this.newnote.Text = "New Note";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 98);
            this.textBox1.TabIndex = 2;
            // 
            // notebox
            // 
            this.notebox.AutoSize = true;
            this.notebox.Location = new System.Drawing.Point(364, 49);
            this.notebox.Name = "notebox";
            this.notebox.Size = new System.Drawing.Size(59, 13);
            this.notebox.TabIndex = 3;
            this.notebox.Text = "New Note*";
            // 
            // remindtime
            // 
            this.remindtime.AutoSize = true;
            this.remindtime.Location = new System.Drawing.Point(364, 166);
            this.remindtime.Name = "remindtime";
            this.remindtime.Size = new System.Drawing.Size(93, 13);
            this.remindtime.TabIndex = 4;
            this.remindtime.Text = "Time to remind me";
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(364, 208);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(147, 13);
            this.userlabel.TabIndex = 5;
            this.userlabel.Text = "For which person is this note?";
            // 
            // remind
            // 
            this.remind.Location = new System.Drawing.Point(364, 185);
            this.remind.Name = "remind";
            this.remind.Size = new System.Drawing.Size(216, 20);
            this.remind.TabIndex = 6;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(364, 224);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(216, 20);
            this.user.TabIndex = 7;
            // 
            // insertnote
            // 
            this.insertnote.Location = new System.Drawing.Point(365, 263);
            this.insertnote.Name = "insertnote";
            this.insertnote.Size = new System.Drawing.Size(75, 23);
            this.insertnote.TabIndex = 8;
            this.insertnote.Text = "Insert Note";
            this.insertnote.UseVisualStyleBackColor = true;
            this.insertnote.Click += new System.EventHandler(this.insertnote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.insertnote);
            this.Controls.Add(this.user);
            this.Controls.Add(this.remind);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.remindtime);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newnote);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label newnote;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label notebox;
        private System.Windows.Forms.Label remindtime;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.TextBox remind;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button insertnote;
    }
}

