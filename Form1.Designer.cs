namespace Práctica1_AFGB
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Start_Camera = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.Button();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Reiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 50);
            this.label1.TabIndex = 14;
            this.label1.Text = "Video en vivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 456);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 237);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Start_Camera
            // 
            this.Start_Camera.BackColor = System.Drawing.Color.Red;
            this.Start_Camera.Location = new System.Drawing.Point(244, 456);
            this.Start_Camera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_Camera.Name = "Start_Camera";
            this.Start_Camera.Size = new System.Drawing.Size(122, 37);
            this.Start_Camera.TabIndex = 12;
            this.Start_Camera.Text = "Iniciar cámara";
            this.Start_Camera.UseVisualStyleBackColor = false;
            this.Start_Camera.Click += new System.EventHandler(this.Start_Camera_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(31, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Lime;
            this.guardar.Location = new System.Drawing.Point(244, 642);
            this.guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(122, 37);
            this.guardar.TabIndex = 16;
            this.guardar.Text = "Guardar datos";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // temporizador
            // 
            this.temporizador.Interval = 5000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(31, 411);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 50);
            this.label3.TabIndex = 17;
            this.label3.Text = "Registros datos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(640, 83);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(717, 319);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Orange;
            this.Stop.Location = new System.Drawing.Point(244, 517);
            this.Stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(122, 37);
            this.Stop.TabIndex = 19;
            this.Stop.Text = "Detener cámara";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reiniciar
            // 
            this.Reiniciar.BackColor = System.Drawing.Color.Aqua;
            this.Reiniciar.Location = new System.Drawing.Point(244, 579);
            this.Reiniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(122, 37);
            this.Reiniciar.TabIndex = 20;
            this.Reiniciar.Text = "Reiniciar cámara";
            this.Reiniciar.UseVisualStyleBackColor = false;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Start_Camera);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Start_Camera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Reiniciar;
    }
}

