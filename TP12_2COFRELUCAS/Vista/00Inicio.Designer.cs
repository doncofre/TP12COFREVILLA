
namespace TP12_2COFRELUCAS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Modelo = new System.Windows.Forms.Button();
            this.Pieza = new System.Windows.Forms.Button();
            this.Pedidos = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.StockPiezas = new System.Windows.Forms.Button();
            this.Composicion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Modelo
            // 
            this.Modelo.Location = new System.Drawing.Point(162, 143);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(148, 91);
            this.Modelo.TabIndex = 0;
            this.Modelo.Text = "Modelo";
            this.Modelo.UseVisualStyleBackColor = true;
            this.Modelo.Click += new System.EventHandler(this.Modelo_Click);
            // 
            // Pieza
            // 
            this.Pieza.Location = new System.Drawing.Point(443, 143);
            this.Pieza.Name = "Pieza";
            this.Pieza.Size = new System.Drawing.Size(148, 91);
            this.Pieza.TabIndex = 1;
            this.Pieza.Text = "Pieza";
            this.Pieza.UseVisualStyleBackColor = true;
            this.Pieza.Click += new System.EventHandler(this.Pieza_Click);
            // 
            // Pedidos
            // 
            this.Pedidos.Location = new System.Drawing.Point(82, 36);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(90, 23);
            this.Pedidos.TabIndex = 2;
            this.Pedidos.Text = "Ver Pedidos";
            this.Pedidos.UseVisualStyleBackColor = true;
            this.Pedidos.Click += new System.EventHandler(this.Pedidos_Click);
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(235, 36);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(87, 23);
            this.Stock.TabIndex = 3;
            this.Stock.Text = "Ver Stock";
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // StockPiezas
            // 
            this.StockPiezas.Location = new System.Drawing.Point(427, 36);
            this.StockPiezas.Name = "StockPiezas";
            this.StockPiezas.Size = new System.Drawing.Size(91, 23);
            this.StockPiezas.TabIndex = 4;
            this.StockPiezas.Text = "Stock de piezas";
            this.StockPiezas.UseVisualStyleBackColor = true;
            this.StockPiezas.Click += new System.EventHandler(this.StockPiezas_Click);
            // 
            // Composicion
            // 
            this.Composicion.Location = new System.Drawing.Point(573, 36);
            this.Composicion.Name = "Composicion";
            this.Composicion.Size = new System.Drawing.Size(95, 23);
            this.Composicion.TabIndex = 5;
            this.Composicion.Text = "Composicion";
            this.Composicion.UseVisualStyleBackColor = true;
            this.Composicion.Click += new System.EventHandler(this.Composicion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Composicion);
            this.Controls.Add(this.StockPiezas);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Pedidos);
            this.Controls.Add(this.Pieza);
            this.Controls.Add(this.Modelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Modelo;
        private System.Windows.Forms.Button Pieza;
        private System.Windows.Forms.Button Pedidos;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button StockPiezas;
        private System.Windows.Forms.Button Composicion;
    }
}

