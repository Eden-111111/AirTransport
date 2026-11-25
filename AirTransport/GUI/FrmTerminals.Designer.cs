namespace AirTransport.GUI
{
    partial class FrmTerminals
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
            this.dgvAllTerminals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTerminals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTerminals
            // 
            this.dgvAllTerminals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTerminals.Location = new System.Drawing.Point(153, 81);
            this.dgvAllTerminals.Name = "dgvAllTerminals";
            this.dgvAllTerminals.Size = new System.Drawing.Size(494, 288);
            this.dgvAllTerminals.TabIndex = 3;
            // 
            // FrmTerminals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllTerminals);
            this.Name = "FrmTerminals";
            this.Text = "FrmTerminals";
            this.Load += new System.EventHandler(this.FrmTerminals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTerminals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllTerminals;
    }
}