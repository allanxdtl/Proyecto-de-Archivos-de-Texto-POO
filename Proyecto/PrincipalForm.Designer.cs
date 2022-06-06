
namespace Proyecto
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMenúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCorteDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bttnMesa1 = new System.Windows.Forms.Button();
            this.bttnMesa6 = new System.Windows.Forms.Button();
            this.bttnMesa3 = new System.Windows.Forms.Button();
            this.bttnMesa8 = new System.Windows.Forms.Button();
            this.bttnMesa5 = new System.Windows.Forms.Button();
            this.bttnMesa2 = new System.Windows.Forms.Button();
            this.bttnMesa7 = new System.Windows.Forms.Button();
            this.bttnMesa4 = new System.Windows.Forms.Button();
            this.bttnMesa9 = new System.Windows.Forms.Button();
            this.bttnAddMesa = new System.Windows.Forms.Button();
            this.bttnCobrar = new System.Windows.Forms.Button();
            this.cmbMesa = new System.Windows.Forms.ComboBox();
            this.cmbMesaCobrar = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verOpcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verOpcionesToolStripMenuItem
            // 
            this.verOpcionesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.verOpcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMenúToolStripMenuItem,
            this.añadirProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.verCorteDeCajaToolStripMenuItem,
            this.cerrarSistemaToolStripMenuItem});
            this.verOpcionesToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verOpcionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.verOpcionesToolStripMenuItem.Name = "verOpcionesToolStripMenuItem";
            this.verOpcionesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.verOpcionesToolStripMenuItem.Text = "Ver Opciones";
            // 
            // verMenúToolStripMenuItem
            // 
            this.verMenúToolStripMenuItem.Name = "verMenúToolStripMenuItem";
            this.verMenúToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verMenúToolStripMenuItem.Text = "Ver Menú";
            this.verMenúToolStripMenuItem.Click += new System.EventHandler(this.verMenúToolStripMenuItem_Click);
            // 
            // añadirProductoToolStripMenuItem
            // 
            this.añadirProductoToolStripMenuItem.Name = "añadirProductoToolStripMenuItem";
            this.añadirProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirProductoToolStripMenuItem.Text = "Añadir Producto";
            this.añadirProductoToolStripMenuItem.Click += new System.EventHandler(this.añadirProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // verCorteDeCajaToolStripMenuItem
            // 
            this.verCorteDeCajaToolStripMenuItem.Name = "verCorteDeCajaToolStripMenuItem";
            this.verCorteDeCajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verCorteDeCajaToolStripMenuItem.Text = "Ver Corte de Caja";
            this.verCorteDeCajaToolStripMenuItem.Click += new System.EventHandler(this.verCorteDeCajaToolStripMenuItem_Click);
            // 
            // cerrarSistemaToolStripMenuItem
            // 
            this.cerrarSistemaToolStripMenuItem.Name = "cerrarSistemaToolStripMenuItem";
            this.cerrarSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSistemaToolStripMenuItem.Text = "Cerrar Sistema";
            this.cerrarSistemaToolStripMenuItem.Click += new System.EventHandler(this.cerrarSistemaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bttnMesa1
            // 
            this.bttnMesa1.BackColor = System.Drawing.Color.Lime;
            this.bttnMesa1.Location = new System.Drawing.Point(86, 66);
            this.bttnMesa1.Name = "bttnMesa1";
            this.bttnMesa1.Size = new System.Drawing.Size(84, 59);
            this.bttnMesa1.TabIndex = 1;
            this.bttnMesa1.Text = "Mesa 1";
            this.bttnMesa1.UseVisualStyleBackColor = false;
            this.bttnMesa1.Click += new System.EventHandler(this.bttnMesa1_Click);
            // 
            // bttnMesa6
            // 
            this.bttnMesa6.BackColor = System.Drawing.Color.Lime;
            this.bttnMesa6.Location = new System.Drawing.Point(311, 148);
            this.bttnMesa6.Name = "bttnMesa6";
            this.bttnMesa6.Size = new System.Drawing.Size(84, 59);
            this.bttnMesa6.TabIndex = 2;
            this.bttnMesa6.Text = "Mesa 6";
            this.bttnMesa6.UseVisualStyleBackColor = false;
            this.bttnMesa6.Click += new System.EventHandler(this.bttnMesa6_Click);
            // 
            // bttnMesa3
            // 
            this.bttnMesa3.BackColor = System.Drawing.Color.Lime;
            this.bttnMesa3.Location = new System.Drawing.Point(311, 66);
            this.bttnMesa3.Name = "bttnMesa3";
            this.bttnMesa3.Size = new System.Drawing.Size(84, 59);
            this.bttnMesa3.TabIndex = 3;
            this.bttnMesa3.Text = "Mesa 3";
            this.bttnMesa3.UseVisualStyleBackColor = false;
            this.bttnMesa3.Click += new System.EventHandler(this.bttnMesa3_Click);
            // 
            // bttnMesa8
            // 
            this.bttnMesa8.BackColor = System.Drawing.Color.Lime;
            this.bttnMesa8.Location = new System.Drawing.Point(202, 230);
            this.bttnMesa8.Name = "bttnMesa8";
            this.bttnMesa8.Size = new System.Drawing.Size(84, 59);
            this.bttnMesa8.TabIndex = 4;
            this.bttnMesa8.Text = "Mesa 8";
            this.bttnMesa8.UseVisualStyleBackColor = false;
            this.bttnMesa8.Click += new System.EventHandler(this.bttnMesa8_Click);
            // 
            // bttnMesa5
            // 
            this.bttnMesa5.BackColor = System.Drawing.Color.Lime;
            this.bttnMesa5.Location = new System.Drawing.Point(202, 148);
            this.bttnMesa5.Name = "bttnMesa5";
            this.bttnMesa5.Size = new System.Drawing.Size(84, 59);
            this.bttnMesa5.TabIndex = 5;
            this.bttnMesa5.Text = "Mesa 5";
            this.bttnMesa5.UseVisualStyleBackColor = false;
            this.bttnMesa5.Click += new System.EventHandler(this.bttnMesa5_Click);
            // 
            // bttnMesa2
            // 
            this.bttnMesa2.BackColor = System.Drawing.Color.Lime;
            this.bttnMesa2.Location = new System.Drawing.Point(202, 66);
            this.bttnMesa2.Name = "bttnMesa2";
            this.bttnMesa2.Size = new System.Drawing.Size(84, 59);
            this.bttnMesa2.TabIndex = 6;
            this.bttnMesa2.Text = "Mesa 2";
            this.bttnMesa2.UseVisualStyleBackColor = false;
            this.bttnMesa2.Click += new System.EventHandler(this.bttnMesa2_Click);
            // 
            // bttnMesa7
            // 
            this.bttnMesa7.BackColor = System.Drawing.Color.Lime;
            this.bttnMesa7.Location = new System.Drawing.Point(86, 230);
            this.bttnMesa7.Name = "bttnMesa7";
            this.bttnMesa7.Size = new System.Drawing.Size(84, 59);
            this.bttnMesa7.TabIndex = 7;
            this.bttnMesa7.Text = "Mesa 7";
            this.bttnMesa7.UseVisualStyleBackColor = false;
            this.bttnMesa7.Click += new System.EventHandler(this.bttnMesa7_Click);
            // 
            // bttnMesa4
            // 
            this.bttnMesa4.BackColor = System.Drawing.Color.Lime;
            this.bttnMesa4.Location = new System.Drawing.Point(86, 148);
            this.bttnMesa4.Name = "bttnMesa4";
            this.bttnMesa4.Size = new System.Drawing.Size(84, 59);
            this.bttnMesa4.TabIndex = 8;
            this.bttnMesa4.Text = "Mesa 4";
            this.bttnMesa4.UseVisualStyleBackColor = false;
            this.bttnMesa4.Click += new System.EventHandler(this.bttnMesa4_Click);
            // 
            // bttnMesa9
            // 
            this.bttnMesa9.BackColor = System.Drawing.Color.Lime;
            this.bttnMesa9.Location = new System.Drawing.Point(311, 230);
            this.bttnMesa9.Name = "bttnMesa9";
            this.bttnMesa9.Size = new System.Drawing.Size(84, 59);
            this.bttnMesa9.TabIndex = 9;
            this.bttnMesa9.Text = "Mesa 9";
            this.bttnMesa9.UseVisualStyleBackColor = false;
            this.bttnMesa9.Click += new System.EventHandler(this.bttnMesa9_Click);
            // 
            // bttnAddMesa
            // 
            this.bttnAddMesa.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bttnAddMesa.FlatAppearance.BorderSize = 2;
            this.bttnAddMesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bttnAddMesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnAddMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddMesa.Location = new System.Drawing.Point(37, 309);
            this.bttnAddMesa.Name = "bttnAddMesa";
            this.bttnAddMesa.Size = new System.Drawing.Size(191, 32);
            this.bttnAddMesa.TabIndex = 10;
            this.bttnAddMesa.Text = "Añadir nueva orden a mesa";
            this.bttnAddMesa.UseVisualStyleBackColor = true;
            this.bttnAddMesa.Click += new System.EventHandler(this.bttnAddMesa_Click);
            // 
            // bttnCobrar
            // 
            this.bttnCobrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bttnCobrar.FlatAppearance.BorderSize = 2;
            this.bttnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bttnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCobrar.Location = new System.Drawing.Point(255, 309);
            this.bttnCobrar.Name = "bttnCobrar";
            this.bttnCobrar.Size = new System.Drawing.Size(191, 32);
            this.bttnCobrar.TabIndex = 11;
            this.bttnCobrar.Text = "Cobrar a mesa";
            this.bttnCobrar.UseVisualStyleBackColor = true;
            this.bttnCobrar.Click += new System.EventHandler(this.bttnCobrar_Click);
            // 
            // cmbMesa
            // 
            this.cmbMesa.FormattingEnabled = true;
            this.cmbMesa.Location = new System.Drawing.Point(61, 363);
            this.cmbMesa.Name = "cmbMesa";
            this.cmbMesa.Size = new System.Drawing.Size(121, 24);
            this.cmbMesa.TabIndex = 12;
            this.cmbMesa.Visible = false;
            this.cmbMesa.SelectedIndexChanged += new System.EventHandler(this.cmbMesa_SelectedIndexChanged);
            // 
            // cmbMesaCobrar
            // 
            this.cmbMesaCobrar.FormattingEnabled = true;
            this.cmbMesaCobrar.Location = new System.Drawing.Point(290, 363);
            this.cmbMesaCobrar.Name = "cmbMesaCobrar";
            this.cmbMesaCobrar.Size = new System.Drawing.Size(121, 24);
            this.cmbMesaCobrar.TabIndex = 13;
            this.cmbMesaCobrar.Visible = false;
            this.cmbMesaCobrar.SelectedIndexChanged += new System.EventHandler(this.cmbMesaCobrar_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(107, 37);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(11, 16);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "l";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 411);
            this.ControlBox = false;
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbMesaCobrar);
            this.Controls.Add(this.cmbMesa);
            this.Controls.Add(this.bttnCobrar);
            this.Controls.Add(this.bttnAddMesa);
            this.Controls.Add(this.bttnMesa9);
            this.Controls.Add(this.bttnMesa4);
            this.Controls.Add(this.bttnMesa7);
            this.Controls.Add(this.bttnMesa2);
            this.Controls.Add(this.bttnMesa5);
            this.Controls.Add(this.bttnMesa8);
            this.Controls.Add(this.bttnMesa3);
            this.Controls.Add(this.bttnMesa6);
            this.Controls.Add(this.bttnMesa1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrincipalForm";
            this.Text = "Restaurante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMenúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCorteDeCajaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bttnMesa1;
        private System.Windows.Forms.Button bttnMesa6;
        private System.Windows.Forms.Button bttnMesa3;
        private System.Windows.Forms.Button bttnMesa8;
        private System.Windows.Forms.Button bttnMesa5;
        private System.Windows.Forms.Button bttnMesa2;
        private System.Windows.Forms.Button bttnMesa7;
        private System.Windows.Forms.Button bttnMesa4;
        private System.Windows.Forms.Button bttnMesa9;
        private System.Windows.Forms.ToolStripMenuItem cerrarSistemaToolStripMenuItem;
        private System.Windows.Forms.Button bttnAddMesa;
        private System.Windows.Forms.Button bttnCobrar;
        private System.Windows.Forms.ComboBox cmbMesa;
        private System.Windows.Forms.ComboBox cmbMesaCobrar;
        private System.Windows.Forms.Label lblEstado;
    }
}

