namespace mercado_mosca
{
    partial class Recibo
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.listBoxRecibo = new System.Windows.Forms.ListBox();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbq = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(258, 19);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(28, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "<-";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // listBoxRecibo
            // 
            this.listBoxRecibo.FormattingEnabled = true;
            this.listBoxRecibo.Location = new System.Drawing.Point(295, 81);
            this.listBoxRecibo.Name = "listBoxRecibo";
            this.listBoxRecibo.Size = new System.Drawing.Size(447, 199);
            this.listBoxRecibo.TabIndex = 1;
            this.listBoxRecibo.SelectedIndexChanged += new System.EventHandler(this.listBoxRecibo_SelectedIndexChanged);
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotal.Location = new System.Drawing.Point(337, 293);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(51, 20);
            this.lblPrecoTotal.TabIndex = 2;
            this.lblPrecoTotal.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mercado_mosca.Properties.Resources.teste5;
            this.pictureBox1.Location = new System.Drawing.Point(-19, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbq
            // 
            this.lbq.AutoSize = true;
            this.lbq.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbq.Location = new System.Drawing.Point(469, 9);
            this.lbq.Name = "lbq";
            this.lbq.Size = new System.Drawing.Size(106, 33);
            this.lbq.TabIndex = 33;
            this.lbq.Text = "Recibo";
            this.lbq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Voltar a tela de login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Lista de produtos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 37;
            this.button1.Text = "Baixar recibo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbq);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrecoTotal);
            this.Controls.Add(this.listBoxRecibo);
            this.Controls.Add(this.btnFechar);
            this.MaximizeBox = false;
            this.Name = "Recibo";
            this.Text = "Recibo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListBox listBoxRecibo;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}