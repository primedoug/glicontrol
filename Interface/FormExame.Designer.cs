namespace Interface
{
    partial class frmExame
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
            this.mskDataExame = new System.Windows.Forms.MaskedTextBox();
            this.txtGlicemia = new System.Windows.Forms.TextBox();
            this.nmrDosePrincipal = new System.Windows.Forms.NumericUpDown();
            this.nmrDoseSecundaria = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDosePrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDoseSecundaria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Exame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Glicemia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dose Principal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dose Secundária";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Glicontrol - Cadastrar Exame";
            // 
            // mskDataExame
            // 
            this.mskDataExame.Location = new System.Drawing.Point(196, 117);
            this.mskDataExame.Mask = "00/00/0000 90:00";
            this.mskDataExame.Name = "mskDataExame";
            this.mskDataExame.Size = new System.Drawing.Size(112, 20);
            this.mskDataExame.TabIndex = 5;
            this.mskDataExame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDataExame.ValidatingType = typeof(System.DateTime);
            // 
            // txtGlicemia
            // 
            this.txtGlicemia.Location = new System.Drawing.Point(196, 167);
            this.txtGlicemia.Name = "txtGlicemia";
            this.txtGlicemia.Size = new System.Drawing.Size(112, 20);
            this.txtGlicemia.TabIndex = 6;
            this.txtGlicemia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmrDosePrincipal
            // 
            this.nmrDosePrincipal.Location = new System.Drawing.Point(196, 222);
            this.nmrDosePrincipal.Name = "nmrDosePrincipal";
            this.nmrDosePrincipal.Size = new System.Drawing.Size(112, 20);
            this.nmrDosePrincipal.TabIndex = 7;
            this.nmrDosePrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmrDoseSecundaria
            // 
            this.nmrDoseSecundaria.Location = new System.Drawing.Point(196, 280);
            this.nmrDoseSecundaria.Name = "nmrDoseSecundaria";
            this.nmrDoseSecundaria.Size = new System.Drawing.Size(112, 20);
            this.nmrDoseSecundaria.TabIndex = 8;
            this.nmrDoseSecundaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(196, 349);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 37);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(63, 349);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 37);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(37, 21);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(112, 20);
            this.txtID.TabIndex = 11;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // frmExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 431);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.nmrDoseSecundaria);
            this.Controls.Add(this.nmrDosePrincipal);
            this.Controls.Add(this.txtGlicemia);
            this.Controls.Add(this.mskDataExame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Exame";
            this.Load += new System.EventHandler(this.frmExame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrDosePrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDoseSecundaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskDataExame;
        private System.Windows.Forms.TextBox txtGlicemia;
        private System.Windows.Forms.NumericUpDown nmrDosePrincipal;
        private System.Windows.Forms.NumericUpDown nmrDoseSecundaria;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
    }
}

