namespace WindowsFormsApplication2
{
    partial class RSA_LuongThiThuongThuong
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
            this.btnSinhPQ = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPri = new System.Windows.Forms.Button();
            this.btnPub = new System.Windows.Forms.Button();
            this.btnMa = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBanMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBanRo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_N = new System.Windows.Forms.TextBox();
            this.bntGiaiMa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSinhPQ
            // 
            this.btnSinhPQ.Location = new System.Drawing.Point(12, 12);
            this.btnSinhPQ.Name = "btnSinhPQ";
            this.btnSinhPQ.Size = new System.Drawing.Size(151, 25);
            this.btnSinhPQ.TabIndex = 0;
            this.btnSinhPQ.Text = "Sinh cặp khóa bất đối xứng";
            this.btnSinhPQ.UseVisualStyleBackColor = true;
            this.btnSinhPQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(22, 163);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(398, 20);
            this.txtP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập văn bản cần mã hóa";
            // 
            // btnPri
            // 
            this.btnPri.Location = new System.Drawing.Point(430, 298);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(113, 23);
            this.btnPri.TabIndex = 3;
            this.btnPri.Text = "Tạo khóa riêng";
            this.btnPri.UseVisualStyleBackColor = true;
            this.btnPri.Click += new System.EventHandler(this.btnPri_Click);
            // 
            // btnPub
            // 
            this.btnPub.Location = new System.Drawing.Point(430, 101);
            this.btnPub.Name = "btnPub";
            this.btnPub.Size = new System.Drawing.Size(113, 24);
            this.btnPub.TabIndex = 4;
            this.btnPub.Text = "Tạo khóa công khai";
            this.btnPub.UseVisualStyleBackColor = true;
            this.btnPub.Click += new System.EventHandler(this.btnPub_Click);
            // 
            // btnMa
            // 
            this.btnMa.Location = new System.Drawing.Point(430, 163);
            this.btnMa.Name = "btnMa";
            this.btnMa.Size = new System.Drawing.Size(58, 23);
            this.btnMa.TabIndex = 5;
            this.btnMa.Text = "Mã hóa";
            this.btnMa.UseVisualStyleBackColor = true;
            this.btnMa.Click += new System.EventHandler(this.btnMa_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(54, 72);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(366, 20);
            this.txtN.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập khóa công khai";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(54, 105);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(366, 20);
            this.txtE.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số e";
            // 
            // txtBanMa
            // 
            this.txtBanMa.Location = new System.Drawing.Point(22, 206);
            this.txtBanMa.Name = "txtBanMa";
            this.txtBanMa.Size = new System.Drawing.Size(398, 20);
            this.txtBanMa.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kết quả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kết quả";
            // 
            // txtBanRo
            // 
            this.txtBanRo.Location = new System.Drawing.Point(25, 406);
            this.txtBanRo.Name = "txtBanRo";
            this.txtBanRo.Size = new System.Drawing.Size(395, 20);
            this.txtBanRo.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Số d";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 279);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 20;
            this.label.Text = "Số n";
            this.label.Click += new System.EventHandler(this.txtN1_Click);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(57, 305);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(363, 20);
            this.txtD.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nhập khóa bí mật";
            // 
            // txt_N
            // 
            this.txt_N.Location = new System.Drawing.Point(57, 272);
            this.txt_N.Name = "txt_N";
            this.txt_N.Size = new System.Drawing.Size(363, 20);
            this.txt_N.TabIndex = 17;
            // 
            // bntGiaiMa
            // 
            this.bntGiaiMa.Location = new System.Drawing.Point(430, 360);
            this.bntGiaiMa.Name = "bntGiaiMa";
            this.bntGiaiMa.Size = new System.Drawing.Size(58, 23);
            this.bntGiaiMa.TabIndex = 16;
            this.bntGiaiMa.Text = "Giải mã";
            this.bntGiaiMa.UseVisualStyleBackColor = true;
            this.bntGiaiMa.Click += new System.EventHandler(this.bntGiaiMa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nhập văn bản cần giải mã";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(25, 363);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(395, 20);
            this.txtC.TabIndex = 13;
            // 
            // RSA_LuongThiThuongThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBanRo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_N);
            this.Controls.Add(this.bntGiaiMa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBanMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnMa);
            this.Controls.Add(this.btnPub);
            this.Controls.Add(this.btnPri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.btnSinhPQ);
            this.Name = "RSA_LuongThiThuongThuong";
            this.Text = "RSA_LuongThiThuongThuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinhPQ;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPri;
        private System.Windows.Forms.Button btnPub;
        private System.Windows.Forms.Button btnMa;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBanMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBanRo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_N;
        private System.Windows.Forms.Button bntGiaiMa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtC;
    }
}

