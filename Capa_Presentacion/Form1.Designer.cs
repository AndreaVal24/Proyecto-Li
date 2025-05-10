namespace Capa_Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label lblusuario;
            btnaceptar = new Button();
            btncancelar = new Button();
            txtname = new TextBox();
            txtpassword = new TextBox();
            lblpassword = new Label();
            lblusuario = new Label();
            SuspendLayout();
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(183, 262);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(112, 34);
            btnaceptar.TabIndex = 0;
            btnaceptar.Text = "Aceptar";
            btnaceptar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(441, 262);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(112, 34);
            btncancelar.TabIndex = 1;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(343, 70);
            txtname.Name = "txtname";
            txtname.Size = new Size(150, 31);
            txtname.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(343, 165);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(150, 31);
            txtpassword.TabIndex = 3;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(265, 70);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(72, 25);
            lblusuario.TabIndex = 4;
            lblusuario.Text = "Usuario";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(236, 171);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(101, 25);
            lblpassword.TabIndex = 5;
            lblpassword.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblpassword);
            Controls.Add(lblusuario);
            Controls.Add(txtpassword);
            Controls.Add(txtname);
            Controls.Add(btncancelar);
            Controls.Add(btnaceptar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnaceptar;
        private Button btncancelar;
        private TextBox txtname;
        private TextBox txtpassword;
        private Label lblusuario;
        private Label lblpassword;
    }
}
