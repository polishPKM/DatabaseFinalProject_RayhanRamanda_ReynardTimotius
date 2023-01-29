
namespace InventoryManagementSystem
{
    partial class CustomerModuleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCname = new System.Windows.Forms.TextBox();
            this.textCphone = new System.Windows.Forms.TextBox();
            this.btnCustSave = new System.Windows.Forms.Button();
            this.btnCustUpd = new System.Windows.Forms.Button();
            this.btnCustClear = new System.Windows.Forms.Button();
            this.lbcstid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 125);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp2.Properties.Resources.close_window_30px;
            this.pictureBox1.Location = new System.Drawing.Point(675, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER MODULE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // textCname
            // 
            this.textCname.Location = new System.Drawing.Point(108, 162);
            this.textCname.Name = "textCname";
            this.textCname.Size = new System.Drawing.Size(175, 27);
            this.textCname.TabIndex = 3;
            // 
            // textCphone
            // 
            this.textCphone.Location = new System.Drawing.Point(108, 204);
            this.textCphone.Name = "textCphone";
            this.textCphone.Size = new System.Drawing.Size(175, 27);
            this.textCphone.TabIndex = 4;
            // 
            // btnCustSave
            // 
            this.btnCustSave.Location = new System.Drawing.Point(417, 365);
            this.btnCustSave.Name = "btnCustSave";
            this.btnCustSave.Size = new System.Drawing.Size(94, 29);
            this.btnCustSave.TabIndex = 5;
            this.btnCustSave.Text = "Save";
            this.btnCustSave.UseVisualStyleBackColor = true;
            this.btnCustSave.Click += new System.EventHandler(this.btnCustSave_Click);
            // 
            // btnCustUpd
            // 
            this.btnCustUpd.Location = new System.Drawing.Point(541, 364);
            this.btnCustUpd.Name = "btnCustUpd";
            this.btnCustUpd.Size = new System.Drawing.Size(94, 29);
            this.btnCustUpd.TabIndex = 6;
            this.btnCustUpd.Text = "Update";
            this.btnCustUpd.UseVisualStyleBackColor = true;
            this.btnCustUpd.Click += new System.EventHandler(this.btnCustUpd_Click);
            // 
            // btnCustClear
            // 
            this.btnCustClear.Location = new System.Drawing.Point(480, 399);
            this.btnCustClear.Name = "btnCustClear";
            this.btnCustClear.Size = new System.Drawing.Size(94, 29);
            this.btnCustClear.TabIndex = 7;
            this.btnCustClear.Text = "Clear";
            this.btnCustClear.UseVisualStyleBackColor = true;
            this.btnCustClear.Click += new System.EventHandler(this.btnCustClear_Click);
            // 
            // lbcstid
            // 
            this.lbcstid.AutoSize = true;
            this.lbcstid.Location = new System.Drawing.Point(12, 268);
            this.lbcstid.Name = "lbcstid";
            this.lbcstid.Size = new System.Drawing.Size(89, 20);
            this.lbcstid.TabIndex = 8;
            this.lbcstid.Text = "Customer Id";
            // 
            // CustomerModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbcstid);
            this.Controls.Add(this.btnCustClear);
            this.Controls.Add(this.btnCustUpd);
            this.Controls.Add(this.btnCustSave);
            this.Controls.Add(this.textCphone);
            this.Controls.Add(this.textCname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerModuleForm";
            this.Text = "CustomerModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textCname;
        public System.Windows.Forms.TextBox textCphone;
        public System.Windows.Forms.Button btnCustSave;
        public System.Windows.Forms.Button btnCustUpd;
        public System.Windows.Forms.Button btnCustClear;
        public System.Windows.Forms.Label lbcstid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}