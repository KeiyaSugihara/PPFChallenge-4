namespace PPFChallenge4
{
    partial class UserControlSelectDisplay
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtones = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonBerryHard = new System.Windows.Forms.Button();
            this.buttonCustom = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtones.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.DimGray;
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDescription.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(222, 158);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(756, 281);
            this.labelDescription.TabIndex = 3;
            // 
            // flowLayoutPanelButtones
            // 
            this.flowLayoutPanelButtones.Controls.Add(this.buttonEasy);
            this.flowLayoutPanelButtones.Controls.Add(this.buttonNormal);
            this.flowLayoutPanelButtones.Controls.Add(this.buttonHard);
            this.flowLayoutPanelButtones.Controls.Add(this.buttonBerryHard);
            this.flowLayoutPanelButtones.Controls.Add(this.buttonCustom);
            this.flowLayoutPanelButtones.Location = new System.Drawing.Point(29, 123);
            this.flowLayoutPanelButtones.Name = "flowLayoutPanelButtones";
            this.flowLayoutPanelButtones.Size = new System.Drawing.Size(148, 356);
            this.flowLayoutPanelButtones.TabIndex = 14;
            // 
            // buttonEasy
            // 
            this.buttonEasy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEasy.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonEasy.Location = new System.Drawing.Point(0, 0);
            this.buttonEasy.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(148, 68);
            this.buttonEasy.TabIndex = 8;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = false;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            this.buttonEasy.MouseEnter += new System.EventHandler(this.buttonEasy_MouseEnter);
            this.buttonEasy.MouseLeave += new System.EventHandler(this.buttonEasy_MouseLeave);
            // 
            // buttonNormal
            // 
            this.buttonNormal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNormal.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNormal.Location = new System.Drawing.Point(0, 71);
            this.buttonNormal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(148, 68);
            this.buttonNormal.TabIndex = 9;
            this.buttonNormal.Text = "Normal";
            this.buttonNormal.UseVisualStyleBackColor = false;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            this.buttonNormal.MouseEnter += new System.EventHandler(this.buttonNormal_MouseEnter);
            this.buttonNormal.MouseLeave += new System.EventHandler(this.buttonNormal_MouseLeave);
            // 
            // buttonHard
            // 
            this.buttonHard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHard.BackColor = System.Drawing.Color.Red;
            this.buttonHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHard.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonHard.Location = new System.Drawing.Point(0, 142);
            this.buttonHard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(148, 68);
            this.buttonHard.TabIndex = 10;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = false;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            this.buttonHard.MouseEnter += new System.EventHandler(this.buttonHard_MouseEnter);
            this.buttonHard.MouseLeave += new System.EventHandler(this.buttonHard_MouseLeave);
            // 
            // buttonBerryHard
            // 
            this.buttonBerryHard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBerryHard.BackColor = System.Drawing.Color.Purple;
            this.buttonBerryHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBerryHard.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBerryHard.Location = new System.Drawing.Point(0, 213);
            this.buttonBerryHard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonBerryHard.Name = "buttonBerryHard";
            this.buttonBerryHard.Size = new System.Drawing.Size(148, 68);
            this.buttonBerryHard.TabIndex = 11;
            this.buttonBerryHard.Text = "BerryHard";
            this.buttonBerryHard.UseVisualStyleBackColor = false;
            this.buttonBerryHard.Click += new System.EventHandler(this.buttonBerryHard_Click);
            this.buttonBerryHard.MouseEnter += new System.EventHandler(this.buttonBerryHard_MouseEnter);
            this.buttonBerryHard.MouseLeave += new System.EventHandler(this.buttonBerryHard_MouseLeave);
            // 
            // buttonCustom
            // 
            this.buttonCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCustom.Location = new System.Drawing.Point(0, 284);
            this.buttonCustom.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(148, 68);
            this.buttonCustom.TabIndex = 12;
            this.buttonCustom.Text = "Custom";
            this.buttonCustom.UseVisualStyleBackColor = false;
            this.buttonCustom.Click += new System.EventHandler(this.buttonCustom_Click);
            this.buttonCustom.MouseEnter += new System.EventHandler(this.buttonCustom_MouseEnter);
            this.buttonCustom.MouseLeave += new System.EventHandler(this.buttonCustom_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExit.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonExit.Location = new System.Drawing.Point(929, 514);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 35);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // UserControlSelectDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.flowLayoutPanelButtones);
            this.Controls.Add(this.labelDescription);
            this.Name = "UserControlSelectDisplay";
            this.Size = new System.Drawing.Size(1048, 599);
            this.Load += new System.EventHandler(this.UserControlSelectDisplay_Load);
            this.flowLayoutPanelButtones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtones;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonNormal;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonBerryHard;
        private System.Windows.Forms.Button buttonCustom;
        private System.Windows.Forms.Button buttonExit;
    }
}
