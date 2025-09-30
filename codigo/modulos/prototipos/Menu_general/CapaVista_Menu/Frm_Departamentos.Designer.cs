namespace CapaVista_Menu
{
    partial class Frm_Departamentos
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
            this.Dgv_Departamentos = new System.Windows.Forms.DataGridView();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_IdDepartamento = new System.Windows.Forms.TextBox();
            this.Txt_Departamento = new System.Windows.Forms.TextBox();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Btn_Insertar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Departamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Departamentos
            // 
            this.Dgv_Departamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Departamentos.Location = new System.Drawing.Point(411, 26);
            this.Dgv_Departamentos.Name = "Dgv_Departamentos";
            this.Dgv_Departamentos.RowHeadersWidth = 51;
            this.Dgv_Departamentos.RowTemplate.Height = 24;
            this.Dgv_Departamentos.Size = new System.Drawing.Size(583, 470);
            this.Dgv_Departamentos.TabIndex = 0;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(42, 26);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(321, 35);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "CRUD - Departamentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id_Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // Txt_IdDepartamento
            // 
            this.Txt_IdDepartamento.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdDepartamento.Location = new System.Drawing.Point(28, 175);
            this.Txt_IdDepartamento.Name = "Txt_IdDepartamento";
            this.Txt_IdDepartamento.Size = new System.Drawing.Size(226, 34);
            this.Txt_IdDepartamento.TabIndex = 5;
            // 
            // Txt_Departamento
            // 
            this.Txt_Departamento.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Departamento.Location = new System.Drawing.Point(28, 266);
            this.Txt_Departamento.Name = "Txt_Departamento";
            this.Txt_Departamento.Size = new System.Drawing.Size(226, 34);
            this.Txt_Departamento.TabIndex = 6;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado.Location = new System.Drawing.Point(28, 346);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(226, 34);
            this.Txt_Estado.TabIndex = 7;
            // 
            // Btn_Insertar
            // 
            this.Btn_Insertar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Insertar.Location = new System.Drawing.Point(12, 466);
            this.Btn_Insertar.Name = "Btn_Insertar";
            this.Btn_Insertar.Size = new System.Drawing.Size(114, 30);
            this.Btn_Insertar.TabIndex = 8;
            this.Btn_Insertar.Text = "Insertar";
            this.Btn_Insertar.UseVisualStyleBackColor = true;
            this.Btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Location = new System.Drawing.Point(132, 466);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(114, 30);
            this.Btn_modificar.TabIndex = 9;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(249, 466);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(114, 30);
            this.Btn_Eliminar.TabIndex = 10;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Frm_Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 508);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_Insertar);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.Txt_Departamento);
            this.Controls.Add(this.Txt_IdDepartamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Dgv_Departamentos);
            this.Name = "Frm_Departamentos";
            this.Text = "Frm_Departamentos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Departamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Departamentos;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_IdDepartamento;
        private System.Windows.Forms.TextBox Txt_Departamento;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Button Btn_Insertar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
    }
}