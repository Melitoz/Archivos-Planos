namespace Lectura_de_Archivos_Planos
{
    partial class frmcsv
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
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.btncrear = new System.Windows.Forms.Button();
            this.openfilecsv = new System.Windows.Forms.OpenFileDialog();
            this.btnleer = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid
            // 
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Location = new System.Drawing.Point(12, 12);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.Size = new System.Drawing.Size(569, 298);
            this.dtgrid.TabIndex = 0;
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(608, 81);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 1;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // openfilecsv
            // 
            this.openfilecsv.FileName = "openFileDialog1";
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(608, 110);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(75, 23);
            this.btnleer.TabIndex = 4;
            this.btnleer.Text = "Leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click_1);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(608, 139);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 7;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(608, 168);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(608, 197);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 9;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(608, 232);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 10;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // frmcsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 342);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.dtgrid);
            this.Name = "frmcsv";
            this.Text = "Archivo .csv";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.OpenFileDialog openfilecsv;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnregresar;
    }
}