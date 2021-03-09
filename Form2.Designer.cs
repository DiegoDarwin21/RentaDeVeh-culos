
namespace RentaDeVehículos
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.FAlquiler = new System.Windows.Forms.DateTimePicker();
            this.FDevo = new System.Windows.Forms.DateTimePicker();
            this.txtrecorrido = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Alquiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de devolución";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "kilómetros recorridos";
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(173, 56);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(66, 20);
            this.txtnit.TabIndex = 5;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(173, 101);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(77, 20);
            this.txtplaca.TabIndex = 6;
            // 
            // FAlquiler
            // 
            this.FAlquiler.Location = new System.Drawing.Point(173, 134);
            this.FAlquiler.Name = "FAlquiler";
            this.FAlquiler.Size = new System.Drawing.Size(219, 20);
            this.FAlquiler.TabIndex = 7;
            // 
            // FDevo
            // 
            this.FDevo.Location = new System.Drawing.Point(173, 181);
            this.FDevo.Name = "FDevo";
            this.FDevo.Size = new System.Drawing.Size(213, 20);
            this.FDevo.TabIndex = 8;
            // 
            // txtrecorrido
            // 
            this.txtrecorrido.Location = new System.Drawing.Point(173, 219);
            this.txtrecorrido.Name = "txtrecorrido";
            this.txtrecorrido.Size = new System.Drawing.Size(77, 20);
            this.txtrecorrido.TabIndex = 9;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(173, 268);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(94, 22);
            this.buttonIngresar.TabIndex = 10;
            this.buttonIngresar.Text = "Ingresar Datos";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(416, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 202);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.txtrecorrido);
            this.Controls.Add(this.FDevo);
            this.Controls.Add(this.FAlquiler);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Datos de Alquiler";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.DateTimePicker FAlquiler;
        private System.Windows.Forms.DateTimePicker FDevo;
        private System.Windows.Forms.TextBox txtrecorrido;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}