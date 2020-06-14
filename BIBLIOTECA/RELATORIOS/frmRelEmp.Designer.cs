namespace BIBLIOTECA.RELATORIOS
{
    partial class frmRelEmp
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
            this.txtEmprestimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRel1 = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empréstimo:";
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmprestimo.Location = new System.Drawing.Point(146, 22);
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(121, 29);
            this.txtEmprestimo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Fim:";
            // 
            // btnRel1
            // 
            this.btnRel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRel1.Location = new System.Drawing.Point(337, 29);
            this.btnRel1.Name = "btnRel1";
            this.btnRel1.Size = new System.Drawing.Size(96, 36);
            this.btnRel1.TabIndex = 6;
            this.btnRel1.Text = "EPPlus";
            this.btnRel1.UseVisualStyleBackColor = true;
            this.btnRel1.Click += new System.EventHandler(this.btnRel1_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(146, 69);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(121, 29);
            this.dtpInicio.TabIndex = 8;
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(146, 113);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(121, 29);
            this.dtpFim.TabIndex = 9;
            // 
            // frmRelEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 220);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnRel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmprestimo);
            this.Controls.Add(this.label1);
            this.Name = "frmRelEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelEmp";
            this.Load += new System.EventHandler(this.frmRelEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmprestimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRel1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
    }
}