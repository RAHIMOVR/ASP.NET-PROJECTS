namespace CalculatorApp
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox = new TextBox();
            Seven = new Button();
            Four = new Button();
            One = new Button();
            Two = new Button();
            Five = new Button();
            Eight = new Button();
            Three = new Button();
            Six = new Button();
            Nine = new Button();
            Equal = new Button();
            Dot = new Button();
            Zero = new Button();
            Module = new Button();
            Division = new Button();
            Multiplication = new Button();
            Negative = new Button();
            Minus = new Button();
            Plus = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox.Location = new Point(12, 22);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(612, 70);
            TextBox.TabIndex = 0;
            TextBox.Text = "0";
            TextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Seven
            // 
            Seven.Location = new Point(12, 136);
            Seven.Name = "Seven";
            Seven.Size = new Size(105, 102);
            Seven.TabIndex = 1;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Four
            // 
            Four.Location = new Point(12, 244);
            Four.Name = "Four";
            Four.Size = new Size(105, 102);
            Four.TabIndex = 2;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            // 
            // One
            // 
            One.Location = new Point(12, 352);
            One.Name = "One";
            One.Size = new Size(105, 102);
            One.TabIndex = 3;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            // 
            // Two
            // 
            Two.Location = new Point(123, 352);
            Two.Name = "Two";
            Two.Size = new Size(105, 102);
            Two.TabIndex = 6;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            // 
            // Five
            // 
            Five.Location = new Point(123, 244);
            Five.Name = "Five";
            Five.Size = new Size(105, 102);
            Five.TabIndex = 5;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            // 
            // Eight
            // 
            Eight.Location = new Point(123, 136);
            Eight.Name = "Eight";
            Eight.Size = new Size(105, 102);
            Eight.TabIndex = 4;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            // 
            // Three
            // 
            Three.Location = new Point(234, 352);
            Three.Name = "Three";
            Three.Size = new Size(105, 102);
            Three.TabIndex = 9;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            // 
            // Six
            // 
            Six.Location = new Point(234, 244);
            Six.Name = "Six";
            Six.Size = new Size(105, 102);
            Six.TabIndex = 8;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Nine
            // 
            Nine.Location = new Point(234, 136);
            Nine.Name = "Nine";
            Nine.Size = new Size(105, 102);
            Nine.TabIndex = 7;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            // 
            // Equal
            // 
            Equal.Location = new Point(234, 460);
            Equal.Name = "Equal";
            Equal.Size = new Size(105, 102);
            Equal.TabIndex = 15;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Dot
            // 
            Dot.Location = new Point(123, 460);
            Dot.Name = "Dot";
            Dot.Size = new Size(105, 102);
            Dot.TabIndex = 14;
            Dot.Text = ".";
            Dot.UseVisualStyleBackColor = true;
            // 
            // Zero
            // 
            Zero.Location = new Point(12, 460);
            Zero.Name = "Zero";
            Zero.Size = new Size(105, 102);
            Zero.TabIndex = 13;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            // 
            // Module
            // 
            Module.Location = new Point(519, 460);
            Module.Name = "Module";
            Module.Size = new Size(105, 102);
            Module.TabIndex = 19;
            Module.Text = "%";
            Module.UseVisualStyleBackColor = true;
            // 
            // Division
            // 
            Division.Location = new Point(519, 352);
            Division.Name = "Division";
            Division.Size = new Size(105, 102);
            Division.TabIndex = 18;
            Division.Text = "/";
            Division.UseVisualStyleBackColor = true;
            // 
            // Multiplication
            // 
            Multiplication.Location = new Point(519, 244);
            Multiplication.Name = "Multiplication";
            Multiplication.Size = new Size(105, 102);
            Multiplication.TabIndex = 17;
            Multiplication.Text = "*";
            Multiplication.UseVisualStyleBackColor = true;
            // 
            // Negative
            // 
            Negative.Location = new Point(408, 460);
            Negative.Name = "Negative";
            Negative.Size = new Size(105, 102);
            Negative.TabIndex = 23;
            Negative.Text = "+/-";
            Negative.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            Minus.Location = new Point(408, 352);
            Minus.Name = "Minus";
            Minus.Size = new Size(105, 102);
            Minus.TabIndex = 22;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            // 
            // Plus
            // 
            Plus.Location = new Point(408, 244);
            Plus.Name = "Plus";
            Plus.Size = new Size(105, 102);
            Plus.TabIndex = 21;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            Clear.Location = new Point(408, 136);
            Clear.Name = "Clear";
            Clear.Size = new Size(216, 102);
            Clear.TabIndex = 20;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 576);
            Controls.Add(Negative);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Controls.Add(Clear);
            Controls.Add(Module);
            Controls.Add(Division);
            Controls.Add(Multiplication);
            Controls.Add(Equal);
            Controls.Add(Dot);
            Controls.Add(Zero);
            Controls.Add(Three);
            Controls.Add(Six);
            Controls.Add(Nine);
            Controls.Add(Two);
            Controls.Add(Five);
            Controls.Add(Eight);
            Controls.Add(One);
            Controls.Add(Four);
            Controls.Add(Seven);
            Controls.Add(TextBox);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox;
        private Button Seven;
        private Button Four;
        private Button One;
        private Button Two;
        private Button Five;
        private Button Eight;
        private Button Three;
        private Button Six;
        private Button Nine;
        private Button Equal;
        private Button Dot;
        private Button Zero;
        private Button Module;
        private Button Division;
        private Button Multiplication;
        private Button Negative;
        private Button Minus;
        private Button Plus;
        private Button Clear;
    }
}
