namespace Work
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.content1 = new System.Windows.Forms.Label();
            this.content2 = new System.Windows.Forms.Label();
            this.mask = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Pillar = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("新細明體", 12F);
            this.score1.Location = new System.Drawing.Point(10, 10);
            this.score1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(0, 16);
            this.score1.TabIndex = 6;
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("新細明體", 12F);
            this.score2.Location = new System.Drawing.Point(460, 10);
            this.score2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(0, 16);
            this.score2.TabIndex = 7;
            // 
            // content1
            // 
            this.content1.AutoSize = true;
            this.content1.Font = new System.Drawing.Font("新細明體", 20F);
            this.content1.Location = new System.Drawing.Point(176, 100);
            this.content1.Name = "content1";
            this.content1.Size = new System.Drawing.Size(228, 135);
            this.content1.TabIndex = 9;
            this.content1.Text = "阿ㄆ一ㄚˇ打排球\r\n\r\n\r\n\r\n按空格鍵開始";
            this.content1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // content2
            // 
            this.content2.AutoSize = true;
            this.content2.Font = new System.Drawing.Font("新細明體", 12F);
            this.content2.Location = new System.Drawing.Point(134, 250);
            this.content2.Name = "content2";
            this.content2.Size = new System.Drawing.Size(311, 48);
            this.content2.TabIndex = 10;
            this.content2.Text = "Player1以A, S左右移動 W跳躍 Z擊球\r\n\r\nPlayer2以左, 右鍵左右移動 上跳躍 Enter擊球";
            this.content2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mask
            // 
            this.mask.Location = new System.Drawing.Point(0, 0);
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(580, 370);
            this.mask.TabIndex = 8;
            this.mask.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = global::Work.Properties.Resources.Ball;
            this.Ball.Location = new System.Drawing.Point(280, 100);
            this.Ball.Margin = new System.Windows.Forms.Padding(2);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(40, 40);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 3;
            this.Ball.TabStop = false;
            // 
            // Pillar
            // 
            this.Pillar.BackColor = System.Drawing.Color.Transparent;
            this.Pillar.Image = global::Work.Properties.Resources.Pillar;
            this.Pillar.Location = new System.Drawing.Point(290, 200);
            this.Pillar.Margin = new System.Windows.Forms.Padding(2);
            this.Pillar.Name = "Pillar";
            this.Pillar.Size = new System.Drawing.Size(20, 160);
            this.Pillar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pillar.TabIndex = 2;
            this.Pillar.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Transparent;
            this.Player2.Image = global::Work.Properties.Resources.Player;
            this.Player2.Location = new System.Drawing.Point(454, 300);
            this.Player2.Margin = new System.Windows.Forms.Padding(2);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(60, 64);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Image = global::Work.Properties.Resources.Player;
            this.Player1.Location = new System.Drawing.Point(69, 300);
            this.Player1.Margin = new System.Windows.Forms.Padding(2);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(60, 64);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.content2);
            this.Controls.Add(this.content1);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Pillar);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "阿ㄆ一ㄚˇ打排球";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox Pillar;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.PictureBox mask;
        private System.Windows.Forms.Label content1;
        private System.Windows.Forms.Label content2;
    }
}

