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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoraDnia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOkno)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPoraDnia
            // 
            this.pictureBoxPoraDnia.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPoraDnia.Image")));
            this.pictureBoxPoraDnia.Location = new System.Drawing.Point(581, 1);
            this.pictureBoxPoraDnia.Name = "pictureBoxPoraDnia";
            this.pictureBoxPoraDnia.Size = new System.Drawing.Size(253, 500);
            this.pictureBoxPoraDnia.TabIndex = 2;
            this.pictureBoxPoraDnia.TabStop = false;
            // 
            // textBoxTemperaturaPozadana
            // 
            this.textBoxTemperaturaPozadana.Location = new System.Drawing.Point(12, 300);
            this.textBoxTemperaturaPozadana.Name = "textBoxTemperaturaPozadana";
            this.textBoxTemperaturaPozadana.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemperaturaPozadana.TabIndex = 3;
            // 
            // textBoxTemperaturaAktualna
            // 
            this.textBoxTemperaturaAktualna.Location = new System.Drawing.Point(12, 326);
            this.textBoxTemperaturaAktualna.Name = "textBoxTemperaturaAktualna";
            this.textBoxTemperaturaAktualna.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemperaturaAktualna.TabIndex = 4;
            // 
            // labelTemperaturaNaDworzu
            // 
            this.labelTemperaturaNaDworzu.AutoSize = true;
            this.labelTemperaturaNaDworzu.Location = new System.Drawing.Point(595, 32);
            this.labelTemperaturaNaDworzu.Name = "labelTemperaturaNaDworzu";
            this.labelTemperaturaNaDworzu.Size = new System.Drawing.Size(0, 13);
            this.labelTemperaturaNaDworzu.TabIndex = 5;
            // 
            // pictureBoxOkno
            // 
            this.pictureBoxOkno.Location = new System.Drawing.Point(370, 78);
            this.pictureBoxOkno.Name = "pictureBoxOkno";
            this.pictureBoxOkno.Size = new System.Drawing.Size(110, 190);
            this.pictureBoxOkno.TabIndex = 6;
            this.pictureBoxOkno.TabStop = false;
            this.pictureBoxOkno.Click += new System.EventHandler(this.pictureBoxOkno_OnClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 501);
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
    }
}

