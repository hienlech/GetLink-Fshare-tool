namespace Get_Link_Fshare
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxLink = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonDownLoad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CheckBoxDownLoad = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 85);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Fshare Link :";
            // 
            // textBoxLink
            // 
            this.textBoxLink.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLink.Depth = 0;
            this.textBoxLink.Hint = "";
            this.textBoxLink.Location = new System.Drawing.Point(12, 113);
            this.textBoxLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.PasswordChar = '\0';
            this.textBoxLink.SelectedText = "";
            this.textBoxLink.SelectionLength = 0;
            this.textBoxLink.SelectionStart = 0;
            this.textBoxLink.Size = new System.Drawing.Size(456, 28);
            this.textBoxLink.TabIndex = 1;
            this.textBoxLink.Text = "File Link...";
            this.textBoxLink.UseSystemPasswordChar = false;
            this.textBoxLink.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(489, 113);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(114, 28);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Get Link";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // ButtonDownLoad
            // 
            this.ButtonDownLoad.Depth = 0;
            this.ButtonDownLoad.Location = new System.Drawing.Point(455, 252);
            this.ButtonDownLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDownLoad.Name = "ButtonDownLoad";
            this.ButtonDownLoad.Primary = true;
            this.ButtonDownLoad.Size = new System.Drawing.Size(148, 30);
            this.ButtonDownLoad.TabIndex = 1;
            this.ButtonDownLoad.Text = "DownLoad";
            this.ButtonDownLoad.UseVisualStyleBackColor = true;
            this.ButtonDownLoad.Click += new System.EventHandler(this.ButtonDownLoad_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.LightGray;
            this.textBoxResult.Location = new System.Drawing.Point(12, 219);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(591, 26);
            this.textBoxResult.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 177);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(149, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "DownLoad Link :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(504, 400);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 24);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "©Hien Lech";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CheckBoxDownLoad
            // 
            this.CheckBoxDownLoad.AutoSize = true;
            this.CheckBoxDownLoad.Depth = 0;
            this.CheckBoxDownLoad.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxDownLoad.Location = new System.Drawing.Point(7, 254);
            this.CheckBoxDownLoad.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxDownLoad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxDownLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxDownLoad.Name = "CheckBoxDownLoad";
            this.CheckBoxDownLoad.Ripple = true;
            this.CheckBoxDownLoad.Size = new System.Drawing.Size(153, 30);
            this.CheckBoxDownLoad.TabIndex = 6;
            this.CheckBoxDownLoad.Text = "Auto DownLoad";
            this.CheckBoxDownLoad.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Get_Link_Fshare.Properties.Resources.facebook_logo;
            this.pictureBox2.Location = new System.Drawing.Point(538, 367);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Get_Link_Fshare.Properties.Resources.logo_fshare;
            this.pictureBox1.Location = new System.Drawing.Point(203, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(611, 423);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CheckBoxDownLoad);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.ButtonDownLoad);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.materialLabel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(629, 470);
            this.MinimumSize = new System.Drawing.Size(629, 470);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Link Fshare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxLink;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonDownLoad;
        private System.Windows.Forms.TextBox textBoxResult;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxDownLoad;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

