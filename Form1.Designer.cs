namespace PaintJobEstimator
{
    partial class Form1
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
            this.test1PromptLable = new System.Windows.Forms.Label();
            this.test2PromptLable = new System.Windows.Forms.Label();
            this.test3PromptLable = new System.Windows.Forms.Label();
            this.outputDescriptionLable = new System.Windows.Forms.Label();
            this.averageLable = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1PromptLable
            // 
            this.test1PromptLable.AutoSize = true;
            this.test1PromptLable.Location = new System.Drawing.Point(194, 48);
            this.test1PromptLable.Name = "test1PromptLable";
            this.test1PromptLable.Size = new System.Drawing.Size(40, 13);
            this.test1PromptLable.TabIndex = 0;
            this.test1PromptLable.Text = "Test 1:";
            // 
            // test2PromptLable
            // 
            this.test2PromptLable.AutoSize = true;
            this.test2PromptLable.Location = new System.Drawing.Point(194, 97);
            this.test2PromptLable.Name = "test2PromptLable";
            this.test2PromptLable.Size = new System.Drawing.Size(40, 13);
            this.test2PromptLable.TabIndex = 1;
            this.test2PromptLable.Text = "Test 2:";
            // 
            // test3PromptLable
            // 
            this.test3PromptLable.AutoSize = true;
            this.test3PromptLable.Location = new System.Drawing.Point(194, 143);
            this.test3PromptLable.Name = "test3PromptLable";
            this.test3PromptLable.Size = new System.Drawing.Size(40, 13);
            this.test3PromptLable.TabIndex = 2;
            this.test3PromptLable.Text = "Test 3:";
            // 
            // outputDescriptionLable
            // 
            this.outputDescriptionLable.AutoSize = true;
            this.outputDescriptionLable.Location = new System.Drawing.Point(165, 203);
            this.outputDescriptionLable.Name = "outputDescriptionLable";
            this.outputDescriptionLable.Size = new System.Drawing.Size(105, 13);
            this.outputDescriptionLable.TabIndex = 3;
            this.outputDescriptionLable.Text = "Average Test Score:";
            // 
            // averageLable
            // 
            this.averageLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLable.Location = new System.Drawing.Point(304, 193);
            this.averageLable.Name = "averageLable";
            this.averageLable.Size = new System.Drawing.Size(100, 23);
            this.averageLable.TabIndex = 4;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(281, 136);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 20);
            this.test3TextBox.TabIndex = 5;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(281, 90);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.test2TextBox.TabIndex = 6;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(281, 41);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(136, 322);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 44);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(258, 322);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 44);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(395, 322);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 44);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.averageLable);
            this.Controls.Add(this.outputDescriptionLable);
            this.Controls.Add(this.test3PromptLable);
            this.Controls.Add(this.test2PromptLable);
            this.Controls.Add(this.test1PromptLable);
            this.Name = "Form1";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1PromptLable;
        private System.Windows.Forms.Label test2PromptLable;
        private System.Windows.Forms.Label test3PromptLable;
        private System.Windows.Forms.Label outputDescriptionLable;
        private System.Windows.Forms.Label averageLable;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

