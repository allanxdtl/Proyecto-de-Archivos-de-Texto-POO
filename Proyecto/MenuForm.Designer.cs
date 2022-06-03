
namespace Proyecto
{
    partial class MenuForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCerrarMenu = new System.Windows.Forms.Button();
            this.bttnAddProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(70, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 245);
            this.dataGridView1.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Favor de seleccionar el producto por favor";
            // 
            // bttnCerrarMenu
            // 
            this.bttnCerrarMenu.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bttnCerrarMenu.FlatAppearance.BorderSize = 2;
            this.bttnCerrarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bttnCerrarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnCerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCerrarMenu.Location = new System.Drawing.Point(214, 342);
            this.bttnCerrarMenu.Name = "bttnCerrarMenu";
            this.bttnCerrarMenu.Size = new System.Drawing.Size(191, 64);
            this.bttnCerrarMenu.TabIndex = 13;
            this.bttnCerrarMenu.Text = "Cerrar Menú";
            this.bttnCerrarMenu.UseVisualStyleBackColor = true;
            this.bttnCerrarMenu.Click += new System.EventHandler(this.bttnCerrarMenu_Click);
            // 
            // bttnAddProducto
            // 
            this.bttnAddProducto.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bttnAddProducto.FlatAppearance.BorderSize = 2;
            this.bttnAddProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bttnAddProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnAddProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddProducto.Location = new System.Drawing.Point(7, 342);
            this.bttnAddProducto.Name = "bttnAddProducto";
            this.bttnAddProducto.Size = new System.Drawing.Size(191, 64);
            this.bttnAddProducto.TabIndex = 12;
            this.bttnAddProducto.Text = "Añadir Producto a la cuenta";
            this.bttnAddProducto.UseVisualStyleBackColor = true;
            this.bttnAddProducto.Click += new System.EventHandler(this.bttnAddProducto_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 453);
            this.Controls.Add(this.bttnCerrarMenu);
            this.Controls.Add(this.bttnAddProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnCerrarMenu;
        private System.Windows.Forms.Button bttnAddProducto;
    }
}