namespace AirTransport.GUI
{
    partial class FrmPassengers
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
            this.dgvAllPassengers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllPassengers
            // 
            this.dgvAllPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPassengers.Location = new System.Drawing.Point(153, 81);
            this.dgvAllPassengers.Name = "dgvAllPassengers";
            this.dgvAllPassengers.Size = new System.Drawing.Size(494, 288);
            this.dgvAllPassengers.TabIndex = 4;
            // 
            // FrmPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllPassengers);
            this.Name = "FrmPassengers";
            this.Text = "FrmPassengers";
            this.Load += new System.EventHandler(this.FrmPassengers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPassengers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllPassengers;
    }
}