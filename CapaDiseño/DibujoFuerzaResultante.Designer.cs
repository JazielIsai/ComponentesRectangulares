namespace CapaDiseño
{
    partial class DibujoFuerzaResultante
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
            this.pnGrafica = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnGrafica.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnGrafica
            // 
            this.pnGrafica.Controls.Add(this.label1);
            this.pnGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGrafica.Location = new System.Drawing.Point(0, 0);
            this.pnGrafica.Name = "pnGrafica";
            this.pnGrafica.Size = new System.Drawing.Size(684, 661);
            this.pnGrafica.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // DibujoFuerzaResultante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.pnGrafica);
            this.Name = "DibujoFuerzaResultante";
            this.Text = "DibujoFuerzaResultante";
            this.Load += new System.EventHandler(this.DibujoFuerzaResultante_Load);
            this.pnGrafica.ResumeLayout(false);
            this.pnGrafica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnGrafica;
        private System.Windows.Forms.Label label1;
    }
}