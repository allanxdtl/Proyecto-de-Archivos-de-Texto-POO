
namespace Proyecto
{
    partial class CorteDeCajaForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bttnCerrarVentana = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOtroCorteDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esto es todo lo que se ha vendido por hoy";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(111, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(236, 177);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // bttnCerrarVentana
            // 
            this.bttnCerrarVentana.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bttnCerrarVentana.FlatAppearance.BorderSize = 2;
            this.bttnCerrarVentana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnCerrarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bttnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCerrarVentana.Location = new System.Drawing.Point(272, 259);
            this.bttnCerrarVentana.Name = "bttnCerrarVentana";
            this.bttnCerrarVentana.Size = new System.Drawing.Size(134, 32);
            this.bttnCerrarVentana.TabIndex = 11;
            this.bttnCerrarVentana.Text = "Cerrar";
            this.bttnCerrarVentana.UseVisualStyleBackColor = true;
            this.bttnCerrarVentana.Click += new System.EventHandler(this.bttnCerrarVentana_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bttnGuardar.FlatAppearance.BorderSize = 2;
            this.bttnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Location = new System.Drawing.Point(27, 259);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(225, 32);
            this.bttnGuardar.TabIndex = 12;
            this.bttnGuardar.Text = "Guardar Corte de Caja";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verOtroCorteDeCajaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // verOtroCorteDeCajaToolStripMenuItem
            // 
            this.verOtroCorteDeCajaToolStripMenuItem.Name = "verOtroCorteDeCajaToolStripMenuItem";
            this.verOtroCorteDeCajaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.verOtroCorteDeCajaToolStripMenuItem.Text = "Ver otro corte de caja";
            this.verOtroCorteDeCajaToolStripMenuItem.Click += new System.EventHandler(this.verOtroCorteDeCajaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CorteDeCajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(457, 314);
            this.ControlBox = false;
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnCerrarVentana);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(180)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CorteDeCajaForm";
            this.Text = "Corte de Caja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bttnCerrarVentana;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verOtroCorteDeCajaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}