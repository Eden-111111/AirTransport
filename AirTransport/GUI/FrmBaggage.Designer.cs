namespace AirTransport.GUI
{
    partial class FrmBaggage
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
            this.dgvAllBaggage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBaggage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllBaggage
            // 
            this.dgvAllBaggage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBaggage.Location = new System.Drawing.Point(153, 81);
            this.dgvAllBaggage.Name = "dgvAllBaggage";
            this.dgvAllBaggage.Size = new System.Drawing.Size(494, 288);
            this.dgvAllBaggage.TabIndex = 3;
            // 
            // FrmBaggage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllBaggage);
            this.Name = "FrmBaggage";
            this.Text = "FrmBaggage";
            this.Load += new System.EventHandler(this.FrmBaggage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBaggage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllBaggage;
    }
}