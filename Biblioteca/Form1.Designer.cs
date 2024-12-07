namespace Biblioteca
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panelMenuLateral = new Guna.UI2.WinForms.Guna2Panel();
            cnbCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            btnLibros = new Guna.UI2.WinForms.Guna2GradientButton();
            panelMenuLateral.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.FromArgb(84, 84, 84);
            panelMenuLateral.Controls.Add(btnLibros);
            panelMenuLateral.CustomizableEdges = customizableEdges5;
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelMenuLateral.Size = new Size(250, 658);
            panelMenuLateral.TabIndex = 0;
            // 
            // cnbCerrar
            // 
            cnbCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cnbCerrar.CustomizableEdges = customizableEdges1;
            cnbCerrar.FillColor = Color.FromArgb(139, 152, 166);
            cnbCerrar.IconColor = Color.White;
            cnbCerrar.Location = new Point(1019, 12);
            cnbCerrar.Name = "cnbCerrar";
            cnbCerrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cnbCerrar.Size = new Size(56, 36);
            cnbCerrar.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // btnLibros
            // 
            btnLibros.CustomizableEdges = customizableEdges3;
            btnLibros.DisabledState.BorderColor = Color.DarkGray;
            btnLibros.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLibros.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLibros.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLibros.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLibros.FillColor = Color.Empty;
            btnLibros.FillColor2 = Color.Empty;
            btnLibros.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.ForeColor = Color.White;
            btnLibros.HoverState.FillColor = Color.FromArgb(224, 133, 48);
            btnLibros.HoverState.FillColor2 = Color.FromArgb(84, 84, 84);
            btnLibros.HoverState.Font = new Font("Segoe UI", 9F);
            btnLibros.Location = new Point(0, 110);
            btnLibros.Name = "btnLibros";
            btnLibros.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLibros.Size = new Size(223, 56);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Libros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(145, 145, 145);
            ClientSize = new Size(1087, 658);
            Controls.Add(cnbCerrar);
            Controls.Add(panelMenuLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panelMenuLateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox cnbCerrar;
        private Guna.UI2.WinForms.Guna2Panel panelMenuLateral;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLibros;
    }
}
