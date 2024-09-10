namespace Ej1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lbAges = new System.Windows.Forms.ListBox();
            this.lblAges = new System.Windows.Forms.Label();
            this.lblAddition = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAverage);
            this.groupBox1.Controls.Add(this.lblAddition);
            this.groupBox1.Controls.Add(this.lblAges);
            this.groupBox1.Controls.Add(this.lbAges);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Location = new System.Drawing.Point(45, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de edades";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(24, 36);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(83, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Ingrese la edad:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(113, 33);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(68, 20);
            this.tbAge.TabIndex = 2;
            this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAge_KeyPress);
            // 
            // lbAges
            // 
            this.lbAges.FormattingEnabled = true;
            this.lbAges.Location = new System.Drawing.Point(27, 105);
            this.lbAges.Name = "lbAges";
            this.lbAges.Size = new System.Drawing.Size(261, 95);
            this.lbAges.TabIndex = 3;
            // 
            // lblAges
            // 
            this.lblAges.AutoSize = true;
            this.lblAges.Location = new System.Drawing.Point(24, 71);
            this.lblAges.Name = "lblAges";
            this.lblAges.Size = new System.Drawing.Size(97, 13);
            this.lblAges.TabIndex = 4;
            this.lblAges.Text = "Edades registradas";
            // 
            // lblAddition
            // 
            this.lblAddition.Location = new System.Drawing.Point(196, 223);
            this.lblAddition.Name = "lblAddition";
            this.lblAddition.Size = new System.Drawing.Size(94, 23);
            this.lblAddition.TabIndex = 5;
            this.lblAddition.Text = "Suma: 0";
            this.lblAddition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(211, 257);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(77, 20);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "Promedio: 0";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 351);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAges;
        private System.Windows.Forms.ListBox lbAges;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblAddition;
    }
}

