namespace mercado_mosca
{
    partial class Monitor
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbq = new System.Windows.Forms.Label();
            this.tbq = new System.Windows.Forms.TextBox();
            this.lbp = new System.Windows.Forms.Label();
            this.tbp = new System.Windows.Forms.TextBox();
            this.bt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Voltar às compras";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Monitor quebrado por R$350,00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbq
            // 
            this.lbq.AutoSize = true;
            this.lbq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbq.Location = new System.Drawing.Point(401, 275);
            this.lbq.Name = "lbq";
            this.lbq.Size = new System.Drawing.Size(96, 20);
            this.lbq.TabIndex = 21;
            this.lbq.Text = "Quantidade:";
            this.lbq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbq
            // 
            this.tbq.Location = new System.Drawing.Point(503, 277);
            this.tbq.Name = "tbq";
            this.tbq.Size = new System.Drawing.Size(143, 20);
            this.tbq.TabIndex = 22;
            this.tbq.TextChanged += new System.EventHandler(this.tbq_TextChanged);
            // 
            // lbp
            // 
            this.lbp.AutoSize = true;
            this.lbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbp.Location = new System.Drawing.Point(401, 305);
            this.lbp.Name = "lbp";
            this.lbp.Size = new System.Drawing.Size(54, 20);
            this.lbp.TabIndex = 23;
            this.lbp.Text = "Preço:";
            this.lbp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbp
            // 
            this.tbp.Location = new System.Drawing.Point(503, 307);
            this.tbp.Name = "tbp";
            this.tbp.ReadOnly = true;
            this.tbp.Size = new System.Drawing.Size(143, 20);
            this.tbp.TabIndex = 24;
            this.tbp.TextChanged += new System.EventHandler(this.tbp_TextChanged);
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(455, 347);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(128, 30);
            this.bt.TabIndex = 25;
            this.bt.Text = "Adicionar ao carrinho";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Ir para o carrinho";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::mercado_mosca.Properties.Resources.monitor_quebrado;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(385, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 190);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mercado_mosca.Properties.Resources.teste3;
            this.pictureBox1.Location = new System.Drawing.Point(-16, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.tbp);
            this.Controls.Add(this.lbp);
            this.Controls.Add(this.tbq);
            this.Controls.Add(this.lbq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbq;
        private System.Windows.Forms.TextBox tbq;
        private System.Windows.Forms.Label lbp;
        private System.Windows.Forms.TextBox tbp;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Button button2;
    }
}