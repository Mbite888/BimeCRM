namespace BimeCRM
{
    partial class FirstPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.AddressTx = new System.Windows.Forms.TextBox();
            this.browseBt = new System.Windows.Forms.Button();
            this.nextBt = new System.Windows.Forms.Button();
            this.WrongAddressLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("B Titr", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(390, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "دیتا بیس مورد نظر یافت نشد لطفا آن را در سیستم مشخص کنید";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(319, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(89, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "آدرس :";
            // 
            // AddressTx
            // 
            this.AddressTx.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressTx.Location = new System.Drawing.Point(13, 54);
            this.AddressTx.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTx.Name = "AddressTx";
            this.AddressTx.Size = new System.Drawing.Size(309, 28);
            this.AddressTx.TabIndex = 2;
            this.AddressTx.TextChanged += new System.EventHandler(this.AddressTx_TextChanged);
            // 
            // browseBt
            // 
            this.browseBt.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.browseBt.Location = new System.Drawing.Point(232, 127);
            this.browseBt.Margin = new System.Windows.Forms.Padding(4);
            this.browseBt.Name = "browseBt";
            this.browseBt.Size = new System.Drawing.Size(135, 44);
            this.browseBt.TabIndex = 3;
            this.browseBt.Text = "گشتن در سیستم";
            this.browseBt.UseVisualStyleBackColor = true;
            this.browseBt.Click += new System.EventHandler(this.browseBt_Click);
            // 
            // nextBt
            // 
            this.nextBt.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.nextBt.Location = new System.Drawing.Point(40, 127);
            this.nextBt.Margin = new System.Windows.Forms.Padding(4);
            this.nextBt.Name = "nextBt";
            this.nextBt.Size = new System.Drawing.Size(135, 44);
            this.nextBt.TabIndex = 4;
            this.nextBt.Text = "ادامه";
            this.nextBt.UseVisualStyleBackColor = true;
            this.nextBt.Click += new System.EventHandler(this.nextBt_Click);
            // 
            // WrongAddressLb
            // 
            this.WrongAddressLb.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.WrongAddressLb.ForeColor = System.Drawing.Color.Red;
            this.WrongAddressLb.Location = new System.Drawing.Point(53, 86);
            this.WrongAddressLb.Name = "WrongAddressLb";
            this.WrongAddressLb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WrongAddressLb.Size = new System.Drawing.Size(256, 27);
            this.WrongAddressLb.TabIndex = 5;
            this.WrongAddressLb.Text = "آدرس وارد شده اشتباه است...";
            this.WrongAddressLb.Visible = false;
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 200);
            this.Controls.Add(this.WrongAddressLb);
            this.Controls.Add(this.nextBt);
            this.Controls.Add(this.browseBt);
            this.Controls.Add(this.AddressTx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Titr", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اتصال به دیتابیس";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressTx;
        private System.Windows.Forms.Button browseBt;
        private System.Windows.Forms.Button nextBt;
        private System.Windows.Forms.Label WrongAddressLb;
    }
}

