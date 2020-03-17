namespace NewTennisScoreSystem
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
            this.PlayerRightServe = new System.Windows.Forms.Button();
            this.PlayerLeftServe = new System.Windows.Forms.Button();
            this.PointsLeftLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PointsRightLabel = new System.Windows.Forms.Label();
            this.PointWonByText = new System.Windows.Forms.Label();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.WinnerStaticLabel = new System.Windows.Forms.Label();
            this.RightNameStaticLabel = new System.Windows.Forms.Label();
            this.LeftNameStaticLabel = new System.Windows.Forms.Label();
            this.RulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerRightServe
            // 
            this.PlayerRightServe.BackColor = System.Drawing.Color.Lime;
            this.PlayerRightServe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerRightServe.Location = new System.Drawing.Point(582, 311);
            this.PlayerRightServe.Name = "PlayerRightServe";
            this.PlayerRightServe.Size = new System.Drawing.Size(113, 42);
            this.PlayerRightServe.TabIndex = 0;
            this.PlayerRightServe.Text = "Serve";
            this.PlayerRightServe.UseVisualStyleBackColor = false;
            this.PlayerRightServe.Click += new System.EventHandler(this.PlayerRightServe_Click);
            // 
            // PlayerLeftServe
            // 
            this.PlayerLeftServe.BackColor = System.Drawing.Color.Chartreuse;
            this.PlayerLeftServe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLeftServe.Location = new System.Drawing.Point(105, 311);
            this.PlayerLeftServe.Name = "PlayerLeftServe";
            this.PlayerLeftServe.Size = new System.Drawing.Size(113, 42);
            this.PlayerLeftServe.TabIndex = 1;
            this.PlayerLeftServe.Text = "Serve";
            this.PlayerLeftServe.UseVisualStyleBackColor = false;
            this.PlayerLeftServe.Click += new System.EventHandler(this.PlayerLeftServe_Click);
            // 
            // PointsLeftLabel
            // 
            this.PointsLeftLabel.AutoSize = true;
            this.PointsLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLeftLabel.Location = new System.Drawing.Point(14, 158);
            this.PointsLeftLabel.Name = "PointsLeftLabel";
            this.PointsLeftLabel.Size = new System.Drawing.Size(61, 20);
            this.PointsLeftLabel.TabIndex = 5;
            this.PointsLeftLabel.Text = "Points: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Source Sans Pro Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(247, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 71);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tennis Game";
            // 
            // PointsRightLabel
            // 
            this.PointsRightLabel.AutoSize = true;
            this.PointsRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsRightLabel.Location = new System.Drawing.Point(709, 158);
            this.PointsRightLabel.Name = "PointsRightLabel";
            this.PointsRightLabel.Size = new System.Drawing.Size(61, 20);
            this.PointsRightLabel.TabIndex = 12;
            this.PointsRightLabel.Text = "Points: ";
            // 
            // PointWonByText
            // 
            this.PointWonByText.AutoSize = true;
            this.PointWonByText.Location = new System.Drawing.Point(361, 142);
            this.PointWonByText.Name = "PointWonByText";
            this.PointWonByText.Size = new System.Drawing.Size(0, 13);
            this.PointWonByText.TabIndex = 18;
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerLabel.Location = new System.Drawing.Point(371, 71);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(19, 20);
            this.WinnerLabel.TabIndex = 19;
            this.WinnerLabel.Text = "--";
            // 
            // WinnerStaticLabel
            // 
            this.WinnerStaticLabel.AutoSize = true;
            this.WinnerStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerStaticLabel.Location = new System.Drawing.Point(253, 71);
            this.WinnerStaticLabel.Name = "WinnerStaticLabel";
            this.WinnerStaticLabel.Size = new System.Drawing.Size(122, 20);
            this.WinnerStaticLabel.TabIndex = 20;
            this.WinnerStaticLabel.Text = "Round goes to: ";
            // 
            // RightNameStaticLabel
            // 
            this.RightNameStaticLabel.AutoSize = true;
            this.RightNameStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightNameStaticLabel.Location = new System.Drawing.Point(708, 130);
            this.RightNameStaticLabel.Name = "RightNameStaticLabel";
            this.RightNameStaticLabel.Size = new System.Drawing.Size(80, 25);
            this.RightNameStaticLabel.TabIndex = 21;
            this.RightNameStaticLabel.Text = "Federer";
            // 
            // LeftNameStaticLabel
            // 
            this.LeftNameStaticLabel.AutoSize = true;
            this.LeftNameStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftNameStaticLabel.Location = new System.Drawing.Point(12, 133);
            this.LeftNameStaticLabel.Name = "LeftNameStaticLabel";
            this.LeftNameStaticLabel.Size = new System.Drawing.Size(63, 25);
            this.LeftNameStaticLabel.TabIndex = 22;
            this.LeftNameStaticLabel.Text = "Nadal";
            // 
            // RulesButton
            // 
            this.RulesButton.BackColor = System.Drawing.SystemColors.Control;
            this.RulesButton.Location = new System.Drawing.Point(18, 13);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(75, 23);
            this.RulesButton.TabIndex = 23;
            this.RulesButton.Text = "Rules";
            this.RulesButton.UseVisualStyleBackColor = false;
            this.RulesButton.Click += new System.EventHandler(this.RulesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::NewTennisScoreSystem.Properties.Resources.TennisField;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RulesButton);
            this.Controls.Add(this.LeftNameStaticLabel);
            this.Controls.Add(this.RightNameStaticLabel);
            this.Controls.Add(this.WinnerStaticLabel);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.PointWonByText);
            this.Controls.Add(this.PointsRightLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PointsLeftLabel);
            this.Controls.Add(this.PlayerLeftServe);
            this.Controls.Add(this.PlayerRightServe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayerRightServe;
        private System.Windows.Forms.Button PlayerLeftServe;
        private System.Windows.Forms.Label PointsLeftLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PointsRightLabel;
        private System.Windows.Forms.Label PointWonByText;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.Label WinnerStaticLabel;
        private System.Windows.Forms.Label RightNameStaticLabel;
        private System.Windows.Forms.Label LeftNameStaticLabel;
        private System.Windows.Forms.Button RulesButton;
    }
}

