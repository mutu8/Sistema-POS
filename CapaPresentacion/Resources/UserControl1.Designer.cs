﻿namespace POS
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGradient2Panel3 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.labelPrecio = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.labelNombre = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientButton_valid = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLinePanel_valid = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaGradient2Panel3.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaLinePanel_valid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaGradient2Panel3
            // 
            this.gunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel3.Controls.Add(this.labelPrecio);
            this.gunaGradient2Panel3.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradient2Panel3.Location = new System.Drawing.Point(7, 8);
            this.gunaGradient2Panel3.Name = "gunaGradient2Panel3";
            this.gunaGradient2Panel3.Radius = 8;
            this.gunaGradient2Panel3.Size = new System.Drawing.Size(71, 25);
            this.gunaGradient2Panel3.TabIndex = 8;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(2, 4);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(64, 15);
            this.labelPrecio.TabIndex = 0;
            this.labelPrecio.Text = "S/. 17.00";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaShadowPanel1.Controls.Add(this.labelNombre);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 70);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 4;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(173, 48);
            this.gunaShadowPanel1.TabIndex = 9;
            this.gunaShadowPanel1.Click += new System.EventHandler(this.GunaShadowPanel1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Black;
            this.labelNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNombre.Location = new System.Drawing.Point(9, 19);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(25, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "___";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaGradientButton_valid
            // 
            this.gunaGradientButton_valid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientButton_valid.Animated = true;
            this.gunaGradientButton_valid.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton_valid.AnimationSpeed = 0.03F;
            this.gunaGradientButton_valid.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton_valid.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientButton_valid.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientButton_valid.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton_valid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton_valid.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton_valid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton_valid.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton_valid.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton_valid.Image")));
            this.gunaGradientButton_valid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton_valid.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton_valid.Location = new System.Drawing.Point(129, 141);
            this.gunaGradientButton_valid.Name = "gunaGradientButton_valid";
            this.gunaGradientButton_valid.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaGradientButton_valid.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaGradientButton_valid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton_valid.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton_valid.OnHoverImage = null;
            this.gunaGradientButton_valid.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton_valid.Radius = 8;
            this.gunaGradientButton_valid.Size = new System.Drawing.Size(44, 44);
            this.gunaGradientButton_valid.TabIndex = 12;
            this.gunaGradientButton_valid.Visible = false;
            this.gunaGradientButton_valid.Click += new System.EventHandler(this.GunaLinePanel_valid_Click);
            // 
            // gunaLinePanel_valid
            // 
            this.gunaLinePanel_valid.AutoSize = true;
            this.gunaLinePanel_valid.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel_valid.Controls.Add(this.gunaGradientButton_valid);
            this.gunaLinePanel_valid.LineBottom = 3;
            this.gunaLinePanel_valid.LineColor = System.Drawing.Color.Tomato;
            this.gunaLinePanel_valid.LineLeft = 3;
            this.gunaLinePanel_valid.LineRight = 3;
            this.gunaLinePanel_valid.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel_valid.LineTop = 3;
            this.gunaLinePanel_valid.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel_valid.Name = "gunaLinePanel_valid";
            this.gunaLinePanel_valid.Size = new System.Drawing.Size(175, 185);
            this.gunaLinePanel_valid.TabIndex = 11;
            this.gunaLinePanel_valid.Visible = false;
            this.gunaLinePanel_valid.Click += new System.EventHandler(this.GunaLinePanel_valid_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.gunaGradient2Panel3);
            this.Controls.Add(this.gunaLinePanel_valid);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(175, 185);
            this.Click += new System.EventHandler(this.UserControl1_Click_1);
            this.gunaGradient2Panel3.ResumeLayout(false);
            this.gunaGradient2Panel3.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.gunaLinePanel_valid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel3;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton_valid;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel_valid;
        public Guna.UI.WinForms.GunaLabel labelNombre;
        public Guna.UI.WinForms.GunaLabel labelPrecio;
    }
}
