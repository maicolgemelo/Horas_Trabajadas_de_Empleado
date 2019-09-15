namespace Horas_Trabajadas_de_Empleado
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
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.lblHorasTrabajadas = new System.Windows.Forms.Label();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotalSalario = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(275, 57);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(100, 26);
            this.txtHorasTrabajadas.TabIndex = 0;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHora.Location = new System.Drawing.Point(275, 134);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(100, 26);
            this.txtValorHora.TabIndex = 1;
            // 
            // lblHorasTrabajadas
            // 
            this.lblHorasTrabajadas.AutoSize = true;
            this.lblHorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabajadas.Location = new System.Drawing.Point(57, 63);
            this.lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            this.lblHorasTrabajadas.Size = new System.Drawing.Size(201, 20);
            this.lblHorasTrabajadas.TabIndex = 2;
            this.lblHorasTrabajadas.Text = "Ingrese Horas Trabajadas: ";
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHora.Location = new System.Drawing.Point(95, 140);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(151, 20);
            this.lblValorHora.TabIndex = 3;
            this.lblValorHora.Text = "Ingrese Valor Hora: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(522, 90);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 36);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotalSalario
            // 
            this.lblTotalSalario.AutoSize = true;
            this.lblTotalSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalario.Location = new System.Drawing.Point(195, 286);
            this.lblTotalSalario.Name = "lblTotalSalario";
            this.lblTotalSalario.Size = new System.Drawing.Size(97, 20);
            this.lblTotalSalario.TabIndex = 5;
            this.lblTotalSalario.Text = "Total Salario";
            this.lblTotalSalario.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(522, 160);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(115, 35);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblTotalSalario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.lblHorasTrabajadas);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label lblHorasTrabajadas;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotalSalario;
        private System.Windows.Forms.Button btnBorrar;
    }
}

