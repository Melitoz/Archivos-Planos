namespace Lectura_de_Archivos_Planos
{
    partial class frmselect
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
            this.btntxt = new System.Windows.Forms.Button();
            this.btncsv = new System.Windows.Forms.Button();
            this.btnrft = new System.Windows.Forms.Button();
            this.btnxml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntxt
            // 
            this.btntxt.Location = new System.Drawing.Point(76, 76);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(80, 80);
            this.btntxt.TabIndex = 0;
            this.btntxt.Text = "Arhivos .txt";
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // btncsv
            // 
            this.btncsv.Location = new System.Drawing.Point(217, 76);
            this.btncsv.Name = "btncsv";
            this.btncsv.Size = new System.Drawing.Size(80, 80);
            this.btncsv.TabIndex = 1;
            this.btncsv.Text = "Archivos .csv";
            this.btncsv.UseVisualStyleBackColor = true;
            this.btncsv.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrft
            // 
            this.btnrft.Location = new System.Drawing.Point(76, 205);
            this.btnrft.Name = "btnrft";
            this.btnrft.Size = new System.Drawing.Size(80, 80);
            this.btnrft.TabIndex = 2;
            this.btnrft.Text = "Archivos .rtf";
            this.btnrft.UseVisualStyleBackColor = true;
            this.btnrft.Click += new System.EventHandler(this.btnrft_Click);
            // 
            // btnxml
            // 
            this.btnxml.Location = new System.Drawing.Point(217, 205);
            this.btnxml.Name = "btnxml";
            this.btnxml.Size = new System.Drawing.Size(80, 80);
            this.btnxml.TabIndex = 3;
            this.btnxml.Text = "Archivos .xml";
            this.btnxml.UseVisualStyleBackColor = true;
            this.btnxml.Click += new System.EventHandler(this.btnxml_Click);
            // 
            // frmselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnxml);
            this.Controls.Add(this.btnrft);
            this.Controls.Add(this.btncsv);
            this.Controls.Add(this.btntxt);
            this.Name = "frmselect";
            this.Text = "Seleccion de Archivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.Button btncsv;
        private System.Windows.Forms.Button btnrft;
        private System.Windows.Forms.Button btnxml;
    }
}