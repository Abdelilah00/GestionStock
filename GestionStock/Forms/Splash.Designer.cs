namespace GestionStock
{
    partial class Splash
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripLabel();
            this.produit_qte = new System.Windows.Forms.Label();
            this.qte_vendu = new System.Windows.Forms.Label();
            this.client_nbr = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(46, 22);
            this.toolStripTextBox1.Text = "Facture";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(38, 22);
            this.toolStripTextBox2.Text = "Client";
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(49, 22);
            this.toolStripTextBox3.Text = "Product";
            this.toolStripTextBox3.Click += new System.EventHandler(this.toolStripTextBox3_Click);
            // 
            // produit_qte
            // 
            this.produit_qte.AutoSize = true;
            this.produit_qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit_qte.Location = new System.Drawing.Point(209, 114);
            this.produit_qte.Name = "produit_qte";
            this.produit_qte.Size = new System.Drawing.Size(120, 25);
            this.produit_qte.TabIndex = 3;
            this.produit_qte.Text = "Produit Qte";
            // 
            // qte_vendu
            // 
            this.qte_vendu.AutoSize = true;
            this.qte_vendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_vendu.Location = new System.Drawing.Point(209, 260);
            this.qte_vendu.Name = "qte_vendu";
            this.qte_vendu.Size = new System.Drawing.Size(120, 25);
            this.qte_vendu.TabIndex = 4;
            this.qte_vendu.Text = "Produit Qte";
            // 
            // client_nbr
            // 
            this.client_nbr.AutoSize = true;
            this.client_nbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_nbr.Location = new System.Drawing.Point(209, 187);
            this.client_nbr.Name = "client_nbr";
            this.client_nbr.Size = new System.Drawing.Size(120, 25);
            this.client_nbr.TabIndex = 5;
            this.client_nbr.Text = "Produit Qte";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 439);
            this.Controls.Add(this.client_nbr);
            this.Controls.Add(this.qte_vendu);
            this.Controls.Add(this.produit_qte);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Splash";
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox3;
        private System.Windows.Forms.Label produit_qte;
        private System.Windows.Forms.Label qte_vendu;
        private System.Windows.Forms.Label client_nbr;
    }
}

