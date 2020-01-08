namespace GestionStock.Forms.Facture
{
    partial class FactureEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.gerg = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.input_ref = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label1 = new System.Windows.Forms.Label();
            this.input_qte = new System.Windows.Forms.TextBox();
            this.cb_prod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product :";
            // 
            // gerg
            // 
            this.gerg.AutoSize = true;
            this.gerg.Location = new System.Drawing.Point(12, 28);
            this.gerg.Name = "gerg";
            this.gerg.Size = new System.Drawing.Size(57, 13);
            this.gerg.TabIndex = 8;
            this.gerg.Text = "Reference";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(75, 141);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // input_ref
            // 
            this.input_ref.Location = new System.Drawing.Point(90, 21);
            this.input_ref.Name = "input_ref";
            this.input_ref.Size = new System.Drawing.Size(100, 20);
            this.input_ref.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Qte Vendu:";
            // 
            // input_qte
            // 
            this.input_qte.Location = new System.Drawing.Point(90, 47);
            this.input_qte.Name = "input_qte";
            this.input_qte.Size = new System.Drawing.Size(100, 20);
            this.input_qte.TabIndex = 10;
            // 
            // cb_prod
            // 
            this.cb_prod.FormattingEnabled = true;
            this.cb_prod.Location = new System.Drawing.Point(90, 96);
            this.cb_prod.Name = "cb_prod";
            this.cb_prod.Size = new System.Drawing.Size(121, 21);
            this.cb_prod.TabIndex = 12;
            // 
            // FactureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 205);
            this.Controls.Add(this.cb_prod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_qte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gerg);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.input_ref);
            this.Name = "FactureEdit";
            this.Text = "FactureEdit";
            this.Load += new System.EventHandler(this.FactureEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gerg;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox input_ref;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_qte;
        private System.Windows.Forms.ComboBox cb_prod;
    }
}