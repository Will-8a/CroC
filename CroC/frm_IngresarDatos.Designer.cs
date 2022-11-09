namespace CroC
{
    partial class frm_IngresarDatos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Responsable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FechaConteo = new System.Windows.Forms.DateTimePicker();
            this.txt_CantidadPersonas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_Prueba = new System.Windows.Forms.TextBox();
            this.lbl_Rectificador = new System.Windows.Forms.Label();
            this.tmr_ContadorRectificador = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Responsable:";
            // 
            // txt_Responsable
            // 
            this.txt_Responsable.Location = new System.Drawing.Point(166, 82);
            this.txt_Responsable.Name = "txt_Responsable";
            this.txt_Responsable.Size = new System.Drawing.Size(136, 20);
            this.txt_Responsable.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // dtp_FechaConteo
            // 
            this.dtp_FechaConteo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaConteo.Location = new System.Drawing.Point(166, 126);
            this.dtp_FechaConteo.Name = "dtp_FechaConteo";
            this.dtp_FechaConteo.Size = new System.Drawing.Size(136, 20);
            this.dtp_FechaConteo.TabIndex = 4;
            // 
            // txt_CantidadPersonas
            // 
            this.txt_CantidadPersonas.Location = new System.Drawing.Point(166, 169);
            this.txt_CantidadPersonas.Name = "txt_CantidadPersonas";
            this.txt_CantidadPersonas.Size = new System.Drawing.Size(136, 20);
            this.txt_CantidadPersonas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de personas:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(227, 285);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_Prueba
            // 
            this.txt_Prueba.Location = new System.Drawing.Point(97, 259);
            this.txt_Prueba.Name = "txt_Prueba";
            this.txt_Prueba.Size = new System.Drawing.Size(368, 20);
            this.txt_Prueba.TabIndex = 8;
            // 
            // lbl_Rectificador
            // 
            this.lbl_Rectificador.AutoSize = true;
            this.lbl_Rectificador.Location = new System.Drawing.Point(100, 237);
            this.lbl_Rectificador.Name = "lbl_Rectificador";
            this.lbl_Rectificador.Size = new System.Drawing.Size(187, 13);
            this.lbl_Rectificador.TabIndex = 9;
            this.lbl_Rectificador.Text = "Se guardaron los datos correctamente";
            // 
            // tmr_ContadorRectificador
            // 
            this.tmr_ContadorRectificador.Interval = 1000;
            this.tmr_ContadorRectificador.Tick += new System.EventHandler(this.tmr_ContadorRectificador_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // frm_IngresarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Rectificador);
            this.Controls.Add(this.txt_Prueba);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_CantidadPersonas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_FechaConteo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Responsable);
            this.Controls.Add(this.label1);
            this.Name = "frm_IngresarDatos";
            this.Text = "frm_IngresarDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Responsable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FechaConteo;
        private System.Windows.Forms.TextBox txt_CantidadPersonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_Prueba;
        private System.Windows.Forms.Label lbl_Rectificador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmr_ContadorRectificador;
    }
}