namespace Tutorial2_5
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
            this.cardpackpictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardfacepictureBox2 = new System.Windows.Forms.PictureBox();
            this.showbackbutton1 = new System.Windows.Forms.Button();
            this.showfacebutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardpackpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacepictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cardpackpictureBox1
            // 
            this.cardpackpictureBox1.Image = global::Tutorial2_5.Properties.Resources.Backface_Blue;
            this.cardpackpictureBox1.Location = new System.Drawing.Point(286, 40);
            this.cardpackpictureBox1.Name = "cardpackpictureBox1";
            this.cardpackpictureBox1.Size = new System.Drawing.Size(180, 303);
            this.cardpackpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardpackpictureBox1.TabIndex = 0;
            this.cardpackpictureBox1.TabStop = false;
            // 
            // cardfacepictureBox2
            // 
            this.cardfacepictureBox2.Image = global::Tutorial2_5.Properties.Resources.Joker_Black;
            this.cardfacepictureBox2.Location = new System.Drawing.Point(286, 40);
            this.cardfacepictureBox2.Name = "cardfacepictureBox2";
            this.cardfacepictureBox2.Size = new System.Drawing.Size(180, 303);
            this.cardfacepictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardfacepictureBox2.TabIndex = 1;
            this.cardfacepictureBox2.TabStop = false;
            this.cardfacepictureBox2.Visible = false;
            // 
            // showbackbutton1
            // 
            this.showbackbutton1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showbackbutton1.Location = new System.Drawing.Point(159, 373);
            this.showbackbutton1.Name = "showbackbutton1";
            this.showbackbutton1.Size = new System.Drawing.Size(208, 90);
            this.showbackbutton1.TabIndex = 2;
            this.showbackbutton1.Text = "顯示背面";
            this.showbackbutton1.UseVisualStyleBackColor = true;
            this.showbackbutton1.Click += new System.EventHandler(this.showbackbutton1_Click);
            // 
            // showfacebutton2
            // 
            this.showfacebutton2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showfacebutton2.Location = new System.Drawing.Point(378, 373);
            this.showfacebutton2.Name = "showfacebutton2";
            this.showfacebutton2.Size = new System.Drawing.Size(208, 90);
            this.showfacebutton2.TabIndex = 3;
            this.showfacebutton2.Text = "顯示正面";
            this.showfacebutton2.UseVisualStyleBackColor = true;
            this.showfacebutton2.Click += new System.EventHandler(this.showfacebutton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.showfacebutton2);
            this.Controls.Add(this.showbackbutton1);
            this.Controls.Add(this.cardfacepictureBox2);
            this.Controls.Add(this.cardpackpictureBox1);
            this.Name = "Form1";
            this.Text = "撲克牌展示";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardpackpictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacepictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardpackpictureBox1;
        private System.Windows.Forms.PictureBox cardfacepictureBox2;
        private System.Windows.Forms.Button showbackbutton1;
        private System.Windows.Forms.Button showfacebutton2;
    }
}

