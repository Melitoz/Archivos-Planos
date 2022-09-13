
namespace Lectura_de_Archivos_Planos
{
    partial class frmtxt
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
            this.btnleer = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.rtxt1 = new System.Windows.Forms.RichTextBox();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.btnregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(587, 38);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(96, 23);
            this.btnleer.TabIndex = 0;
            this.btnleer.Text = "Leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(587, 67);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(96, 23);
            this.btnmod.TabIndex = 1;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(587, 8);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(96, 23);
            this.btncrear.TabIndex = 2;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(587, 96);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(96, 23);
            this.btnborrar.TabIndex = 3;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // rtxt1
            // 
            this.rtxt1.Location = new System.Drawing.Point(12, 49);
            this.rtxt1.Name = "rtxt1";
            this.rtxt1.Size = new System.Drawing.Size(569, 298);
            this.rtxt1.TabIndex = 4;
            this.rtxt1.Text = "";
            // 
            // openfile
            // 
            this.openfile.FileName = "openFileDialog1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 377);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(109, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Ubicacion de Archivo";
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(126, 375);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(503, 20);
            this.txtruta.TabIndex = 6;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(587, 125);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(96, 23);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnsave_click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 18);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(100, 13);
            this.lblnombre.TabIndex = 8;
            this.lblnombre.Text = "Nombre del Archivo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(118, 11);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(463, 20);
            this.txtnombre.TabIndex = 9;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(587, 154);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(96, 23);
            this.btnregresar.TabIndex = 10;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // frmtxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 417);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.rtxt1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnleer);
            this.Name = "frmtxt";
            this.Text = "Archivos .txt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.RichTextBox rtxt1;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.Button btnregresar;
    }
}

