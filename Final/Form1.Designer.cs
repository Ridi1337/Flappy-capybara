
namespace Final
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.Capybara = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capybara)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = global::Final.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-5, 473);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(538, 73);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.PipeBottom.Image = global::Final.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(325, 353);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(83, 168);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 2;
            this.PipeBottom.TabStop = false;
            this.PipeBottom.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PipeTop
            // 
            this.PipeTop.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop.Image = global::Final.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(433, -31);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(83, 164);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 1;
            this.PipeTop.TabStop = false;
            // 
            // Capybara
            // 
            this.Capybara.BackColor = System.Drawing.Color.Transparent;
            this.Capybara.Image = global::Final.Properties.Resources.capybird;
            this.Capybara.Location = new System.Drawing.Point(12, 209);
            this.Capybara.Name = "Capybara";
            this.Capybara.Size = new System.Drawing.Size(79, 69);
            this.Capybara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Capybara.TabIndex = 0;
            this.Capybara.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(12, 498);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(160, 39);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEven);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(528, 546);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.Capybara);
            this.Name = "Form1";
            this.Text = "Flying Capybara The Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capybara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Capybara;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}

