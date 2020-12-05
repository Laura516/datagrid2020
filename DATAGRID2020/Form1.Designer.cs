namespace DATAGRID2020
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuIconos = new System.Windows.Forms.ToolStrip();
            this.tsOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsSearchUser = new System.Windows.Forms.ToolStripButton();
            this.tsEditUser = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.tsSaveFile = new System.Windows.Forms.ToolStripButton();
            this.tsExit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.dgTablaDatos = new System.Windows.Forms.DataGridView();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuIconos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.SuspendLayout();
            // 
            // menuIconos
            // 
            this.menuIconos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuIconos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpenFile,
            this.tsAddUser,
            this.tsSearchUser,
            this.tsEditUser,
            this.tsDeleteUser,
            this.tsSaveFile,
            this.tsExit});
            this.menuIconos.Location = new System.Drawing.Point(0, 0);
            this.menuIconos.Name = "menuIconos";
            this.menuIconos.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.menuIconos.Size = new System.Drawing.Size(815, 119);
            this.menuIconos.TabIndex = 0;
            this.menuIconos.Text = "toolStrip1";
            // 
            // tsOpenFile
            // 
            this.tsOpenFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsOpenFile.Image")));
            this.tsOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenFile.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.tsOpenFile.Name = "tsOpenFile";
            this.tsOpenFile.Padding = new System.Windows.Forms.Padding(5);
            this.tsOpenFile.Size = new System.Drawing.Size(94, 94);
            this.tsOpenFile.Text = "toolStripButton1";
            this.tsOpenFile.ToolTipText = "Abre el Archivo XML";
            this.tsOpenFile.Visible = false;
            this.tsOpenFile.Click += new System.EventHandler(this.tsOpenFile_Click);
            // 
            // tsAddUser
            // 
            this.tsAddUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tsAddUser.Image")));
            this.tsAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddUser.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.tsAddUser.Name = "tsAddUser";
            this.tsAddUser.Padding = new System.Windows.Forms.Padding(5);
            this.tsAddUser.Size = new System.Drawing.Size(94, 94);
            this.tsAddUser.Text = "toolStripButton2";
            this.tsAddUser.ToolTipText = "Nuevo estudiante";
            this.tsAddUser.Click += new System.EventHandler(this.tsAddUser_Click);
            // 
            // tsSearchUser
            // 
            this.tsSearchUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsSearchUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("tsSearchUser.Image")));
            this.tsSearchUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSearchUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearchUser.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.tsSearchUser.Name = "tsSearchUser";
            this.tsSearchUser.Padding = new System.Windows.Forms.Padding(5);
            this.tsSearchUser.Size = new System.Drawing.Size(94, 94);
            this.tsSearchUser.Text = "toolStripButton3";
            this.tsSearchUser.ToolTipText = "Buscar estudiante";
            this.tsSearchUser.Click += new System.EventHandler(this.tsSearchUser_Click);
            // 
            // tsEditUser
            // 
            this.tsEditUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditUser.Enabled = false;
            this.tsEditUser.Image = ((System.Drawing.Image)(resources.GetObject("tsEditUser.Image")));
            this.tsEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditUser.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.tsEditUser.Name = "tsEditUser";
            this.tsEditUser.Padding = new System.Windows.Forms.Padding(5);
            this.tsEditUser.Size = new System.Drawing.Size(94, 94);
            this.tsEditUser.Text = "toolStripButton4";
            this.tsEditUser.ToolTipText = "Editar datos estudiantes";
            this.tsEditUser.Click += new System.EventHandler(this.tsEditUser_Click);
            // 
            // tsDeleteUser
            // 
            this.tsDeleteUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteUser.Enabled = false;
            this.tsDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteUser.Image")));
            this.tsDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteUser.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.tsDeleteUser.Name = "tsDeleteUser";
            this.tsDeleteUser.Padding = new System.Windows.Forms.Padding(5);
            this.tsDeleteUser.Size = new System.Drawing.Size(94, 94);
            this.tsDeleteUser.Text = "toolStripButton5";
            this.tsDeleteUser.ToolTipText = "Borrar datos estudiante";
            this.tsDeleteUser.Click += new System.EventHandler(this.tsDeleteUser_Click);
            // 
            // tsSaveFile
            // 
            this.tsSaveFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveFile.Image")));
            this.tsSaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveFile.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.tsSaveFile.Name = "tsSaveFile";
            this.tsSaveFile.Padding = new System.Windows.Forms.Padding(5);
            this.tsSaveFile.Size = new System.Drawing.Size(94, 94);
            this.tsSaveFile.Text = "toolStripButton6";
            this.tsSaveFile.ToolTipText = "Guardar archivo XML";
            this.tsSaveFile.Visible = false;
            this.tsSaveFile.Click += new System.EventHandler(this.tsSaveFile_Click);
            // 
            // tsExit
            // 
            this.tsExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExit.Image = ((System.Drawing.Image)(resources.GetObject("tsExit.Image")));
            this.tsExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.tsExit.Name = "tsExit";
            this.tsExit.Padding = new System.Windows.Forms.Padding(5);
            this.tsExit.Size = new System.Drawing.Size(94, 94);
            this.tsExit.Text = "toolStripButton7";
            this.tsExit.ToolTipText = "Cerrar Aplicación";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo ";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(583, 204);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(144, 26);
            this.txtcodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datos Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(190, 251);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(537, 26);
            this.txtnombre.TabIndex = 6;
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(190, 358);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(47, 26);
            this.txtnota1.TabIndex = 7;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(190, 297);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(537, 26);
            this.txtcorreo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nota 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(598, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nota 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 361);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nota 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 361);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nota 2";
            // 
            // txtnota4
            // 
            this.txtnota4.Location = new System.Drawing.Point(680, 358);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(47, 26);
            this.txtnota4.TabIndex = 16;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(525, 358);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(47, 26);
            this.txtnota3.TabIndex = 17;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(350, 358);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(47, 26);
            this.txtnota2.TabIndex = 18;
            // 
            // dgTablaDatos
            // 
            this.dgTablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablaDatos.Location = new System.Drawing.Point(93, 406);
            this.dgTablaDatos.Name = "dgTablaDatos";
            this.dgTablaDatos.Size = new System.Drawing.Size(634, 242);
            this.dgTablaDatos.TabIndex = 19;
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 682);
            this.Controls.Add(this.dgTablaDatos);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuIconos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculo de notas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuIconos.ResumeLayout(false);
            this.menuIconos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuIconos;
        private System.Windows.Forms.ToolStripButton tsOpenFile;
        private System.Windows.Forms.ToolStripButton tsAddUser;
        private System.Windows.Forms.ToolStripButton tsSearchUser;
        private System.Windows.Forms.ToolStripButton tsEditUser;
        private System.Windows.Forms.ToolStripButton tsDeleteUser;
        private System.Windows.Forms.ToolStripButton tsSaveFile;
        private System.Windows.Forms.ToolStripButton tsExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.DataGridView dgTablaDatos;
        private System.Windows.Forms.ErrorProvider errorM;
    }
}

