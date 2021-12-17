
namespace TP12_2COFRELUCAS.Vista
{
    partial class _04Composicion
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
            this.dgvComposicion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComposicion
            // 
            this.dgvComposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComposicion.Location = new System.Drawing.Point(12, 12);
            this.dgvComposicion.Name = "dgvComposicion";
            this.dgvComposicion.Size = new System.Drawing.Size(745, 389);
            this.dgvComposicion.TabIndex = 0;
            this.dgvComposicion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComposicion_CellContentClick);
            // 
            // _04Composicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvComposicion);
            this.Name = "_04Composicion";
            this.Text = "_04Composicion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComposicion;
    }
}