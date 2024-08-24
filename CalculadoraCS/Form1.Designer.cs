namespace CalculadoraCS
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
            this.tbdisplay = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.divicion = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bcoma = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbdisplay
            // 
            this.tbdisplay.BackColor = System.Drawing.SystemColors.Menu;
            this.tbdisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbdisplay.Font = new System.Drawing.Font("Segoe UI", 27.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbdisplay.Location = new System.Drawing.Point(12, 12);
            this.tbdisplay.Multiline = true;
            this.tbdisplay.Name = "tbdisplay";
            this.tbdisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbdisplay.Size = new System.Drawing.Size(306, 80);
            this.tbdisplay.TabIndex = 0;
            this.tbdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbdisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCE
            // 
            this.bCE.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.bCE.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bCE.Location = new System.Drawing.Point(90, 98);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(72, 52);
            this.bCE.TabIndex = 3;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = false;
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.bC.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bC.Location = new System.Drawing.Point(168, 99);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(72, 52);
            this.bC.TabIndex = 4;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.borrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.Location = new System.Drawing.Point(246, 99);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(72, 52);
            this.borrar.TabIndex = 5;
            this.borrar.Text = "⌫";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.button5.Location = new System.Drawing.Point(12, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 52);
            this.button5.TabIndex = 6;
            this.button5.Text = "¹/×";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.button6.Location = new System.Drawing.Point(90, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 52);
            this.button6.TabIndex = 7;
            this.button6.Text = "x²";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // divicion
            // 
            this.divicion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.divicion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divicion.Location = new System.Drawing.Point(246, 157);
            this.divicion.Name = "divicion";
            this.divicion.Size = new System.Drawing.Size(72, 52);
            this.divicion.TabIndex = 9;
            this.divicion.Text = "÷";
            this.divicion.UseVisualStyleBackColor = false;
            this.divicion.Click += new System.EventHandler(this.divicion_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.Window;
            this.b7.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b7.Location = new System.Drawing.Point(12, 215);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(72, 52);
            this.b7.TabIndex = 10;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.Window;
            this.b8.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b8.Location = new System.Drawing.Point(90, 215);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(72, 52);
            this.b8.TabIndex = 11;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.Window;
            this.b9.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b9.Location = new System.Drawing.Point(168, 215);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(72, 52);
            this.b9.TabIndex = 12;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.multiplicacion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.multiplicacion.Location = new System.Drawing.Point(246, 215);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(72, 52);
            this.multiplicacion.TabIndex = 13;
            this.multiplicacion.Text = "×";
            this.multiplicacion.UseVisualStyleBackColor = false;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.Window;
            this.b4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b4.Location = new System.Drawing.Point(12, 273);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(72, 52);
            this.b4.TabIndex = 14;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.Window;
            this.b5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b5.Location = new System.Drawing.Point(90, 273);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(72, 52);
            this.b5.TabIndex = 15;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.Window;
            this.b6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b6.Location = new System.Drawing.Point(168, 273);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(72, 52);
            this.b6.TabIndex = 16;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.resta.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.resta.Location = new System.Drawing.Point(245, 273);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(72, 52);
            this.resta.TabIndex = 17;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Window;
            this.b1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b1.Location = new System.Drawing.Point(12, 331);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(72, 52);
            this.b1.TabIndex = 18;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.Window;
            this.b3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b3.Location = new System.Drawing.Point(167, 331);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(72, 52);
            this.b3.TabIndex = 20;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.suma.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.suma.Location = new System.Drawing.Point(245, 331);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(72, 52);
            this.suma.TabIndex = 21;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.Window;
            this.button21.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.button21.Location = new System.Drawing.Point(12, 389);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 52);
            this.button21.TabIndex = 22;
            this.button21.Text = "+/-";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.Window;
            this.b0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b0.FlatAppearance.BorderSize = 0;
            this.b0.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b0.Location = new System.Drawing.Point(90, 389);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(72, 52);
            this.b0.TabIndex = 23;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bcoma
            // 
            this.bcoma.BackColor = System.Drawing.SystemColors.Window;
            this.bcoma.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bcoma.Location = new System.Drawing.Point(168, 389);
            this.bcoma.Name = "bcoma";
            this.bcoma.Size = new System.Drawing.Size(72, 52);
            this.bcoma.TabIndex = 24;
            this.bcoma.Text = ",";
            this.bcoma.UseVisualStyleBackColor = false;
            this.bcoma.Click += new System.EventHandler(this.bcoma_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.SystemColors.Highlight;
            this.igual.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.igual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.igual.Location = new System.Drawing.Point(245, 389);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(72, 52);
            this.igual.TabIndex = 25;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.Window;
            this.b2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.b2.Location = new System.Drawing.Point(90, 331);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(72, 52);
            this.b2.TabIndex = 26;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.button2.Location = new System.Drawing.Point(168, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 52);
            this.button2.TabIndex = 27;
            this.button2.Text = " √x";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(329, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.bcoma);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.divicion);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbdisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbdisplay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button divicion;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bcoma;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button button2;
    }
}

