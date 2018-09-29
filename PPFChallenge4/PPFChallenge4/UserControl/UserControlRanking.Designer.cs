namespace PPFChallenge4
{
    partial class UserControlRanking
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
            this.dataGridViewRanking = new System.Windows.Forms.DataGridView();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelMord = new System.Windows.Forms.Label();
            this.ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRanking
            // 
            this.dataGridViewRanking.AllowUserToAddRows = false;
            this.dataGridViewRanking.AllowUserToDeleteRows = false;
            this.dataGridViewRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ranking,
            this.name,
            this.time});
            this.dataGridViewRanking.Location = new System.Drawing.Point(222, 85);
            this.dataGridViewRanking.Name = "dataGridViewRanking";
            this.dataGridViewRanking.RowHeadersVisible = false;
            this.dataGridViewRanking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRanking.RowTemplate.Height = 24;
            this.dataGridViewRanking.Size = new System.Drawing.Size(604, 385);
            this.dataGridViewRanking.TabIndex = 6;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSelect.Location = new System.Drawing.Point(377, 503);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(295, 53);
            this.buttonSelect.TabIndex = 9;
            this.buttonSelect.Text = "メニューに戻る";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelMord
            // 
            this.labelMord.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMord.ForeColor = System.Drawing.Color.Red;
            this.labelMord.Location = new System.Drawing.Point(377, 19);
            this.labelMord.Name = "labelMord";
            this.labelMord.Size = new System.Drawing.Size(295, 44);
            this.labelMord.TabIndex = 10;
            this.labelMord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ranking
            // 
            this.ranking.HeaderText = "ランキング";
            this.ranking.Name = "ranking";
            this.ranking.Width = 90;
            // 
            // name
            // 
            this.name.HeaderText = "名前";
            this.name.Name = "name";
            this.name.Width = 180;
            // 
            // time
            // 
            this.time.HeaderText = "タイム";
            this.time.Name = "time";
            this.time.Width = 330;
            // 
            // UserControlRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMord);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.dataGridViewRanking);
            this.Name = "UserControlRanking";
            this.Size = new System.Drawing.Size(1048, 599);
            this.Load += new System.EventHandler(this.UserControlRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelMord;
        protected internal System.Windows.Forms.DataGridView dataGridViewRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn ranking;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}
