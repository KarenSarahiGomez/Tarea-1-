namespace Tarea_1
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
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.resultadolabel = new System.Windows.Forms.Label();
            this.PosNeglabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Calcularbutton.Location = new System.Drawing.Point(349, 144);
            this.Calcularbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(172, 40);
            this.Calcularbutton.TabIndex = 0;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = false;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un número:";
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumerotextBox.Location = new System.Drawing.Point(285, 84);
            this.NumerotextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(236, 29);
            this.NumerotextBox.TabIndex = 2;
            // 
            // resultadolabel
            // 
            this.resultadolabel.AutoSize = true;
            this.resultadolabel.Location = new System.Drawing.Point(345, 240);
            this.resultadolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultadolabel.Name = "resultadolabel";
            this.resultadolabel.Size = new System.Drawing.Size(14, 21);
            this.resultadolabel.TabIndex = 3;
            this.resultadolabel.Text = ":";
            // 
            // PosNeglabel
            // 
            this.PosNeglabel.AutoSize = true;
            this.PosNeglabel.Location = new System.Drawing.Point(345, 299);
            this.PosNeglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PosNeglabel.Name = "PosNeglabel";
            this.PosNeglabel.Size = new System.Drawing.Size(14, 21);
            this.PosNeglabel.TabIndex = 4;
            this.PosNeglabel.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 506);
            this.Controls.Add(this.PosNeglabel);
            this.Controls.Add(this.resultadolabel);
            this.Controls.Add(this.NumerotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcularbutton);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Tarea1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label resultadolabel;
        private System.Windows.Forms.Label PosNeglabel;
    }
}

