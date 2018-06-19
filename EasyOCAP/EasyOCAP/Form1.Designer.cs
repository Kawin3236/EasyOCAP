namespace EasyOCAP
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorCase = new System.Windows.Forms.ComboBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCh1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 329);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(66, 20);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(491, 418);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(245, 20);
            this.txtOutput.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(354, 415);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorCase
            // 
            this.errorCase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorCase.FormattingEnabled = true;
            this.errorCase.Items.AddRange(new object[] {
            "Null",
            "Kicker",
            "Can\'t Open Tray"});
            this.errorCase.Location = new System.Drawing.Point(115, 27);
            this.errorCase.Name = "errorCase";
            this.errorCase.Size = new System.Drawing.Size(121, 21);
            this.errorCase.TabIndex = 4;
            this.errorCase.Text = "- Select error case -";
            this.errorCase.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox.Location = new System.Drawing.Point(12, 54);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(605, 269);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkBox1.Location = new System.Drawing.Point(652, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(43, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.TabStop = true;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkBox2.Location = new System.Drawing.Point(730, 98);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(39, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.TabStop = true;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Error case :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(164, 329);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(353, 20);
            this.txtComment.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Comment :";
            // 
            // labelCh1
            // 
            this.labelCh1.AutoSize = true;
            this.labelCh1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelCh1.Location = new System.Drawing.Point(624, 100);
            this.labelCh1.Name = "labelCh1";
            this.labelCh1.Size = new System.Drawing.Size(152, 13);
            this.labelCh1.TabIndex = 11;
            this.labelCh1.Text = "sssssssssssssssssssssssssssss";
            this.labelCh1.Click += new System.EventHandler(this.labelCh1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCh1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.errorCase);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Easy OCAP ver.1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox errorCase;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.RadioButton checkBox1;
        private System.Windows.Forms.RadioButton checkBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCh1;
    }
}

