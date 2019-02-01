namespace WindowsFormsApp1
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblNameprompt = new System.Windows.Forms.Label();
            this.tbAccept = new System.Windows.Forms.TextBox();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(197, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(240, 21);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "My First Winform Application ";
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNameprompt
            // 
            this.lblNameprompt.AutoSize = true;
            this.lblNameprompt.BackColor = System.Drawing.Color.Transparent;
            this.lblNameprompt.Location = new System.Drawing.Point(12, 101);
            this.lblNameprompt.Name = "lblNameprompt";
            this.lblNameprompt.Size = new System.Drawing.Size(126, 13);
            this.lblNameprompt.TabIndex = 1;
            this.lblNameprompt.Text = "Please enter first number ";
            this.lblNameprompt.Click += new System.EventHandler(this.lblNameprompt_Click);
            // 
            // tbAccept
            // 
            this.tbAccept.Location = new System.Drawing.Point(164, 98);
            this.tbAccept.Name = "tbAccept";
            this.tbAccept.Size = new System.Drawing.Size(153, 20);
            this.tbAccept.TabIndex = 2;
            this.tbAccept.TextChanged += new System.EventHandler(this.tbAccept_TextChanged);
            // 
            // BtSubmit
            // 
            this.BtSubmit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtSubmit.Location = new System.Drawing.Point(118, 396);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtSubmit.TabIndex = 3;
            this.BtSubmit.Text = "Submit";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter second number ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.tbAccept_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._36874_Take_Me_Away;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 474);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNameprompt);
            this.Controls.Add(this.lblHeader);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "My First Winform App ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblNameprompt;
        private System.Windows.Forms.TextBox tbAccept;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

