namespace sesion4
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.aumento = new System.Windows.Forms.Label();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.techo = new System.Windows.Forms.Label();
            this.tbTecho = new System.Windows.Forms.TextBox();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.tbAumentar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.apellido = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(163, 49);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(303, 20);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(64, 44);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(93, 25);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre:";
            this.nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // salario
            // 
            this.salario.AutoSize = true;
            this.salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario.Location = new System.Drawing.Point(72, 237);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(85, 25);
            this.salario.TabIndex = 2;
            this.salario.Text = "Salario:";
            this.salario.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(163, 243);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(303, 20);
            this.tbSalario.TabIndex = 3;
            // 
            // aumento
            // 
            this.aumento.AutoSize = true;
            this.aumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aumento.Location = new System.Drawing.Point(54, 283);
            this.aumento.Name = "aumento";
            this.aumento.Size = new System.Drawing.Size(103, 25);
            this.aumento.TabIndex = 4;
            this.aumento.Text = "Aumento:";
            this.aumento.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(163, 288);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(102, 20);
            this.nud.TabIndex = 5;
            this.nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // techo
            // 
            this.techo.AutoSize = true;
            this.techo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techo.Location = new System.Drawing.Point(79, 325);
            this.techo.Name = "techo";
            this.techo.Size = new System.Drawing.Size(78, 25);
            this.techo.TabIndex = 6;
            this.techo.Text = "Techo:";
            // 
            // tbTecho
            // 
            this.tbTecho.Location = new System.Drawing.Point(163, 330);
            this.tbTecho.Name = "tbTecho";
            this.tbTecho.Size = new System.Drawing.Size(153, 20);
            this.tbTecho.TabIndex = 7;
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(176, 406);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(174, 43);
            this.btnAumentar.TabIndex = 8;
            this.btnAumentar.Text = "Aumentar Salario";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.Btn_Click);
            // 
            // tbAumentar
            // 
            this.tbAumentar.Location = new System.Drawing.Point(260, 476);
            this.tbAumentar.Name = "tbAumentar";
            this.tbAumentar.Size = new System.Drawing.Size(156, 20);
            this.tbAumentar.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salario aumentado:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(84, 515);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 34);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(340, 515);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(62, 83);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(95, 25);
            this.apellido.TabIndex = 13;
            this.apellido.Text = "Apellido:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(119, 123);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(38, 25);
            this.ID.TabIndex = 14;
            this.ID.Text = "ID:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(86, 161);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(71, 25);
            this.email.TabIndex = 15;
            this.email.Text = "Email:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(64, 201);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(93, 25);
            this.phone.TabIndex = 16;
            this.phone.Text = "Número:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(163, 88);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(263, 20);
            this.tbApellido.TabIndex = 17;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(163, 133);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(135, 20);
            this.tbID.TabIndex = 18;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(164, 167);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(249, 20);
            this.tbEmail.TabIndex = 19;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(165, 204);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(172, 20);
            this.tbNumero.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(143, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(238, 40);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar el registro del empleado";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 559);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAumentar);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.tbTecho);
            this.Controls.Add(this.techo);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.aumento);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.tbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label salario;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label aumento;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label techo;
        private System.Windows.Forms.TextBox tbTecho;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.TextBox tbAumentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btnGuardar;
    }
}

