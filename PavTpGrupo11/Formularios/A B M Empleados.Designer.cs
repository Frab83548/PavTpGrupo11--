
namespace PavTpGrupo11.Formularios
{
    partial class frmABM_EMPLEADOS
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
            this.txtCodigoEMPLEADO = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaEmpleados = new System.Windows.Forms.DataGridView();
            this.NombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoEMPLEADO
            // 
            this.txtCodigoEMPLEADO.Location = new System.Drawing.Point(220, 107);
            this.txtCodigoEMPLEADO.Name = "txtCodigoEMPLEADO";
            this.txtCodigoEMPLEADO.Size = new System.Drawing.Size(155, 20);
            this.txtCodigoEMPLEADO.TabIndex = 17;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(220, 64);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(220, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // GrillaEmpleados
            // 
            this.GrillaEmpleados.AllowUserToAddRows = false;
            this.GrillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreE,
            this.ApellidoE,
            this.CodigoE,
            this.TelefonoE});
            this.GrillaEmpleados.Location = new System.Drawing.Point(34, 157);
            this.GrillaEmpleados.Name = "GrillaEmpleados";
            this.GrillaEmpleados.Size = new System.Drawing.Size(476, 123);
            this.GrillaEmpleados.TabIndex = 18;
            // 
            // NombreE
            // 
            this.NombreE.HeaderText = "Nombre";
            this.NombreE.Name = "NombreE";
            // 
            // ApellidoE
            // 
            this.ApellidoE.HeaderText = "Apellido";
            this.ApellidoE.Name = "ApellidoE";
            // 
            // CodigoE
            // 
            this.CodigoE.HeaderText = "Codigo";
            this.CodigoE.Name = "CodigoE";
            // 
            // TelefonoE
            // 
            this.TelefonoE.HeaderText = "Telefono";
            this.TelefonoE.Name = "TelefonoE";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(492, 304);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 23);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmABM_EMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 364);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.GrillaEmpleados);
            this.Controls.Add(this.txtCodigoEMPLEADO);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmABM_EMPLEADOS";
            this.Text = "A_B_M_Empleados";
            this.Load += new System.EventHandler(this.frmABM_EMPLEADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoEMPLEADO;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoE;
        private System.Windows.Forms.Button btnConsultar;
    }
}