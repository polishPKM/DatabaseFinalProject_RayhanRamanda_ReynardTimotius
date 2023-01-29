
namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.prdctButton = new System.Windows.Forms.PictureBox();
            this.cstmrButton = new System.Windows.Forms.PictureBox();
            this.catgButton = new System.Windows.Forms.PictureBox();
            this.ordrButton = new System.Windows.Forms.PictureBox();
            this.usrButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.prdctButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cstmrButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catgButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordrButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prdctButton
            // 
            this.prdctButton.Image = ((System.Drawing.Image)(resources.GetObject("prdctButton.Image")));
            this.prdctButton.Location = new System.Drawing.Point(204, 12);
            this.prdctButton.Name = "prdctButton";
            this.prdctButton.Size = new System.Drawing.Size(52, 62);
            this.prdctButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prdctButton.TabIndex = 3;
            this.prdctButton.TabStop = false;
            this.prdctButton.Click += new System.EventHandler(this.prdctButton_Click);
            // 
            // cstmrButton
            // 
            this.cstmrButton.Image = ((System.Drawing.Image)(resources.GetObject("cstmrButton.Image")));
            this.cstmrButton.Location = new System.Drawing.Point(299, 12);
            this.cstmrButton.Name = "cstmrButton";
            this.cstmrButton.Size = new System.Drawing.Size(53, 62);
            this.cstmrButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cstmrButton.TabIndex = 4;
            this.cstmrButton.TabStop = false;
            this.cstmrButton.Click += new System.EventHandler(this.cstmrButton_Click);
            // 
            // catgButton
            // 
            this.catgButton.Image = ((System.Drawing.Image)(resources.GetObject("catgButton.Image")));
            this.catgButton.Location = new System.Drawing.Point(8, 12);
            this.catgButton.Name = "catgButton";
            this.catgButton.Size = new System.Drawing.Size(51, 62);
            this.catgButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catgButton.TabIndex = 5;
            this.catgButton.TabStop = false;
            this.catgButton.Click += new System.EventHandler(this.catgButton_Click);
            // 
            // ordrButton
            // 
            this.ordrButton.Image = ((System.Drawing.Image)(resources.GetObject("ordrButton.Image")));
            this.ordrButton.Location = new System.Drawing.Point(391, 12);
            this.ordrButton.Name = "ordrButton";
            this.ordrButton.Size = new System.Drawing.Size(51, 62);
            this.ordrButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ordrButton.TabIndex = 6;
            this.ordrButton.TabStop = false;
            this.ordrButton.Click += new System.EventHandler(this.ordrButton_Click);
            // 
            // usrButton
            // 
            this.usrButton.Image = ((System.Drawing.Image)(resources.GetObject("usrButton.Image")));
            this.usrButton.Location = new System.Drawing.Point(104, 6);
            this.usrButton.Name = "usrButton";
            this.usrButton.Size = new System.Drawing.Size(52, 68);
            this.usrButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usrButton.TabIndex = 11;
            this.usrButton.TabStop = false;
            this.usrButton.Click += new System.EventHandler(this.usrButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usrButton);
            this.panel1.Controls.Add(this.ordrButton);
            this.panel1.Controls.Add(this.catgButton);
            this.panel1.Controls.Add(this.prdctButton);
            this.panel1.Controls.Add(this.cstmrButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 125);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Categories";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(548, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "2D6 WARGAME INVENTORY MANAGEMENT SYSTEM";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 125);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(798, 490);
            this.panelMain.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 615);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.prdctButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cstmrButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catgButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordrButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox prdctButton;
        private System.Windows.Forms.PictureBox cstmrButton;
        private System.Windows.Forms.PictureBox catgButton;
        private System.Windows.Forms.PictureBox ordrButton;
        private System.Windows.Forms.PictureBox usrButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}