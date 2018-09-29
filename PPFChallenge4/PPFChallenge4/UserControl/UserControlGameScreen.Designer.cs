namespace PPFChallenge4
{
    partial class UserControlGameScreen
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxGameScreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.checkBoxPause = new System.Windows.Forms.CheckBox();
            this.checkBoxDiscontinuation = new System.Windows.Forms.CheckBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelReply = new System.Windows.Forms.Label();
            this.labelCongraturation = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGameScreen
            // 
            this.pictureBoxGameScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGameScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGameScreen.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGameScreen.Name = "pictureBoxGameScreen";
            this.pictureBoxGameScreen.Size = new System.Drawing.Size(1048, 599);
            this.pictureBoxGameScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGameScreen.TabIndex = 0;
            this.pictureBoxGameScreen.TabStop = false;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(275, 4);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(499, 244);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemy.TabIndex = 4;
            this.pictureBoxEnemy.TabStop = false;
            this.pictureBoxEnemy.Visible = false;
            // 
            // checkBoxPause
            // 
            this.checkBoxPause.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPause.BackColor = System.Drawing.Color.Gray;
            this.checkBoxPause.Enabled = false;
            this.checkBoxPause.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxPause.Location = new System.Drawing.Point(13, 14);
            this.checkBoxPause.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxPause.Name = "checkBoxPause";
            this.checkBoxPause.Size = new System.Drawing.Size(104, 35);
            this.checkBoxPause.TabIndex = 17;
            this.checkBoxPause.Text = "一時停止";
            this.checkBoxPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPause.UseVisualStyleBackColor = false;
            this.checkBoxPause.Visible = false;
            this.checkBoxPause.CheckedChanged += new System.EventHandler(this.checkBoxPause_CheckedChanged);
            // 
            // checkBoxDiscontinuation
            // 
            this.checkBoxDiscontinuation.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDiscontinuation.BackColor = System.Drawing.Color.Gray;
            this.checkBoxDiscontinuation.Enabled = false;
            this.checkBoxDiscontinuation.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxDiscontinuation.Location = new System.Drawing.Point(13, 49);
            this.checkBoxDiscontinuation.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDiscontinuation.Name = "checkBoxDiscontinuation";
            this.checkBoxDiscontinuation.Size = new System.Drawing.Size(104, 35);
            this.checkBoxDiscontinuation.TabIndex = 18;
            this.checkBoxDiscontinuation.Text = "中止";
            this.checkBoxDiscontinuation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDiscontinuation.UseVisualStyleBackColor = false;
            this.checkBoxDiscontinuation.Visible = false;
            this.checkBoxDiscontinuation.CheckedChanged += new System.EventHandler(this.checkBoxDiscontinuation_CheckedChanged);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelStart.Location = new System.Drawing.Point(330, 325);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(375, 40);
            this.labelStart.TabIndex = 25;
            this.labelStart.Text = "スペースキーでスタート";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStart.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.labelStart_PreviewKeyDown);
            // 
            // labelReply
            // 
            this.labelReply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReply.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelReply.Location = new System.Drawing.Point(24, 426);
            this.labelReply.Name = "labelReply";
            this.labelReply.Size = new System.Drawing.Size(1001, 163);
            this.labelReply.TabIndex = 30;
            this.labelReply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReply.Visible = false;
            this.labelReply.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.labelReply_PreviewKeyDown_1);
            // 
            // labelCongraturation
            // 
            this.labelCongraturation.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCongraturation.ForeColor = System.Drawing.Color.Red;
            this.labelCongraturation.Location = new System.Drawing.Point(358, 12);
            this.labelCongraturation.Name = "labelCongraturation";
            this.labelCongraturation.Size = new System.Drawing.Size(332, 49);
            this.labelCongraturation.TabIndex = 31;
            this.labelCongraturation.Text = "Congraturation";
            this.labelCongraturation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCongraturation.Visible = false;
            // 
            // labelQuestion
            // 
            this.labelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelQuestion.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelQuestion.Location = new System.Drawing.Point(24, 256);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(1001, 163);
            this.labelQuestion.TabIndex = 29;
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestion.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonClear.Enabled = false;
            this.buttonClear.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClear.Location = new System.Drawing.Point(354, 259);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(340, 64);
            this.buttonClear.TabIndex = 32;
            this.buttonClear.Text = "ランキングを見る";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // UserControlGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelCongraturation);
            this.Controls.Add(this.labelReply);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.checkBoxDiscontinuation);
            this.Controls.Add(this.checkBoxPause);
            this.Controls.Add(this.pictureBoxEnemy);
            this.Controls.Add(this.pictureBoxGameScreen);
            this.Name = "UserControlGameScreen";
            this.Size = new System.Drawing.Size(1048, 599);
            this.Load += new System.EventHandler(this.UserControlGameScreen_Load);
            this.Click += new System.EventHandler(this.UserControlGameScreen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGameScreen;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.CheckBox checkBoxPause;
        private System.Windows.Forms.CheckBox checkBoxDiscontinuation;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelReply;
        private System.Windows.Forms.Label labelCongraturation;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonClear;
    }
}
