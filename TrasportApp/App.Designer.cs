namespace TrasportApp
{
    partial class App
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.sdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.themButton = new System.Windows.Forms.Button();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdToolStripMenuItem,
            this.sdfToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(110, 68);
            // 
            // sdToolStripMenuItem
            // 
            this.sdToolStripMenuItem.Name = "sdToolStripMenuItem";
            this.sdToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.sdToolStripMenuItem.Text = "sd";
            // 
            // sdfToolStripMenuItem
            // 
            this.sdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdToolStripMenuItem1,
            this.sdfToolStripMenuItem1});
            this.sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
            this.sdfToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.sdfToolStripMenuItem.Text = "sdf";
            // 
            // sdToolStripMenuItem1
            // 
            this.sdToolStripMenuItem1.Name = "sdToolStripMenuItem1";
            this.sdToolStripMenuItem1.Size = new System.Drawing.Size(139, 34);
            this.sdToolStripMenuItem1.Text = "sd";
            // 
            // sdfToolStripMenuItem1
            // 
            this.sdfToolStripMenuItem1.Name = "sdfToolStripMenuItem1";
            this.sdfToolStripMenuItem1.Size = new System.Drawing.Size(139, 34);
            this.sdfToolStripMenuItem1.Text = "sdf";
            // 
            // themButton
            // 
            this.themButton.BackColor = System.Drawing.Color.Transparent;
            this.themButton.BackgroundImage = global::TrasportApp.Properties.Resources.themeButton;
            this.themButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.themButton.FlatAppearance.BorderSize = 0;
            this.themButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.themButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.themButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themButton.Location = new System.Drawing.Point(753, 48);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(35, 36);
            this.themButton.TabIndex = 8;
            this.themButton.UseVisualStyleBackColor = false;
            this.themButton.Click += new System.EventHandler(this.themButton_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(271, 191);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(212, 30);
            this.materialCheckBox1.TabIndex = 9;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(174, 244);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(263, 36);
            this.materialFlatButton1.TabIndex = 10;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(136, 310);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(284, 36);
            this.materialRaisedButton1.TabIndex = 11;
            this.materialRaisedButton1.Text = "materialRaisedButton1";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.themButton);
            this.Name = "App";
            this.Text = "Form1";
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sdfToolStripMenuItem1;
        private System.Windows.Forms.Button themButton;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

