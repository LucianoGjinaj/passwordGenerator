namespace PasswordGenerator
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.passwordLengthSlider = new System.Windows.Forms.TrackBar();
            this.generatePasswordButton = new System.Windows.Forms.Button();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            this.IncludeUpperCaseLabel = new System.Windows.Forms.Label();
            this.includeUpperCase = new System.Windows.Forms.CheckBox();
            this.includeLowercaseLabel = new System.Windows.Forms.Label();
            this.includeLowerCase = new System.Windows.Forms.CheckBox();
            this.includeNumberLabel = new System.Windows.Forms.Label();
            this.includeNumber = new System.Windows.Forms.CheckBox();
            this.includeSymbolLabel = new System.Windows.Forms.Label();
            this.inludeSymbol = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(27, 41);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(648, 47);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password Label";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLengthLabel.Location = new System.Drawing.Point(23, 117);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(379, 47);
            this.passwordLengthLabel.TabIndex = 1;
            this.passwordLengthLabel.Text = "Password Length:  8";
            // 
            // passwordLengthSlider
            // 
            this.passwordLengthSlider.Location = new System.Drawing.Point(445, 119);
            this.passwordLengthSlider.Name = "passwordLengthSlider";
            this.passwordLengthSlider.Size = new System.Drawing.Size(314, 45);
            this.passwordLengthSlider.TabIndex = 2;
            this.passwordLengthSlider.Scroll += new System.EventHandler(this.passwordLengthSlider_Scroll);
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.BackColor = System.Drawing.Color.White;
            this.generatePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePasswordButton.Location = new System.Drawing.Point(30, 303);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(230, 44);
            this.generatePasswordButton.TabIndex = 3;
            this.generatePasswordButton.Text = "Generate Password";
            this.generatePasswordButton.UseVisualStyleBackColor = false;
            this.generatePasswordButton.Click += new System.EventHandler(this.generatePasswordButton_Click);
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.BackColor = System.Drawing.Color.White;
            this.CopyPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPasswordButton.Location = new System.Drawing.Point(445, 303);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(230, 44);
            this.CopyPasswordButton.TabIndex = 4;
            this.CopyPasswordButton.Text = "Copy Password";
            this.CopyPasswordButton.UseVisualStyleBackColor = false;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // IncludeUpperCaseLabel
            // 
            this.IncludeUpperCaseLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeUpperCaseLabel.Location = new System.Drawing.Point(23, 164);
            this.IncludeUpperCaseLabel.Name = "IncludeUpperCaseLabel";
            this.IncludeUpperCaseLabel.Size = new System.Drawing.Size(344, 33);
            this.IncludeUpperCaseLabel.TabIndex = 5;
            this.IncludeUpperCaseLabel.Text = "Include Uppercase Letter\r\n";
            // 
            // includeUpperCase
            // 
            this.includeUpperCase.AutoSize = true;
            this.includeUpperCase.Location = new System.Drawing.Point(303, 172);
            this.includeUpperCase.Name = "includeUpperCase";
            this.includeUpperCase.Size = new System.Drawing.Size(79, 17);
            this.includeUpperCase.TabIndex = 6;
            this.includeUpperCase.Text = "(e.g ABCD)";
            this.includeUpperCase.UseVisualStyleBackColor = true;
            // 
            // includeLowercaseLabel
            // 
            this.includeLowercaseLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includeLowercaseLabel.Location = new System.Drawing.Point(23, 192);
            this.includeLowercaseLabel.Name = "includeLowercaseLabel";
            this.includeLowercaseLabel.Size = new System.Drawing.Size(344, 25);
            this.includeLowercaseLabel.TabIndex = 7;
            this.includeLowercaseLabel.Text = "Include Lowercase Letter";
            // 
            // includeLowerCase
            // 
            this.includeLowerCase.AutoSize = true;
            this.includeLowerCase.Location = new System.Drawing.Point(303, 200);
            this.includeLowerCase.Name = "includeLowerCase";
            this.includeLowerCase.Size = new System.Drawing.Size(74, 17);
            this.includeLowerCase.TabIndex = 8;
            this.includeLowerCase.Text = "(e.g abcd)";
            this.includeLowerCase.UseVisualStyleBackColor = true;
            // 
            // includeNumberLabel
            // 
            this.includeNumberLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includeNumberLabel.Location = new System.Drawing.Point(23, 220);
            this.includeNumberLabel.Name = "includeNumberLabel";
            this.includeNumberLabel.Size = new System.Drawing.Size(344, 25);
            this.includeNumberLabel.TabIndex = 9;
            this.includeNumberLabel.Text = "Include Number";
            // 
            // includeNumber
            // 
            this.includeNumber.AutoSize = true;
            this.includeNumber.Location = new System.Drawing.Point(303, 228);
            this.includeNumber.Name = "includeNumber";
            this.includeNumber.Size = new System.Drawing.Size(74, 17);
            this.includeNumber.TabIndex = 10;
            this.includeNumber.Text = "(e.g 1234)";
            this.includeNumber.UseVisualStyleBackColor = true;
            // 
            // includeSymbolLabel
            // 
            this.includeSymbolLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includeSymbolLabel.Location = new System.Drawing.Point(23, 245);
            this.includeSymbolLabel.Name = "includeSymbolLabel";
            this.includeSymbolLabel.Size = new System.Drawing.Size(344, 25);
            this.includeSymbolLabel.TabIndex = 11;
            this.includeSymbolLabel.Text = "Include Symbol";
            // 
            // inludeSymbol
            // 
            this.inludeSymbol.AutoSize = true;
            this.inludeSymbol.Location = new System.Drawing.Point(303, 253);
            this.inludeSymbol.Name = "inludeSymbol";
            this.inludeSymbol.Size = new System.Drawing.Size(77, 17);
            this.inludeSymbol.TabIndex = 12;
            this.inludeSymbol.Text = "(e.g !@#$)";
            this.inludeSymbol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inludeSymbol);
            this.Controls.Add(this.includeSymbolLabel);
            this.Controls.Add(this.includeNumber);
            this.Controls.Add(this.includeNumberLabel);
            this.Controls.Add(this.includeLowerCase);
            this.Controls.Add(this.includeLowercaseLabel);
            this.Controls.Add(this.includeUpperCase);
            this.Controls.Add(this.IncludeUpperCaseLabel);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.generatePasswordButton);
            this.Controls.Add(this.passwordLengthSlider);
            this.Controls.Add(this.passwordLengthLabel);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.TrackBar passwordLengthSlider;
        private System.Windows.Forms.Button generatePasswordButton;
        private System.Windows.Forms.Button CopyPasswordButton;
        private System.Windows.Forms.Label IncludeUpperCaseLabel;
        private System.Windows.Forms.CheckBox includeUpperCase;
        private System.Windows.Forms.Label includeLowercaseLabel;
        private System.Windows.Forms.CheckBox includeLowerCase;
        private System.Windows.Forms.Label includeNumberLabel;
        private System.Windows.Forms.CheckBox includeNumber;
        private System.Windows.Forms.Label includeSymbolLabel;
        private System.Windows.Forms.CheckBox inludeSymbol;
    }
}

