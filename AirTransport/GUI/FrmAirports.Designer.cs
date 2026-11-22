namespace AirTransport.GUI
{
    partial class FrmAirports
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
            this.dgvAllAirports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAirports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllAirports
            // 
            this.dgvAllAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAirports.Location = new System.Drawing.Point(153, 81);
            this.dgvAllAirports.Name = "dgvAllAirports";
            this.dgvAllAirports.Size = new System.Drawing.Size(494, 288);
            this.dgvAllAirports.TabIndex = 2;
            // 
            // FrmAirports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllAirports);
            this.Name = "FrmAirports";
            this.Text = "FrmAirports";
            this.Load += new System.EventHandler(this.FrmAirports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAirports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllAirports;
    }
}