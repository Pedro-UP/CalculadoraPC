namespace CalculadoraPC
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnres = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnporcentaje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Digital-7 Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 46);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "0.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.UseWaitCursor = true;
            // 
            // btn7
            // 
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderSize = 10;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn7.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(27, 123);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 44);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderSize = 10;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn8.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(119, 123);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 44);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderSize = 10;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn9.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(214, 123);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 44);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderSize = 10;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn4.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(27, 200);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 44);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderSize = 10;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn5.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(119, 200);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 44);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderSize = 10;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn6.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(214, 200);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 44);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 10;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn1.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(27, 276);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 44);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 10;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn2.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(119, 276);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 44);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 10;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(214, 276);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 44);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 10;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button10.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(27, 350);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(161, 44);
            this.button10.TabIndex = 0;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 10;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(214, 350);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(69, 44);
            this.button11.TabIndex = 11;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnce
            // 
            this.btnce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnce.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnce.FlatAppearance.BorderSize = 10;
            this.btnce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnce.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnce.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnce.Location = new System.Drawing.Point(440, 123);
            this.btnce.Margin = new System.Windows.Forms.Padding(0);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(69, 44);
            this.btnce.TabIndex = 12;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btnc
            // 
            this.btnc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnc.FlatAppearance.BorderSize = 10;
            this.btnc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnc.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc.Location = new System.Drawing.Point(347, 123);
            this.btnc.Margin = new System.Windows.Forms.Padding(0);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(69, 44);
            this.btnc.TabIndex = 13;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnres
            // 
            this.btnres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnres.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnres.FlatAppearance.BorderSize = 10;
            this.btnres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnres.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnres.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnres.Location = new System.Drawing.Point(440, 200);
            this.btnres.Margin = new System.Windows.Forms.Padding(0);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(69, 44);
            this.btnres.TabIndex = 14;
            this.btnres.Text = "-";
            this.btnres.UseVisualStyleBackColor = true;
            this.btnres.Click += new System.EventHandler(this.btOperacion);
            // 
            // btndiv
            // 
            this.btndiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndiv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndiv.FlatAppearance.BorderSize = 10;
            this.btndiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndiv.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(347, 200);
            this.btndiv.Margin = new System.Windows.Forms.Padding(0);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(69, 44);
            this.btndiv.TabIndex = 15;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btOperacion);
            // 
            // btnsum
            // 
            this.btnsum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsum.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsum.FlatAppearance.BorderSize = 10;
            this.btnsum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnsum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsum.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsum.Location = new System.Drawing.Point(440, 276);
            this.btnsum.Margin = new System.Windows.Forms.Padding(0);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(69, 44);
            this.btnsum.TabIndex = 16;
            this.btnsum.Text = "+";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btOperacion);
            // 
            // btnmult
            // 
            this.btnmult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmult.FlatAppearance.BorderSize = 10;
            this.btnmult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmult.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.Location = new System.Drawing.Point(347, 276);
            this.btnmult.Margin = new System.Windows.Forms.Padding(0);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(69, 44);
            this.btnmult.TabIndex = 17;
            this.btnmult.Text = "x";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btOperacion);
            // 
            // btnigual
            // 
            this.btnigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnigual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnigual.FlatAppearance.BorderSize = 10;
            this.btnigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnigual.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(347, 350);
            this.btnigual.Margin = new System.Windows.Forms.Padding(0);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(69, 44);
            this.btnigual.TabIndex = 18;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btOperacion);
            // 
            // btnporcentaje
            // 
            this.btnporcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnporcentaje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnporcentaje.FlatAppearance.BorderSize = 10;
            this.btnporcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnporcentaje.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnporcentaje.Font = new System.Drawing.Font("Digital-7 Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcentaje.Location = new System.Drawing.Point(440, 350);
            this.btnporcentaje.Margin = new System.Windows.Forms.Padding(0);
            this.btnporcentaje.Name = "btnporcentaje";
            this.btnporcentaje.Size = new System.Drawing.Size(69, 44);
            this.btnporcentaje.TabIndex = 19;
            this.btnporcentaje.Text = "%";
            this.btnporcentaje.UseVisualStyleBackColor = true;
            this.btnporcentaje.Click += new System.EventHandler(this.btnporcentaje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kunstler Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ingeniro Pedro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadoraPC.Properties.Resources.dio;
            this.pictureBox1.Location = new System.Drawing.Point(214, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnporcentaje);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Click += new System.EventHandler(this.btOperacion);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnres;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnporcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

