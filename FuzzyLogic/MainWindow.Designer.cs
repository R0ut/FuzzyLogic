namespace FuzzyLogic
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBoxPoraDnia = new System.Windows.Forms.PictureBox();
            this.textBoxTemperaturaPozadana = new System.Windows.Forms.TextBox();
            this.textBoxTemperaturaAktualna = new System.Windows.Forms.TextBox();
            this.labelTemperaturaNaDworzu = new System.Windows.Forms.Label();
            this.pictureBoxOkno = new System.Windows.Forms.PictureBox();
            this.transparentControl1 = new FuzzyLogic.TransparentControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoraDnia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOkno)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPoraDnia
            // 
            this.pictureBoxPoraDnia.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPoraDnia.Image")));
            this.pictureBoxPoraDnia.Location = new System.Drawing.Point(598, -1);
            this.pictureBoxPoraDnia.Name = "pictureBoxPoraDnia";
            this.pictureBoxPoraDnia.Size = new System.Drawing.Size(258, 500);
            this.pictureBoxPoraDnia.TabIndex = 2;
            this.pictureBoxPoraDnia.TabStop = false;
            // 
            // textBoxTemperaturaPozadana
            // 
            this.textBoxTemperaturaPozadana.Location = new System.Drawing.Point(12, 430);
            this.textBoxTemperaturaPozadana.Name = "textBoxTemperaturaPozadana";
            this.textBoxTemperaturaPozadana.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemperaturaPozadana.TabIndex = 3;
            // 
            // textBoxTemperaturaAktualna
            // 
            this.textBoxTemperaturaAktualna.Location = new System.Drawing.Point(12, 456);
            this.textBoxTemperaturaAktualna.Name = "textBoxTemperaturaAktualna";
            this.textBoxTemperaturaAktualna.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemperaturaAktualna.TabIndex = 4;
            // 
            // labelTemperaturaNaDworzu
            // 
            this.labelTemperaturaNaDworzu.AutoSize = true;
            this.labelTemperaturaNaDworzu.Location = new System.Drawing.Point(666, 46);
            this.labelTemperaturaNaDworzu.Name = "labelTemperaturaNaDworzu";
            this.labelTemperaturaNaDworzu.Size = new System.Drawing.Size(0, 13);
            this.labelTemperaturaNaDworzu.TabIndex = 5;
            // 
            // pictureBoxOkno
            // 
            this.pictureBoxOkno.Location = new System.Drawing.Point(38, 70);
            this.pictureBoxOkno.Name = "pictureBoxOkno";
            this.pictureBoxOkno.Size = new System.Drawing.Size(110, 190);
            this.pictureBoxOkno.TabIndex = 6;
            this.pictureBoxOkno.TabStop = false;
            this.pictureBoxOkno.Click += new System.EventHandler(this.pictureBoxOkno_OnClick);
            // 
            // transparentControl1
            // 
            this.transparentControl1.BackColor = System.Drawing.Color.Transparent;
            this.transparentControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transparentControl1.BackgroundImage")));
            this.transparentControl1.Image = global::FuzzyLogic.Properties.Resources.typek_cold1;
            this.transparentControl1.Location = new System.Drawing.Point(323, 169);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Size = new System.Drawing.Size(317, 322);
            this.transparentControl1.TabIndex = 7;
            this.transparentControl1.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "piecyk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "klima";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(854, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transparentControl1);
            this.Controls.Add(this.pictureBoxOkno);
            this.Controls.Add(this.labelTemperaturaNaDworzu);
            this.Controls.Add(this.textBoxTemperaturaAktualna);
            this.Controls.Add(this.textBoxTemperaturaPozadana);
            this.Controls.Add(this.pictureBoxPoraDnia);
            this.Name = "MainWindow";
            this.Text = "FuzzyLogic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoraDnia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOkno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPoraDnia;
        private System.Windows.Forms.TextBox textBoxTemperaturaPozadana;
        private System.Windows.Forms.TextBox textBoxTemperaturaAktualna;
        private System.Windows.Forms.Label labelTemperaturaNaDworzu;
        private System.Windows.Forms.PictureBox pictureBoxOkno;
        private TransparentControl transparentControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

