namespace CalculadoraBasica
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.pantalla = new System.Windows.Forms.TextBox();
            this.ce = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.teclado = new System.Windows.Forms.GroupBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPor = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnSen = new System.Windows.Forms.Button();
            this.btCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.vercion = new System.Windows.Forms.Label();
            this.teclado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pantalla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pantalla.Cursor = System.Windows.Forms.Cursors.Default;
            this.pantalla.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(8, 36);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(298, 44);
            this.pantalla.TabIndex = 0;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.Color.White;
            this.ce.Location = new System.Drawing.Point(190, 77);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(56, 52);
            this.ce.TabIndex = 1;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.White;
            this.C.Location = new System.Drawing.Point(192, 135);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(54, 52);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.White;
            this.bt7.Location = new System.Drawing.Point(10, 77);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(54, 52);
            this.bt7.TabIndex = 3;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.White;
            this.bt8.Location = new System.Drawing.Point(70, 77);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(54, 52);
            this.bt8.TabIndex = 4;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.White;
            this.bt9.Location = new System.Drawing.Point(130, 77);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(54, 52);
            this.bt9.TabIndex = 5;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.White;
            this.bt6.Location = new System.Drawing.Point(130, 135);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(54, 52);
            this.bt6.TabIndex = 8;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.White;
            this.bt5.Location = new System.Drawing.Point(70, 135);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(54, 52);
            this.bt5.TabIndex = 7;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.White;
            this.bt4.Location = new System.Drawing.Point(10, 135);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(54, 52);
            this.bt4.TabIndex = 6;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.White;
            this.bt3.Location = new System.Drawing.Point(130, 193);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(54, 52);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.White;
            this.bt2.Location = new System.Drawing.Point(70, 193);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(54, 52);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.White;
            this.bt1.Location = new System.Drawing.Point(10, 193);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(54, 52);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // teclado
            // 
            this.teclado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teclado.Controls.Add(this.btnDiv);
            this.teclado.Controls.Add(this.btnIgual);
            this.teclado.Controls.Add(this.btnLog);
            this.teclado.Controls.Add(this.btnPor);
            this.teclado.Controls.Add(this.btnLn);
            this.teclado.Controls.Add(this.btnMenos);
            this.teclado.Controls.Add(this.btnSen);
            this.teclado.Controls.Add(this.btCos);
            this.teclado.Controls.Add(this.btnMas);
            this.teclado.Controls.Add(this.btnTan);
            this.teclado.Controls.Add(this.btnN);
            this.teclado.Controls.Add(this.C);
            this.teclado.Controls.Add(this.ce);
            this.teclado.Controls.Add(this.btnPunto);
            this.teclado.Controls.Add(this.btn0);
            this.teclado.Controls.Add(this.bt3);
            this.teclado.Controls.Add(this.bt2);
            this.teclado.Controls.Add(this.bt7);
            this.teclado.Controls.Add(this.bt1);
            this.teclado.Controls.Add(this.bt8);
            this.teclado.Controls.Add(this.bt6);
            this.teclado.Controls.Add(this.bt9);
            this.teclado.Controls.Add(this.bt5);
            this.teclado.Controls.Add(this.bt4);
            this.teclado.Location = new System.Drawing.Point(-2, 86);
            this.teclado.Name = "teclado";
            this.teclado.Size = new System.Drawing.Size(317, 313);
            this.teclado.TabIndex = 12;
            this.teclado.TabStop = false;
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(252, 77);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(56, 52);
            this.btnDiv.TabIndex = 24;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPor
            // 
            this.btnPor.BackColor = System.Drawing.Color.White;
            this.btnPor.Location = new System.Drawing.Point(252, 135);
            this.btnPor.Name = "btnPor";
            this.btnPor.Size = new System.Drawing.Size(56, 52);
            this.btnPor.TabIndex = 23;
            this.btnPor.Text = "*";
            this.btnPor.UseVisualStyleBackColor = false;
            this.btnPor.Click += new System.EventHandler(this.btnPor_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.White;
            this.btnMenos.Location = new System.Drawing.Point(252, 193);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(56, 52);
            this.btnMenos.TabIndex = 22;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.White;
            this.btnMas.Location = new System.Drawing.Point(252, 251);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(56, 52);
            this.btnMas.TabIndex = 21;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(190, 193);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(56, 110);
            this.btnIgual.TabIndex = 20;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(233, 19);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(40, 52);
            this.btnLog.TabIndex = 19;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.Color.White;
            this.btnLn.Location = new System.Drawing.Point(279, 19);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(29, 52);
            this.btnLn.TabIndex = 18;
            this.btnLn.Text = "Ln";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnSen
            // 
            this.btnSen.BackColor = System.Drawing.Color.White;
            this.btnSen.Location = new System.Drawing.Point(11, 19);
            this.btnSen.Name = "btnSen";
            this.btnSen.Size = new System.Drawing.Size(53, 52);
            this.btnSen.TabIndex = 17;
            this.btnSen.Text = "Sen";
            this.btnSen.UseVisualStyleBackColor = false;
            this.btnSen.Click += new System.EventHandler(this.btnSen_Click);
            // 
            // btCos
            // 
            this.btCos.BackColor = System.Drawing.Color.White;
            this.btCos.Location = new System.Drawing.Point(70, 19);
            this.btCos.Name = "btCos";
            this.btCos.Size = new System.Drawing.Size(54, 52);
            this.btCos.TabIndex = 16;
            this.btCos.Text = "Cos";
            this.btCos.UseVisualStyleBackColor = false;
            this.btCos.Click += new System.EventHandler(this.btCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.White;
            this.btnTan.Location = new System.Drawing.Point(130, 19);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(54, 52);
            this.btnTan.TabIndex = 15;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.White;
            this.btnN.Location = new System.Drawing.Point(190, 19);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(37, 52);
            this.btnN.TabIndex = 14;
            this.btnN.Text = "x^n";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.White;
            this.btnPunto.Location = new System.Drawing.Point(130, 251);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(54, 52);
            this.btnPunto.TabIndex = 13;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(10, 251);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(114, 52);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logo.Location = new System.Drawing.Point(233, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(82, 24);
            this.logo.TabIndex = 13;
            this.logo.Text = "StarVip";
            // 
            // vercion
            // 
            this.vercion.AutoSize = true;
            this.vercion.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vercion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vercion.Location = new System.Drawing.Point(9, 16);
            this.vercion.Name = "vercion";
            this.vercion.Size = new System.Drawing.Size(53, 17);
            this.vercion.TabIndex = 14;
            this.vercion.Text = "Ver. 1.0.0";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 406);
            this.Controls.Add(this.vercion);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.teclado);
            this.Controls.Add(this.pantalla);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Calculadora";
            this.Text = "StarVip - Calculator";
            this.teclado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.GroupBox teclado;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btCos;
        private System.Windows.Forms.Button btnSen;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPor;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label vercion;
    }
}

