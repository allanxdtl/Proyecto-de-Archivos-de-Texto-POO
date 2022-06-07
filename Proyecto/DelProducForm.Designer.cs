
namespace Proyecto
{
    partial class DelProducForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttnCerrarMenu = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor selecciona el producto que deseas eliminar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(49, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 245);
            this.dataGridView1.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 104;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 85;
            // 
            // bttnCerrarMenu
            // 
            this.bttnCerrarMenu.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bttnCerrarMenu.FlatAppearance.BorderSize = 2;
            this.bttnCerrarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnCerrarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bttnCerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCerrarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(180)))));
            this.bttnCerrarMenu.Location = new System.Drawing.Point(240, 379);
            this.bttnCerrarMenu.Name = "bttnCerrarMenu";
            this.bttnCerrarMenu.Size = new System.Drawing.Size(191, 32);
            this.bttnCerrarMenu.TabIndex = 15;
            this.bttnCerrarMenu.Text = "Cerrar Ventana";
            this.bttnCerrarMenu.UseVisualStyleBackColor = true;
            this.bttnCerrarMenu.Click += new System.EventHandler(this.bttnCerrarMenu_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bttnEliminar.FlatAppearance.BorderSize = 2;
            this.bttnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(180)))));
            this.bttnEliminar.Location = new System.Drawing.Point(60, 379);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(151, 32);
            this.bttnEliminar.TabIndex = 14;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // DelProducForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(470, 464);
            this.ControlBox = false;
            this.Controls.Add(this.bttnCerrarMenu);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DelProducForm";
            this.Text = "Eliminar producto del menú";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button bttnCerrarMenu;
        private System.Windows.Forms.Button bttnEliminar;
    }
}