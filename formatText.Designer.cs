namespace Bai16_FormatText
{
    partial class FormatText
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.GroupBox();
            
            this.lblLaptrinh = new System.Windows.Forms.TextBox();
            this.color.SuspendLayout();
            
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên:";
            // 
            // txtNhapten
            // 
            this.txtNhapten.Location = new System.Drawing.Point(111, 17);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(128, 20);
            this.txtNhapten.TabIndex = 1;
            
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radRed.Location = new System.Drawing.Point(29, 27);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(48, 17);
            this.radRed.TabIndex = 3;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(29, 60);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(59, 17);
            this.radGreen.TabIndex = 3;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(29, 95);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(50, 17);
            this.radBlue.TabIndex = 3;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(29, 130);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(57, 17);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.ForeColor = System.Drawing.Color.Blue;
            this.chkBold.Location = new System.Drawing.Point(26, 22);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(80, 17);
            this.chkBold.TabIndex = 5;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.ForeColor = System.Drawing.Color.Blue;
            this.chkItalic.Location = new System.Drawing.Point(26, 68);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(105, 17);
            this.chkItalic.TabIndex = 5;
            this.chkItalic.Text = "Nghiêng Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
           
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.ForeColor = System.Drawing.Color.Blue;
            this.chkGachChan.Location = new System.Drawing.Point(26, 122);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(89, 17);
            this.chkGachChan.TabIndex = 5;
            this.chkGachChan.Text = "Gạch Chân";
            this.chkGachChan.UseVisualStyleBackColor = true;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lập Trình Bởi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
           
            // 
            // color
            // 
            this.color.Controls.Add(this.radBlack);
            this.color.Controls.Add(this.radBlue);
            this.color.Controls.Add(this.radGreen);
            this.color.Controls.Add(this.radRed);
            this.color.Location = new System.Drawing.Point(1, 52);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(171, 185);
            this.color.TabIndex = 10;
            this.color.TabStop = false;
            this.color.Text = "groupBox1";
            // 
            // Font
            // 
            
            // 
            // lblLaptrinh
            // 
            this.lblLaptrinh.Location = new System.Drawing.Point(105, 286);
            this.lblLaptrinh.Name = "lblLaptrinh";
            this.lblLaptrinh.Size = new System.Drawing.Size(125, 20);
            this.lblLaptrinh.TabIndex = 12;
            // 
            // FormatText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 361);
            this.Controls.Add(this.lblLaptrinh);
            
            this.Controls.Add(this.color);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNhapten);
            this.Controls.Add(this.label1);
            this.Name = "FormatText";
            this.Text = "FormatText";
            this.Load += new System.EventHandler(this.FormatText_Load);
            this.color.ResumeLayout(false);
            this.color.PerformLayout();
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapten;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox color;
        private System.Windows.Forms.TextBox lblLaptrinh;
    }
}