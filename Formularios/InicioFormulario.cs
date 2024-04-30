using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaRegistradora
{
    public partial class InicioFormulario : Form
    {
        public InicioFormulario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            this.label3 = new Label();
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.label4 = new Label();
            SuspendLayout();
            // 
            // Mensaje Bienvenido
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 68);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO";
            label1.Click += label1_Click;
            // 
            // Mensaje Usuario
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 139);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // Mensaje Contraseña
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(229, 204);
            this.label3.Name = "label3";
            this.label3.Size = new Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // Boton inicio sesion
            // 
            this.button1.Location = new Point(229, 286);
            this.button1.Name = "button1";
            this.button1.Size = new Size(166, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iniciar sesion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox Usuario
            // 
            this.textBox1.Location = new Point(229, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(166, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox Contraseña
            // 
            this.textBox2.Location = new Point(229, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(166, 27);
            this.textBox2.TabIndex = 5;
            // 
            // texto Contraseña olvidada
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Segoe UI", 7F);
            this.label4.Location = new Point(229, 257);
            this.label4.Name = "label4";
            this.label4.Size = new Size(118, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña olividada";
            // 
            // InicioFormulario
            // 
            ClientSize = new Size(694, 453);
            Controls.Add(this.label4);
            Controls.Add(this.textBox2);
            Controls.Add(this.textBox1);
            Controls.Add(this.button1);
            Controls.Add(this.label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InicioFormulario";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
