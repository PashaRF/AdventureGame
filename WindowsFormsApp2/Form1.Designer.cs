namespace WindowsFormsApp2
{
    partial class PointAndClickGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointAndClickGame));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.arrowDown = new System.Windows.Forms.PictureBox();
            this.arrowRight = new System.Windows.Forms.PictureBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.arrowLeft = new System.Windows.Forms.PictureBox();
            this.arrowUp = new System.Windows.Forms.PictureBox();
            this.lock4 = new System.Windows.Forms.Label();
            this.lock3 = new System.Windows.Forms.Label();
            this.lock2 = new System.Windows.Forms.Label();
            this.lock1 = new System.Windows.Forms.Label();
            this.attackTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOverText = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.monsterImage = new System.Windows.Forms.PictureBox();
            this.passwordInput = new System.Windows.Forms.MaskedTextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.flowerImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // arrowDown
            // 
            this.arrowDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowDown.BackgroundImage")));
            this.arrowDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowDown.Location = new System.Drawing.Point(360, 370);
            this.arrowDown.Name = "arrowDown";
            this.arrowDown.Size = new System.Drawing.Size(78, 68);
            this.arrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowDown.TabIndex = 1;
            this.arrowDown.TabStop = false;
            this.arrowDown.Click += new System.EventHandler(this.arrowDown_Click);
            // 
            // arrowRight
            // 
            this.arrowRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowRight.BackgroundImage")));
            this.arrowRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arrowRight.Location = new System.Drawing.Point(716, 178);
            this.arrowRight.Name = "arrowRight";
            this.arrowRight.Size = new System.Drawing.Size(72, 68);
            this.arrowRight.TabIndex = 2;
            this.arrowRight.TabStop = false;
            this.arrowRight.Click += new System.EventHandler(this.arrowRight_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // arrowLeft
            // 
            this.arrowLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowLeft.BackgroundImage")));
            this.arrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowLeft.Location = new System.Drawing.Point(12, 178);
            this.arrowLeft.Name = "arrowLeft";
            this.arrowLeft.Size = new System.Drawing.Size(72, 68);
            this.arrowLeft.TabIndex = 3;
            this.arrowLeft.TabStop = false;
            this.arrowLeft.Click += new System.EventHandler(this.arrowLeft_Click);
            // 
            // arrowUp
            // 
            this.arrowUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowUp.BackgroundImage")));
            this.arrowUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arrowUp.Location = new System.Drawing.Point(360, 12);
            this.arrowUp.Name = "arrowUp";
            this.arrowUp.Size = new System.Drawing.Size(65, 65);
            this.arrowUp.TabIndex = 4;
            this.arrowUp.TabStop = false;
            this.arrowUp.Click += new System.EventHandler(this.arrowUp_Click);
            // 
            // lock4
            // 
            this.lock4.AutoSize = true;
            this.lock4.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.25F);
            this.lock4.Location = new System.Drawing.Point(327, 222);
            this.lock4.Name = "lock4";
            this.lock4.Size = new System.Drawing.Size(60, 65);
            this.lock4.TabIndex = 5;
            this.lock4.Text = "0";
            this.lock4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock4.Click += new System.EventHandler(this.lock4_Click);
            // 
            // lock3
            // 
            this.lock3.AutoSize = true;
            this.lock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.25F);
            this.lock3.Location = new System.Drawing.Point(261, 222);
            this.lock3.Name = "lock3";
            this.lock3.Size = new System.Drawing.Size(60, 65);
            this.lock3.TabIndex = 6;
            this.lock3.Text = "0";
            this.lock3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock3.Click += new System.EventHandler(this.lock3_Click);
            // 
            // lock2
            // 
            this.lock2.AutoSize = true;
            this.lock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.25F);
            this.lock2.Location = new System.Drawing.Point(195, 222);
            this.lock2.Name = "lock2";
            this.lock2.Size = new System.Drawing.Size(60, 65);
            this.lock2.TabIndex = 7;
            this.lock2.Text = "0";
            this.lock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock2.Click += new System.EventHandler(this.lock2_Click);
            // 
            // lock1
            // 
            this.lock1.AutoSize = true;
            this.lock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.25F);
            this.lock1.Location = new System.Drawing.Point(129, 222);
            this.lock1.Name = "lock1";
            this.lock1.Size = new System.Drawing.Size(60, 65);
            this.lock1.TabIndex = 8;
            this.lock1.Text = "0";
            this.lock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock1.Click += new System.EventHandler(this.lock1_Click);
            // 
            // attackTimer
            // 
            this.attackTimer.Enabled = true;
            this.attackTimer.Interval = 4;
            this.attackTimer.Tick += new System.EventHandler(this.attackTimer_Tick);
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.gameOverText.Location = new System.Drawing.Point(142, 99);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(537, 59);
            this.gameOverText.TabIndex = 9;
            this.gameOverText.Text = "You Lose. Play Again?";
            // 
            // yesButton
            // 
            this.yesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.yesButton.Location = new System.Drawing.Point(460, 245);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(181, 89);
            this.yesButton.TabIndex = 10;
            this.yesButton.Text = "Yes!";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.noButton.Location = new System.Drawing.Point(152, 245);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(181, 89);
            this.noButton.TabIndex = 11;
            this.noButton.Text = "No!";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // monsterImage
            // 
            this.monsterImage.BackColor = System.Drawing.Color.Transparent;
            this.monsterImage.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.evilMonster;
            this.monsterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monsterImage.Image = global::WindowsFormsApp2.Properties.Resources.evilMonster;
            this.monsterImage.Location = new System.Drawing.Point(251, 115);
            this.monsterImage.Margin = new System.Windows.Forms.Padding(0);
            this.monsterImage.Name = "monsterImage";
            this.monsterImage.Size = new System.Drawing.Size(313, 210);
            this.monsterImage.TabIndex = 12;
            this.monsterImage.TabStop = false;
            this.monsterImage.Click += new System.EventHandler(this.monsterImage_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(310, 145);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(219, 35);
            this.passwordInput.TabIndex = 14;
            this.passwordInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.passwordInput_MaskInputRejected);
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(343, 193);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(145, 19);
            this.enterButton.TabIndex = 15;
            this.enterButton.Text = "ENTER";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // flowerImage
            // 
            this.flowerImage.BackColor = System.Drawing.Color.Transparent;
            this.flowerImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowerImage.BackgroundImage")));
            this.flowerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowerImage.Location = new System.Drawing.Point(320, 39);
            this.flowerImage.Name = "flowerImage";
            this.flowerImage.Size = new System.Drawing.Size(168, 173);
            this.flowerImage.TabIndex = 16;
            this.flowerImage.TabStop = false;
            // 
            // PointAndClickGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.page9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowerImage);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.monsterImage);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.lock1);
            this.Controls.Add(this.lock2);
            this.Controls.Add(this.lock3);
            this.Controls.Add(this.lock4);
            this.Controls.Add(this.arrowUp);
            this.Controls.Add(this.arrowLeft);
            this.Controls.Add(this.arrowRight);
            this.Controls.Add(this.arrowDown);
            this.Name = "PointAndClickGame";
            this.Text = "Escape Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox arrowDown;
        private System.Windows.Forms.PictureBox arrowRight;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.PictureBox arrowLeft;
        private System.Windows.Forms.PictureBox arrowUp;
        private System.Windows.Forms.Label lock4;
        private System.Windows.Forms.Label lock3;
        private System.Windows.Forms.Label lock2;
        private System.Windows.Forms.Label lock1;
        private System.Windows.Forms.Timer attackTimer;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.PictureBox monsterImage;
        private System.Windows.Forms.MaskedTextBox passwordInput;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.PictureBox flowerImage;
    }
}

