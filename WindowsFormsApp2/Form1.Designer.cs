namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.flapyBird = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.covid1 = new System.Windows.Forms.PictureBox();
            this.covid2 = new System.Windows.Forms.PictureBox();
            this.covid3 = new System.Windows.Forms.PictureBox();
            this.covid4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flapyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid4)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.SystemColors.Control;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(12, 631);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(264, 55);
            this.Score.TabIndex = 5;
            this.Score.Text = "Puntaje : 0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // flapyBird
            // 
            this.flapyBird.BackColor = System.Drawing.Color.Transparent;
            this.flapyBird.Image = global::WindowsFormsApp2.Properties.Resources.Sin_título;
            this.flapyBird.Location = new System.Drawing.Point(0, 0);
            this.flapyBird.Name = "flapyBird";
            this.flapyBird.Size = new System.Drawing.Size(120, 71);
            this.flapyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flapyBird.TabIndex = 3;
            this.flapyBird.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.BackColor = System.Drawing.Color.Transparent;
            this.pipeDown.Image = global::WindowsFormsApp2.Properties.Resources.pixel_art_vector_coronavirus_bacteria_600w_1685377870;
            this.pipeDown.Location = new System.Drawing.Point(176, 482);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(116, 114);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 2;
            this.pipeDown.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::WindowsFormsApp2.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 591);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(861, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::WindowsFormsApp2.Properties.Resources.pixel_art_vector_coronavirus_bacteria_600w_1685377870;
            this.pipeTop.Location = new System.Drawing.Point(175, 0);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(117, 111);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // covid1
            // 
            this.covid1.Image = global::WindowsFormsApp2.Properties.Resources.pixel_art_vector_coronavirus_bacteria_600w_1685377870;
            this.covid1.Location = new System.Drawing.Point(320, 0);
            this.covid1.Name = "covid1";
            this.covid1.Size = new System.Drawing.Size(116, 139);
            this.covid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.covid1.TabIndex = 6;
            this.covid1.TabStop = false;
            // 
            // covid2
            // 
            this.covid2.BackColor = System.Drawing.Color.Transparent;
            this.covid2.Image = global::WindowsFormsApp2.Properties.Resources.pixel_art_vector_coronavirus_bacteria_600w_1685377870;
            this.covid2.Location = new System.Drawing.Point(320, 422);
            this.covid2.Name = "covid2";
            this.covid2.Size = new System.Drawing.Size(116, 174);
            this.covid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.covid2.TabIndex = 7;
            this.covid2.TabStop = false;
            // 
            // covid3
            // 
            this.covid3.BackColor = System.Drawing.Color.Transparent;
            this.covid3.Image = global::WindowsFormsApp2.Properties.Resources.pixel_art_vector_coronavirus_bacteria_600w_1685377870;
            this.covid3.Location = new System.Drawing.Point(467, 0);
            this.covid3.Name = "covid3";
            this.covid3.Size = new System.Drawing.Size(100, 204);
            this.covid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.covid3.TabIndex = 8;
            this.covid3.TabStop = false;
            // 
            // covid4
            // 
            this.covid4.BackColor = System.Drawing.Color.Transparent;
            this.covid4.Image = global::WindowsFormsApp2.Properties.Resources.pixel_art_vector_coronavirus_bacteria_600w_1685377870;
            this.covid4.Location = new System.Drawing.Point(467, 370);
            this.covid4.Name = "covid4";
            this.covid4.Size = new System.Drawing.Size(100, 226);
            this.covid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.covid4.TabIndex = 9;
            this.covid4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Pixel_art_Christmas_houses_with_Santas_sleigh__pv;
            this.ClientSize = new System.Drawing.Size(863, 764);
            this.Controls.Add(this.covid4);
            this.Controls.Add(this.covid3);
            this.Controls.Add(this.covid2);
            this.Controls.Add(this.covid1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.flapyBird);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flapyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covid4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox flapyBird;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox covid1;
        private System.Windows.Forms.PictureBox covid2;
        private System.Windows.Forms.PictureBox covid3;
        private System.Windows.Forms.PictureBox covid4;
    }
}

