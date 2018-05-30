namespace jueguitio
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
            this.jugar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.retirar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.credito = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tres = new System.Windows.Forms.PictureBox();
            this.dos = new System.Windows.Forms.PictureBox();
            this.uno = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.premio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uno)).BeginInit();
            this.SuspendLayout();
            // 
            // jugar
            // 
            this.jugar.Location = new System.Drawing.Point(538, 294);
            this.jugar.Name = "jugar";
            this.jugar.Size = new System.Drawing.Size(75, 23);
            this.jugar.TabIndex = 3;
            this.jugar.Text = "Jugar";
            this.jugar.UseVisualStyleBackColor = true;
            this.jugar.Click += new System.EventHandler(this.jugar_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(538, 323);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 4;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // retirar
            // 
            this.retirar.Location = new System.Drawing.Point(538, 352);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(75, 23);
            this.retirar.TabIndex = 5;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Creditos:";
            // 
            // credito
            // 
            this.credito.AutoSize = true;
            this.credito.Location = new System.Drawing.Point(559, 64);
            this.credito.Name = "credito";
            this.credito.Size = new System.Drawing.Size(27, 13);
            this.credito.TabIndex = 7;
            this.credito.Text = "num";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jueguitio:";
            // 
            // tres
            // 
            this.tres.Image = global::jueguitio.Properties.Resources.sandia;
            this.tres.Location = new System.Drawing.Point(387, 128);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(130, 106);
            this.tres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tres.TabIndex = 2;
            this.tres.TabStop = false;
            // 
            // dos
            // 
            this.dos.Image = global::jueguitio.Properties.Resources.manzana;
            this.dos.Location = new System.Drawing.Point(251, 128);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(130, 106);
            this.dos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dos.TabIndex = 1;
            this.dos.TabStop = false;
            // 
            // uno
            // 
            this.uno.BackgroundImage = global::jueguitio.Properties.Resources.manzana;
            this.uno.Image = global::jueguitio.Properties.Resources.banana;
            this.uno.Location = new System.Drawing.Point(115, 128);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(130, 106);
            this.uno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uno.TabIndex = 0;
            this.uno.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Premio total";
            // 
            // premio
            // 
            this.premio.AutoSize = true;
            this.premio.Location = new System.Drawing.Point(256, 263);
            this.premio.Name = "premio";
            this.premio.Size = new System.Drawing.Size(13, 13);
            this.premio.TabIndex = 10;
            this.premio.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "el limite de creditos es 99, si se exede o iguala esta cantidad, debe retirar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "3 sandias: + 15 creditos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "3 bananas: +9 creditos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "3 manzanas: +0 puntos;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 419);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.premio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.credito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.jugar);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox uno;
        private System.Windows.Forms.PictureBox dos;
        private System.Windows.Forms.PictureBox tres;
        private System.Windows.Forms.Button jugar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label credito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label premio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

