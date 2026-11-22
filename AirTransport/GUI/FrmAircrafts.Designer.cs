namespace AirTransport.GUI
{
    partial class FrmAircrafts
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
            this.dgvAllAircrafts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAircrafts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllAircrafts
            // 
            this.dgvAllAircrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAircrafts.Location = new System.Drawing.Point(33, 66);
            this.dgvAllAircrafts.Name = "dgvAllAircrafts";
            this.dgvAllAircrafts.Size = new System.Drawing.Size(494, 288);
            this.dgvAllAircrafts.TabIndex = 1;
            // 
            // FrmAircrafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllAircrafts);
            this.Name = "FrmAircrafts";
            this.Text = "FrmAircrafts";
            this.Load += new System.EventHandler(this.FrmAircrafts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAircrafts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllAircrafts;
    }
}