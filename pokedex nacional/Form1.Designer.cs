namespace pokedex_nacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ln = new System.Windows.Forms.Label();
            this.lP1 = new System.Windows.Forms.Label();
            this.lt2 = new System.Windows.Forms.Label();
            this.lt = new System.Windows.Forms.Label();
            this.lHp = new System.Windows.Forms.Label();
            this.lAt = new System.Windows.Forms.Label();
            this.lD = new System.Windows.Forms.Label();
            this.lsa = new System.Windows.Forms.Label();
            this.lSD = new System.Windows.Forms.Label();
            this.lV = new System.Windows.Forms.Label();
            this.Lg = new System.Windows.Forms.Label();
            this.lr = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Location = new System.Drawing.Point(65, 39);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(44, 13);
            this.ln.TabIndex = 1;
            this.ln.Text = "Nombre";
            // 
            // lP1
            // 
            this.lP1.AutoSize = true;
            this.lP1.Location = new System.Drawing.Point(65, 70);
            this.lP1.Name = "lP1";
            this.lP1.Size = new System.Drawing.Size(56, 13);
            this.lP1.TabIndex = 2;
            this.lP1.Text = "Primer tipo";
            // 
            // lt2
            // 
            this.lt2.AutoSize = true;
            this.lt2.Location = new System.Drawing.Point(65, 107);
            this.lt2.Name = "lt2";
            this.lt2.Size = new System.Drawing.Size(70, 13);
            this.lt2.TabIndex = 3;
            this.lt2.Text = "Segundo tipo";
            // 
            // lt
            // 
            this.lt.AutoSize = true;
            this.lt.Location = new System.Drawing.Point(65, 144);
            this.lt.Name = "lt";
            this.lt.Size = new System.Drawing.Size(31, 13);
            this.lt.TabIndex = 4;
            this.lt.Text = "Total";
            // 
            // lHp
            // 
            this.lHp.AutoSize = true;
            this.lHp.Location = new System.Drawing.Point(65, 182);
            this.lHp.Name = "lHp";
            this.lHp.Size = new System.Drawing.Size(22, 13);
            this.lHp.TabIndex = 5;
            this.lHp.Text = "HP";
            // 
            // lAt
            // 
            this.lAt.AutoSize = true;
            this.lAt.Location = new System.Drawing.Point(214, 39);
            this.lAt.Name = "lAt";
            this.lAt.Size = new System.Drawing.Size(41, 13);
            this.lAt.TabIndex = 6;
            this.lAt.Text = "Ataque";
            // 
            // lD
            // 
            this.lD.AutoSize = true;
            this.lD.Location = new System.Drawing.Point(214, 70);
            this.lD.Name = "lD";
            this.lD.Size = new System.Drawing.Size(47, 13);
            this.lD.TabIndex = 7;
            this.lD.Text = "Defensa";
            // 
            // lsa
            // 
            this.lsa.AutoSize = true;
            this.lsa.Location = new System.Drawing.Point(214, 107);
            this.lsa.Name = "lsa";
            this.lsa.Size = new System.Drawing.Size(84, 13);
            this.lsa.TabIndex = 8;
            this.lsa.Text = "Ataque Especial";
            // 
            // lSD
            // 
            this.lSD.AutoSize = true;
            this.lSD.Location = new System.Drawing.Point(214, 144);
            this.lSD.Name = "lSD";
            this.lSD.Size = new System.Drawing.Size(90, 13);
            this.lSD.TabIndex = 9;
            this.lSD.Text = "Defensa Especial";
            // 
            // lV
            // 
            this.lV.AutoSize = true;
            this.lV.Location = new System.Drawing.Point(214, 182);
            this.lV.Name = "lV";
            this.lV.Size = new System.Drawing.Size(54, 13);
            this.lV.TabIndex = 10;
            this.lV.Text = "Velocidad";
            // 
            // Lg
            // 
            this.Lg.AutoSize = true;
            this.Lg.Location = new System.Drawing.Point(65, 217);
            this.Lg.Name = "Lg";
            this.Lg.Size = new System.Drawing.Size(62, 13);
            this.Lg.TabIndex = 11;
            this.Lg.Text = "Generacion";
            // 
            // lr
            // 
            this.lr.AutoSize = true;
            this.lr.Location = new System.Drawing.Point(214, 217);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(41, 13);
            this.lr.TabIndex = 12;
            this.lr.Text = "Rareza";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "ID o Nombre del Pokemon";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 18;
            this.button2.Text = "Todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Location = new System.Drawing.Point(97, 9);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(83, 13);
            this.LID.TabIndex = 19;
            this.LID.Text = "ID del Pokemon";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 321);
            this.panel1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 289);
            this.textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 322);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lr);
            this.Controls.Add(this.Lg);
            this.Controls.Add(this.lV);
            this.Controls.Add(this.lSD);
            this.Controls.Add(this.lsa);
            this.Controls.Add(this.lD);
            this.Controls.Add(this.lAt);
            this.Controls.Add(this.lHp);
            this.Controls.Add(this.lt);
            this.Controls.Add(this.lt2);
            this.Controls.Add(this.lP1);
            this.Controls.Add(this.ln);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pokedex Nacional";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label lP1;
        private System.Windows.Forms.Label lt2;
        private System.Windows.Forms.Label lt;
        private System.Windows.Forms.Label lHp;
        private System.Windows.Forms.Label lAt;
        private System.Windows.Forms.Label lD;
        private System.Windows.Forms.Label lsa;
        private System.Windows.Forms.Label lSD;
        private System.Windows.Forms.Label lV;
        private System.Windows.Forms.Label Lg;
        private System.Windows.Forms.Label lr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

