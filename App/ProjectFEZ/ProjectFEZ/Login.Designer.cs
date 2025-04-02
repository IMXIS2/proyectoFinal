namespace ProjectFEZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            CBusuario = new CheckBox();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            Esit = new FontAwesome.Sharp.IconButton();
            pnregistrar = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            contraseña = new Label();
            Correo = new Label();
            BTNiniciarseccion = new Guna.UI2.WinForms.Guna2Button();
            TBcontraseña = new Guna.UI2.WinForms.Guna2TextBox();
            TBcorreo = new Guna.UI2.WinForms.Guna2TextBox();
            PanelIzquierdo = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            lema = new Label();
            guna2Panel1.SuspendLayout();
            pnregistrar.SuspendLayout();
            PanelIzquierdo.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(CBusuario);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(iconButton1);
            guna2Panel1.Controls.Add(Esit);
            guna2Panel1.Controls.Add(pnregistrar);
            guna2Panel1.Controls.Add(contraseña);
            guna2Panel1.Controls.Add(Correo);
            guna2Panel1.Controls.Add(BTNiniciarseccion);
            guna2Panel1.Controls.Add(TBcontraseña);
            guna2Panel1.Controls.Add(TBcorreo);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Dock = DockStyle.Right;
            guna2Panel1.Location = new Point(283, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(687, 537);
            guna2Panel1.TabIndex = 0;
            // 
            // CBusuario
            // 
            CBusuario.AutoSize = true;
            CBusuario.Location = new Point(100, 315);
            CBusuario.Name = "CBusuario";
            CBusuario.Size = new Size(115, 19);
            CBusuario.TabIndex = 9;
            CBusuario.Text = "Recordar usuario";
            CBusuario.UseVisualStyleBackColor = true;
            CBusuario.CheckedChanged += CBusuario_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(326, 498);
            label3.Name = "label3";
            label3.Size = new Size(244, 21);
            label3.TabIndex = 8;
            label3.Text = "No estas registrado haz Click aqui";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.BackgroundImageLayout = ImageLayout.Center;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.CornflowerBlue;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(540, 273);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(29, 30);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // Esit
            // 
            Esit.FlatAppearance.BorderSize = 0;
            Esit.FlatStyle = FlatStyle.Flat;
            Esit.IconChar = FontAwesome.Sharp.IconChar.X;
            Esit.IconColor = Color.Red;
            Esit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            Esit.IconSize = 30;
            Esit.Location = new Point(645, 7);
            Esit.Margin = new Padding(0);
            Esit.Name = "Esit";
            Esit.Size = new Size(36, 31);
            Esit.TabIndex = 6;
            Esit.UseVisualStyleBackColor = true;
            Esit.Click += Esit_Click;
            // 
            // pnregistrar
            // 
            pnregistrar.BackColor = Color.Transparent;
            pnregistrar.BorderRadius = 10;
            pnregistrar.Controls.Add(label2);
            pnregistrar.CustomBorderColor = Color.Red;
            pnregistrar.CustomizableEdges = customizableEdges1;
            pnregistrar.FillColor = Color.Orange;
            pnregistrar.ForeColor = Color.Black;
            pnregistrar.Location = new Point(576, 484);
            pnregistrar.Name = "pnregistrar";
            pnregistrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnregistrar.Size = new Size(105, 44);
            pnregistrar.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 0;
            label2.Text = "Registrar";
            label2.Click += label2_Click;
            // 
            // contraseña
            // 
            contraseña.AutoSize = true;
            contraseña.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            contraseña.Location = new Point(100, 232);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(126, 23);
            contraseña.TabIndex = 4;
            contraseña.Text = "Contraseña:";
            contraseña.Click += label3_Click;
            // 
            // Correo
            // 
            Correo.AutoSize = true;
            Correo.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Correo.Location = new Point(100, 145);
            Correo.Name = "Correo";
            Correo.Size = new Size(194, 23);
            Correo.TabIndex = 3;
            Correo.Text = "Correo Electronico:";
            // 
            // BTNiniciarseccion
            // 
            BTNiniciarseccion.BorderRadius = 10;
            BTNiniciarseccion.CustomizableEdges = customizableEdges3;
            BTNiniciarseccion.DisabledState.BorderColor = Color.DarkGray;
            BTNiniciarseccion.DisabledState.CustomBorderColor = Color.DarkGray;
            BTNiniciarseccion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTNiniciarseccion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTNiniciarseccion.FillColor = Color.YellowGreen;
            BTNiniciarseccion.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNiniciarseccion.ForeColor = Color.Black;
            BTNiniciarseccion.Location = new Point(100, 358);
            BTNiniciarseccion.Name = "BTNiniciarseccion";
            BTNiniciarseccion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BTNiniciarseccion.Size = new Size(473, 80);
            BTNiniciarseccion.TabIndex = 2;
            BTNiniciarseccion.Text = "Iniciar Seccion ";
            BTNiniciarseccion.Click += BTNiniciarseccion_Click;
            // 
            // TBcontraseña
            // 
            TBcontraseña.BorderColor = Color.White;
            TBcontraseña.BorderRadius = 10;
            TBcontraseña.CustomizableEdges = customizableEdges5;
            TBcontraseña.DefaultText = "";
            TBcontraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TBcontraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TBcontraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TBcontraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TBcontraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TBcontraseña.Font = new Font("Segoe UI", 9F);
            TBcontraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TBcontraseña.Location = new Point(100, 268);
            TBcontraseña.Name = "TBcontraseña";
            TBcontraseña.PlaceholderText = "";
            TBcontraseña.SelectedText = "";
            TBcontraseña.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TBcontraseña.Size = new Size(473, 41);
            TBcontraseña.TabIndex = 1;
            // 
            // TBcorreo
            // 
            TBcorreo.BorderRadius = 10;
            TBcorreo.CustomizableEdges = customizableEdges7;
            TBcorreo.DefaultText = "";
            TBcorreo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TBcorreo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TBcorreo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TBcorreo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TBcorreo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TBcorreo.Font = new Font("Segoe UI", 9F);
            TBcorreo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TBcorreo.Location = new Point(100, 171);
            TBcorreo.Name = "TBcorreo";
            TBcorreo.PlaceholderText = "";
            TBcorreo.SelectedText = "";
            TBcorreo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TBcorreo.Size = new Size(473, 41);
            TBcorreo.TabIndex = 0;
            // 
            // PanelIzquierdo
            // 
            PanelIzquierdo.BackColor = Color.ForestGreen;
            PanelIzquierdo.BorderRadius = 50;
            PanelIzquierdo.Controls.Add(label1);
            PanelIzquierdo.Controls.Add(lema);
            PanelIzquierdo.CustomizableEdges = customizableEdges11;
            PanelIzquierdo.Dock = DockStyle.Left;
            PanelIzquierdo.Location = new Point(0, 0);
            PanelIzquierdo.Name = "PanelIzquierdo";
            PanelIzquierdo.ShadowDecoration.CustomizableEdges = customizableEdges12;
            PanelIzquierdo.Size = new Size(282, 537);
            PanelIzquierdo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 507);
            label1.Name = "label1";
            label1.Size = new Size(265, 21);
            label1.TabIndex = 1;
            label1.Text = "Copyright Bank Company global";
            // 
            // lema
            // 
            lema.AutoSize = true;
            lema.Font = new Font("Times New Roman", 30F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lema.ForeColor = Color.White;
            lema.Location = new Point(12, 223);
            lema.Name = "lema";
            lema.Size = new Size(271, 141);
            lema.TabIndex = 0;
            lema.Text = "A tu \r\n   servicio \r\n            Siempre\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 537);
            Controls.Add(PanelIzquierdo);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            pnregistrar.ResumeLayout(false);
            pnregistrar.PerformLayout();
            PanelIzquierdo.ResumeLayout(false);
            PanelIzquierdo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel PanelIzquierdo;
        private Label lema;
        private Guna.UI2.WinForms.Guna2Button BTNiniciarseccion;
        private Guna.UI2.WinForms.Guna2TextBox TBcontraseña;
        private Guna.UI2.WinForms.Guna2TextBox TBcorreo;
        private Label label1;
        private Label contraseña;
        private Label Correo;
        private Guna.UI2.WinForms.Guna2Panel pnregistrar;
        private FontAwesome.Sharp.IconButton Esit;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private CheckBox CBusuario;
    }
}
