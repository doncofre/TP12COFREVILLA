
namespace TP12_2COFRELUCAS.Vista
{
    partial class _03StockPiezas
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
            this.dgvStockPiezas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockPiezas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockPiezas
            // 
            this.dgvStockPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockPiezas.Location = new System.Drawing.Point(21, 12);
            this.dgvStockPiezas.Name = "dgvStockPiezas";
            this.dgvStockPiezas.Size = new System.Drawing.Size(681, 355);
            this.dgvStockPiezas.TabIndex = 0;
            this.dgvStockPiezas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockPiezas_CellContentClick);
            // 
            // _03StockPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStockPiezas);
            this.Name = "_03StockPiezas";
            this.Text = "_03StockPiezas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockPiezas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockPiezas;
    }
}