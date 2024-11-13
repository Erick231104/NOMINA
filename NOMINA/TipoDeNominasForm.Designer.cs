namespace NOMINA
{
    partial class TipoDeNominasForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNominasMensuales = new System.Windows.Forms.Button();
            this.btnNominaiQuincenal = new System.Windows.Forms.Button();
            this.btnNominaDeLote = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoge un Tipo de Nomina";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNominaDeLote);
            this.groupBox1.Controls.Add(this.btnNominaiQuincenal);
            this.groupBox1.Controls.Add(this.btnNominasMensuales);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(122, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nominas ";
            // 
            // btnNominasMensuales
            // 
            this.btnNominasMensuales.Location = new System.Drawing.Point(35, 47);
            this.btnNominasMensuales.Name = "btnNominasMensuales";
            this.btnNominasMensuales.Size = new System.Drawing.Size(121, 94);
            this.btnNominasMensuales.TabIndex = 0;
            this.btnNominasMensuales.Text = "Nomina Mensual";
            this.btnNominasMensuales.UseVisualStyleBackColor = true;
            // 
            // btnNominaiQuincenal
            // 
            this.btnNominaiQuincenal.Location = new System.Drawing.Point(213, 47);
            this.btnNominaiQuincenal.Name = "btnNominaiQuincenal";
            this.btnNominaiQuincenal.Size = new System.Drawing.Size(121, 94);
            this.btnNominaiQuincenal.TabIndex = 1;
            this.btnNominaiQuincenal.Text = "Nomina Quincenal ";
            this.btnNominaiQuincenal.UseVisualStyleBackColor = true;
            // 
            // btnNominaDeLote
            // 
            this.btnNominaDeLote.Location = new System.Drawing.Point(403, 47);
            this.btnNominaDeLote.Name = "btnNominaDeLote";
            this.btnNominaDeLote.Size = new System.Drawing.Size(121, 94);
            this.btnNominaDeLote.TabIndex = 2;
            this.btnNominaDeLote.Text = "Nomina de Lote";
            this.btnNominaDeLote.UseVisualStyleBackColor = true;
            // 
            // TipoDeNominasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TipoDeNominasForm";
            this.Text = "TipoDeNominasForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNominaDeLote;
        private System.Windows.Forms.Button btnNominaiQuincenal;
        private System.Windows.Forms.Button btnNominasMensuales;
    }
}