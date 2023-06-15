namespace R13
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ipbTitle = new FontAwesome.Sharp.IconPictureBox();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.icbEdit = new FontAwesome.Sharp.IconButton();
            this.icbCadastrar = new FontAwesome.Sharp.IconButton();
            this.icbHome = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.lblBv = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbTitle)).BeginInit();
            this.pnlmenu.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.ptbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(212, 168);
            this.pnlLogo.TabIndex = 0;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ptbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(40, 18);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(132, 132);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(115)))));
            this.pnlTitleBar.Controls.Add(this.btnMinimizar);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnFechar);
            this.pnlTitleBar.Controls.Add(this.btnMini);
            this.pnlTitleBar.Controls.Add(this.btnMax);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.ipbTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(212, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(730, 100);
            this.pnlTitleBar.TabIndex = 7;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Location = new System.Drawing.Point(643, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximize.Location = new System.Drawing.Point(674, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.Location = new System.Drawing.Point(702, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMini.Location = new System.Drawing.Point(1560, 0);
            this.btnMini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(24, 37);
            this.btnMini.TabIndex = 4;
            this.btnMini.Text = "-";
            this.btnMini.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMax.Location = new System.Drawing.Point(1584, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(24, 37);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "○";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1609, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(58, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Home";
            // 
            // ipbTitle
            // 
            this.ipbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(115)))));
            this.ipbTitle.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ipbTitle.IconColor = System.Drawing.Color.White;
            this.ipbTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbTitle.IconSize = 34;
            this.ipbTitle.Location = new System.Drawing.Point(17, 37);
            this.ipbTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ipbTitle.Name = "ipbTitle";
            this.ipbTitle.Size = new System.Drawing.Size(35, 34);
            this.ipbTitle.TabIndex = 0;
            this.ipbTitle.TabStop = false;
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(24)))), ((int)(((byte)(89)))));
            this.pnlmenu.Controls.Add(this.icbEdit);
            this.pnlmenu.Controls.Add(this.icbCadastrar);
            this.pnlmenu.Controls.Add(this.icbHome);
            this.pnlmenu.Controls.Add(this.label1);
            this.pnlmenu.Controls.Add(this.pnlLogo);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(212, 611);
            this.pnlmenu.TabIndex = 6;
            // 
            // icbEdit
            // 
            this.icbEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbEdit.FlatAppearance.BorderSize = 0;
            this.icbEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbEdit.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.icbEdit.ForeColor = System.Drawing.Color.White;
            this.icbEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.icbEdit.IconColor = System.Drawing.Color.White;
            this.icbEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbEdit.IconSize = 30;
            this.icbEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbEdit.Location = new System.Drawing.Point(0, 296);
            this.icbEdit.Name = "icbEdit";
            this.icbEdit.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.icbEdit.Size = new System.Drawing.Size(212, 64);
            this.icbEdit.TabIndex = 3;
            this.icbEdit.Text = "Visualizar/Editar";
            this.icbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbEdit.UseVisualStyleBackColor = true;
            this.icbEdit.Click += new System.EventHandler(this.icbEdit_Click);
            // 
            // icbCadastrar
            // 
            this.icbCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbCadastrar.FlatAppearance.BorderSize = 0;
            this.icbCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbCadastrar.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.icbCadastrar.ForeColor = System.Drawing.Color.White;
            this.icbCadastrar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.icbCadastrar.IconColor = System.Drawing.Color.White;
            this.icbCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbCadastrar.IconSize = 36;
            this.icbCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbCadastrar.Location = new System.Drawing.Point(0, 232);
            this.icbCadastrar.Name = "icbCadastrar";
            this.icbCadastrar.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.icbCadastrar.Size = new System.Drawing.Size(212, 64);
            this.icbCadastrar.TabIndex = 2;
            this.icbCadastrar.Text = "Cadastrar";
            this.icbCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbCadastrar.UseVisualStyleBackColor = true;
            this.icbCadastrar.Click += new System.EventHandler(this.icbCadastrar_Click);
            // 
            // icbHome
            // 
            this.icbHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbHome.FlatAppearance.BorderSize = 0;
            this.icbHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbHome.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.icbHome.ForeColor = System.Drawing.Color.White;
            this.icbHome.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.icbHome.IconColor = System.Drawing.Color.White;
            this.icbHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbHome.IconSize = 36;
            this.icbHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbHome.Location = new System.Drawing.Point(0, 168);
            this.icbHome.Name = "icbHome";
            this.icbHome.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.icbHome.Size = new System.Drawing.Size(212, 64);
            this.icbHome.TabIndex = 1;
            this.icbHome.Text = "Home";
            this.icbHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbHome.UseVisualStyleBackColor = true;
            this.icbHome.Click += new System.EventHandler(this.icbHome_Click_1);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 585);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "®Produced by Danilo S.S.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlDesktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDesktop.BackgroundImage")));
            this.pnlDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDesktop.Controls.Add(this.lblBv);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(212, 100);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(730, 511);
            this.pnlDesktop.TabIndex = 8;
            // 
            // lblBv
            // 
            this.lblBv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBv.AutoSize = true;
            this.lblBv.BackColor = System.Drawing.Color.Transparent;
            this.lblBv.Font = new System.Drawing.Font("Malgun Gothic", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBv.Location = new System.Drawing.Point(88, 217);
            this.lblBv.Name = "lblBv";
            this.lblBv.Size = new System.Drawing.Size(590, 89);
            this.lblBv.TabIndex = 0;
            this.lblBv.Text = "Seja Bem Vindo!!";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(942, 611);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlmenu);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbTitle)).EndInit();
            this.pnlmenu.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLogo;
        private PictureBox ptbLogo;
        private Panel pnlTitleBar;
        private Button btnMini;
        private Button btnMax;
        private Button btnClose;
        private Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox ipbTitle;
        private Panel pnlmenu;
        private FontAwesome.Sharp.IconButton icbEdit;
        private FontAwesome.Sharp.IconButton icbCadastrar;
        private FontAwesome.Sharp.IconButton icbHome;
        private Button btnFechar;
        private Button btnMinimizar;
        private Button btnMaximize;
        private Panel pnlDesktop;
        private Label lblBv;
        private Label label1;
    }
}