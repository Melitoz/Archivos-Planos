namespace Lectura_de_Archivos_Planos
{
    partial class frmrtf
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
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnleer = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.font = new System.Windows.Forms.FontDialog();
            this.opnfile = new System.Windows.Forms.OpenFileDialog();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.font1 = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt
            // 
            this.rtxt.Location = new System.Drawing.Point(12, 49);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(569, 298);
            this.rtxt.TabIndex = 0;
            this.rtxt.Text = "";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(598, 167);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(96, 23);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(598, 138);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(96, 23);
            this.btnborrar.TabIndex = 9;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(598, 109);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(96, 23);
            this.btnmod.TabIndex = 10;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(598, 80);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(96, 23);
            this.btnleer.TabIndex = 11;
            this.btnleer.Text = "Leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(598, 51);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(96, 23);
            this.btncrear.TabIndex = 12;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 18);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(100, 13);
            this.lblnombre.TabIndex = 13;
            this.lblnombre.Text = "Nombre del Archivo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(118, 15);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(463, 20);
            this.txtnombre.TabIndex = 14;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 381);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(109, 13);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Ubicacion de Archivo";
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(127, 378);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(503, 20);
            this.txtruta.TabIndex = 16;
            // 
            // opnfile
            // 
            this.opnfile.FileName = "openFileDialog1";
            // 
            // font1
            // 
            this.font1.Location = new System.Drawing.Point(598, 196);
            this.font1.Name = "font1";
            this.font1.Size = new System.Drawing.Size(96, 23);
            this.font1.TabIndex = 17;
            this.font1.Text = "Fuente";
            this.font1.UseVisualStyleBackColor = true;
            this.font1.Click += new System.EventHandler(this.font1_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(598, 225);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(96, 23);
            this.btnregresar.TabIndex = 18;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // frmrtf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 417);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.font1);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rtxt);
            this.Name = "frmrtf";
            this.Text = "Archivo rtf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.FontDialog font;
        private System.Windows.Forms.OpenFileDialog opnfile;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.Button font1;
        private System.Windows.Forms.Button btnregresar;
    }
}