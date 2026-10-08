namespace Tutorial2_4
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
            this.FrancepictureBox = new System.Windows.Forms.PictureBox();
            this.GermanypictureBox = new System.Windows.Forms.PictureBox();
            this.FinlandpictureBox = new System.Windows.Forms.PictureBox();
            this.countrylabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FrancepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GermanypictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinlandpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FrancepictureBox
            // 
            this.FrancepictureBox.Image = global::Tutorial2_4.Properties.Resources.France;
            this.FrancepictureBox.Location = new System.Drawing.Point(309, 131);
            this.FrancepictureBox.Name = "FrancepictureBox";
            this.FrancepictureBox.Size = new System.Drawing.Size(223, 132);
            this.FrancepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FrancepictureBox.TabIndex = 0;
            this.FrancepictureBox.TabStop = false;
            this.FrancepictureBox.Click += new System.EventHandler(this.FrancepictureBox_Click);
            // 
            // GermanypictureBox
            // 
            this.GermanypictureBox.Image = global::Tutorial2_4.Properties.Resources.Germany;
            this.GermanypictureBox.Location = new System.Drawing.Point(538, 131);
            this.GermanypictureBox.Name = "GermanypictureBox";
            this.GermanypictureBox.Size = new System.Drawing.Size(223, 132);
            this.GermanypictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GermanypictureBox.TabIndex = 1;
            this.GermanypictureBox.TabStop = false;
            this.GermanypictureBox.Click += new System.EventHandler(this.GermanypictureBox_Click);
            // 
            // FinlandpictureBox
            // 
            this.FinlandpictureBox.Image = global::Tutorial2_4.Properties.Resources.Finland;
            this.FinlandpictureBox.Location = new System.Drawing.Point(80, 131);
            this.FinlandpictureBox.Name = "FinlandpictureBox";
            this.FinlandpictureBox.Size = new System.Drawing.Size(223, 132);
            this.FinlandpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FinlandpictureBox.TabIndex = 2;
            this.FinlandpictureBox.TabStop = false;
            this.FinlandpictureBox.Click += new System.EventHandler(this.FinlandpictureBox_Click);
            // 
            // countrylabel
            // 
            this.countrylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countrylabel.Location = new System.Drawing.Point(343, 288);
            this.countrylabel.Name = "countrylabel";
            this.countrylabel.Size = new System.Drawing.Size(173, 60);
            this.countrylabel.TabIndex = 3;
            this.countrylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(234, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "點選一個國旗,我告訴你是哪個國家";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countrylabel);
            this.Controls.Add(this.FinlandpictureBox);
            this.Controls.Add(this.GermanypictureBox);
            this.Controls.Add(this.FrancepictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FrancepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GermanypictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinlandpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FrancepictureBox;
        private System.Windows.Forms.PictureBox GermanypictureBox;
        private System.Windows.Forms.PictureBox FinlandpictureBox;
        private System.Windows.Forms.Label countrylabel;
        private System.Windows.Forms.Label label1;
    }
}

