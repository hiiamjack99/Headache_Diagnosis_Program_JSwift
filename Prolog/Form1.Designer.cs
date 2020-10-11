namespace Prolog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbQuestion = new System.Windows.Forms.Label();
            this.btn_start = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pn_vungdau = new System.Windows.Forms.Panel();
            this.btn_Back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_reset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Next = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.pn_start = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_vungdau.SuspendLayout();
            this.pn_start.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(56, 32);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(524, 33);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Chương trình chuẩn đoán bệnh đau đầu";
            // 
            // btn_start
            // 
            this.btn_start.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_start.BackColor = System.Drawing.Color.Red;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.BorderRadius = 0;
            this.btn_start.ButtonText = "Bắt đầu";
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.DisabledColor = System.Drawing.Color.Gray;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_start.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_start.Iconimage")));
            this.btn_start.Iconimage_right = null;
            this.btn_start.Iconimage_right_Selected = null;
            this.btn_start.Iconimage_Selected = null;
            this.btn_start.IconMarginLeft = 0;
            this.btn_start.IconMarginRight = 0;
            this.btn_start.IconRightVisible = true;
            this.btn_start.IconRightZoom = 0D;
            this.btn_start.IconVisible = true;
            this.btn_start.IconZoom = 90D;
            this.btn_start.IsTab = false;
            this.btn_start.Location = new System.Drawing.Point(201, 230);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Normalcolor = System.Drawing.Color.Red;
            this.btn_start.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_start.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_start.selected = false;
            this.btn_start.Size = new System.Drawing.Size(136, 48);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Bắt đầu";
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.Textcolor = System.Drawing.Color.White;
            this.btn_start.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pn_vungdau
            // 
            this.pn_vungdau.Controls.Add(this.btn_Back);
            this.pn_vungdau.Controls.Add(this.btn_reset);
            this.pn_vungdau.Controls.Add(this.btn_Next);
            this.pn_vungdau.Controls.Add(this.rd3);
            this.pn_vungdau.Controls.Add(this.rd2);
            this.pn_vungdau.Controls.Add(this.rd1);
            this.pn_vungdau.Controls.Add(this.rd4);
            this.pn_vungdau.Location = new System.Drawing.Point(75, 86);
            this.pn_vungdau.Name = "pn_vungdau";
            this.pn_vungdau.Size = new System.Drawing.Size(527, 323);
            this.pn_vungdau.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.BorderRadius = 0;
            this.btn_Back.ButtonText = "Reset";
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Back.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Back.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Back.Iconimage")));
            this.btn_Back.Iconimage_right = null;
            this.btn_Back.Iconimage_right_Selected = null;
            this.btn_Back.Iconimage_Selected = null;
            this.btn_Back.IconMarginLeft = 0;
            this.btn_Back.IconMarginRight = 0;
            this.btn_Back.IconRightVisible = true;
            this.btn_Back.IconRightZoom = 0D;
            this.btn_Back.IconVisible = true;
            this.btn_Back.IconZoom = 90D;
            this.btn_Back.IsTab = false;
            this.btn_Back.Location = new System.Drawing.Point(61, 257);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Back.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Back.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Back.selected = false;
            this.btn_Back.Size = new System.Drawing.Size(100, 39);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Reset";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Textcolor = System.Drawing.Color.White;
            this.btn_Back.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reset.BorderRadius = 0;
            this.btn_reset.ButtonText = "Reset";
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.DisabledColor = System.Drawing.Color.Gray;
            this.btn_reset.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_reset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_reset.Iconimage")));
            this.btn_reset.Iconimage_right = null;
            this.btn_reset.Iconimage_right_Selected = null;
            this.btn_reset.Iconimage_Selected = null;
            this.btn_reset.IconMarginLeft = 0;
            this.btn_reset.IconMarginRight = 0;
            this.btn_reset.IconRightVisible = true;
            this.btn_reset.IconRightZoom = 0D;
            this.btn_reset.IconVisible = true;
            this.btn_reset.IconZoom = 90D;
            this.btn_reset.IsTab = false;
            this.btn_reset.Location = new System.Drawing.Point(202, 257);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_reset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_reset.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_reset.selected = false;
            this.btn_reset.Size = new System.Drawing.Size(100, 39);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Textcolor = System.Drawing.Color.White;
            this.btn_reset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Visible = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.BorderRadius = 0;
            this.btn_Next.ButtonText = "Next";
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Next.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Next.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Next.Iconimage")));
            this.btn_Next.Iconimage_right = null;
            this.btn_Next.Iconimage_right_Selected = null;
            this.btn_Next.Iconimage_Selected = null;
            this.btn_Next.IconMarginLeft = 0;
            this.btn_Next.IconMarginRight = 0;
            this.btn_Next.IconRightVisible = true;
            this.btn_Next.IconRightZoom = 0D;
            this.btn_Next.IconVisible = true;
            this.btn_Next.IconZoom = 90D;
            this.btn_Next.IsTab = false;
            this.btn_Next.Location = new System.Drawing.Point(337, 257);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Next.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Next.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Next.selected = false;
            this.btn_Next.Size = new System.Drawing.Size(100, 39);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Next.Textcolor = System.Drawing.Color.White;
            this.btn_Next.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3.Location = new System.Drawing.Point(106, 145);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(101, 20);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "radioButton1";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2.Location = new System.Drawing.Point(106, 109);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(101, 20);
            this.rd2.TabIndex = 1;
            this.rd2.TabStop = true;
            this.rd2.Text = "radioButton2";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1.Location = new System.Drawing.Point(106, 65);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(101, 20);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "radioButton1";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd4.Location = new System.Drawing.Point(106, 189);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(101, 20);
            this.rd4.TabIndex = 1;
            this.rd4.TabStop = true;
            this.rd4.Text = "radioButton2";
            this.rd4.UseVisualStyleBackColor = true;
            // 
            // pn_start
            // 
            this.pn_start.BackgroundImage = global::Prolog.Properties.Resources.Diagnosis;
            this.pn_start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_start.Controls.Add(this.btn_start);
            this.pn_start.Location = new System.Drawing.Point(51, 86);
            this.pn_start.Name = "pn_start";
            this.pn_start.Size = new System.Drawing.Size(551, 323);
            this.pn_start.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Copyright by Dinh Quoc Tuan - 2020";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GV: Do Trung Tuan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_start);
            this.Controls.Add(this.pn_vungdau);
            this.Controls.Add(this.lbQuestion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuẩn đoán bệnh đau đầu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn_vungdau.ResumeLayout(false);
            this.pn_vungdau.PerformLayout();
            this.pn_start.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_start;
        private System.Windows.Forms.Panel pn_vungdau;
        private System.Windows.Forms.Panel pn_start;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Back;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Next;
        private Bunifu.Framework.UI.BunifuFlatButton btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

