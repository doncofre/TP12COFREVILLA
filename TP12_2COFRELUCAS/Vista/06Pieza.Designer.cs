
namespace TP12_2COFRELUCAS.Vista
{
    partial class _06Pieza
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
            this.dgvPieza = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieza)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPieza
            // 
            this.dgvPieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieza.Location = new System.Drawing.Point(12, 12);
            this.dgvPieza.Name = "dgvPieza";
            this.dgvPieza.Size = new System.Drawing.Size(756, 407);
            this.dgvPieza.TabIndex = 0;
            this.dgvPieza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPieza_CellContentClick);
            // 
            // _06Pieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPieza);
            this.Name = "_06Pieza";
            this.Text = "_06Pieza";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPieza;
    }
}