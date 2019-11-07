namespace ExcitingVirtualPet
{
    partial class PetForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.petPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.petWaterButton = new System.Windows.Forms.Button();
            this.petPetButton = new System.Windows.Forms.Button();
            this.petPlayButton = new System.Windows.Forms.Button();
            this.feedPetButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.affectionMeter = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.boredomMeter = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.thirstMeter = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.hungerMeter = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.energyBar = new System.Windows.Forms.ProgressBar();
            this.foodAmountBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.waterAmountBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.mainLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.sleepingLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.petPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet Display";
            // 
            // petPictureBox
            // 
            this.petPictureBox.Location = new System.Drawing.Point(6, 19);
            this.petPictureBox.Name = "petPictureBox";
            this.petPictureBox.Size = new System.Drawing.Size(316, 269);
            this.petPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.petPictureBox.TabIndex = 0;
            this.petPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.petWaterButton);
            this.groupBox2.Controls.Add(this.petPetButton);
            this.groupBox2.Controls.Add(this.petPlayButton);
            this.groupBox2.Controls.Add(this.feedPetButton);
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pet Controls";
            // 
            // petWaterButton
            // 
            this.petWaterButton.Location = new System.Drawing.Point(6, 48);
            this.petWaterButton.Name = "petWaterButton";
            this.petWaterButton.Size = new System.Drawing.Size(211, 23);
            this.petWaterButton.TabIndex = 0;
            this.petWaterButton.Text = "Give Cat Water";
            this.petWaterButton.UseVisualStyleBackColor = true;
            this.petWaterButton.Click += new System.EventHandler(this.petWaterButton_Click_1);
            // 
            // petPetButton
            // 
            this.petPetButton.Location = new System.Drawing.Point(6, 106);
            this.petPetButton.Name = "petPetButton";
            this.petPetButton.Size = new System.Drawing.Size(211, 23);
            this.petPetButton.TabIndex = 0;
            this.petPetButton.Text = "Pet Cat";
            this.petPetButton.UseVisualStyleBackColor = true;
            this.petPetButton.Click += new System.EventHandler(this.petPetButton_Click_1);
            // 
            // petPlayButton
            // 
            this.petPlayButton.Location = new System.Drawing.Point(6, 77);
            this.petPlayButton.Name = "petPlayButton";
            this.petPlayButton.Size = new System.Drawing.Size(211, 23);
            this.petPlayButton.TabIndex = 0;
            this.petPlayButton.Text = "Play With Cat";
            this.petPlayButton.UseVisualStyleBackColor = true;
            this.petPlayButton.Click += new System.EventHandler(this.petPlayButton_Click_1);
            // 
            // feedPetButton
            // 
            this.feedPetButton.Location = new System.Drawing.Point(6, 19);
            this.feedPetButton.Name = "feedPetButton";
            this.feedPetButton.Size = new System.Drawing.Size(211, 23);
            this.feedPetButton.TabIndex = 0;
            this.feedPetButton.Text = "Feed Cat";
            this.feedPetButton.UseVisualStyleBackColor = true;
            this.feedPetButton.Click += new System.EventHandler(this.feedPetButton_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.affectionMeter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.boredomMeter);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.thirstMeter);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.hungerMeter);
            this.groupBox3.Location = new System.Drawing.Point(346, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cat Facts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Affection";
            // 
            // affectionMeter
            // 
            this.affectionMeter.Location = new System.Drawing.Point(61, 124);
            this.affectionMeter.Maximum = 10;
            this.affectionMeter.Name = "affectionMeter";
            this.affectionMeter.Size = new System.Drawing.Size(156, 23);
            this.affectionMeter.Step = 1;
            this.affectionMeter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boredom";
            // 
            // boredomMeter
            // 
            this.boredomMeter.Location = new System.Drawing.Point(61, 87);
            this.boredomMeter.Maximum = 10;
            this.boredomMeter.Name = "boredomMeter";
            this.boredomMeter.Size = new System.Drawing.Size(156, 23);
            this.boredomMeter.Step = 1;
            this.boredomMeter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thirst";
            // 
            // thirstMeter
            // 
            this.thirstMeter.Location = new System.Drawing.Point(61, 52);
            this.thirstMeter.Maximum = 10;
            this.thirstMeter.Name = "thirstMeter";
            this.thirstMeter.Size = new System.Drawing.Size(156, 23);
            this.thirstMeter.Step = 1;
            this.thirstMeter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hunger";
            // 
            // hungerMeter
            // 
            this.hungerMeter.Location = new System.Drawing.Point(61, 19);
            this.hungerMeter.Maximum = 10;
            this.hungerMeter.Name = "hungerMeter";
            this.hungerMeter.Size = new System.Drawing.Size(156, 23);
            this.hungerMeter.Step = 1;
            this.hungerMeter.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.energyBar);
            this.groupBox4.Controls.Add(this.foodAmountBar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.waterAmountBar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(557, 76);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resources";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Energy:";
            // 
            // energyBar
            // 
            this.energyBar.Location = new System.Drawing.Point(378, 24);
            this.energyBar.Maximum = 50;
            this.energyBar.Name = "energyBar";
            this.energyBar.Size = new System.Drawing.Size(162, 23);
            this.energyBar.Step = 1;
            this.energyBar.TabIndex = 2;
            // 
            // foodAmountBar
            // 
            this.foodAmountBar.Location = new System.Drawing.Point(199, 24);
            this.foodAmountBar.Maximum = 10;
            this.foodAmountBar.Name = "foodAmountBar";
            this.foodAmountBar.Size = new System.Drawing.Size(162, 23);
            this.foodAmountBar.Step = 1;
            this.foodAmountBar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Food Dish:";
            // 
            // waterAmountBar
            // 
            this.waterAmountBar.Location = new System.Drawing.Point(14, 24);
            this.waterAmountBar.Maximum = 10;
            this.waterAmountBar.Name = "waterAmountBar";
            this.waterAmountBar.Size = new System.Drawing.Size(162, 23);
            this.waterAmountBar.Step = 1;
            this.waterAmountBar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Water Dish:";
            // 
            // mainLoopTimer
            // 
            this.mainLoopTimer.Tick += new System.EventHandler(this.mainLoopTimer_Tick_1);
            // 
            // sleepingLabel
            // 
            this.sleepingLabel.AutoSize = true;
            this.sleepingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepingLabel.Location = new System.Drawing.Point(451, 9);
            this.sleepingLabel.Name = "sleepingLabel";
            this.sleepingLabel.Size = new System.Drawing.Size(65, 12);
            this.sleepingLabel.TabIndex = 4;
            this.sleepingLabel.Text = "Pet is Sleeping";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(75, 407);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(426, 407);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 442);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.sleepingLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PetForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Virtual Pet";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox petPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button petWaterButton;
        private System.Windows.Forms.Button petPetButton;
        private System.Windows.Forms.Button petPlayButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar affectionMeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar boredomMeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar thirstMeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar foodAmountBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar waterAmountBar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ProgressBar hungerMeter;
        public System.Windows.Forms.Button feedPetButton;
        private System.Windows.Forms.Timer mainLoopTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar energyBar;
        private System.Windows.Forms.Label sleepingLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

