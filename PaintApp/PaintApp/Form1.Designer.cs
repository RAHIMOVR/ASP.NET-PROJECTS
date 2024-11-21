namespace PaintApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttons = new Panel();
            color_box = new PictureBox();
            pic_color = new Button();
            rectangle_btn = new Button();
            circle_btn = new Button();
            line_btn = new Button();
            fill_btn = new Button();
            color_btn = new Button();
            erase_btn = new Button();
            draw_btn = new Button();
            Clear_btn = new Button();
            Save_btn = new Button();
            pic = new PictureBox();
            buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // buttons
            // 
            buttons.BackColor = Color.Black;
            buttons.BackgroundImageLayout = ImageLayout.None;
            buttons.Controls.Add(color_box);
            buttons.Controls.Add(pic_color);
            buttons.Controls.Add(rectangle_btn);
            buttons.Controls.Add(circle_btn);
            buttons.Controls.Add(line_btn);
            buttons.Controls.Add(fill_btn);
            buttons.Controls.Add(color_btn);
            buttons.Controls.Add(erase_btn);
            buttons.Controls.Add(draw_btn);
            buttons.Controls.Add(Clear_btn);
            buttons.Controls.Add(Save_btn);
            buttons.Dock = DockStyle.Top;
            buttons.Location = new Point(0, 0);
            buttons.Name = "buttons";
            buttons.Size = new Size(1077, 94);
            buttons.TabIndex = 0;
            buttons.Paint += panel1_Paint;
            // 
            // color_box
            // 
            color_box.Image = (Image)resources.GetObject("color_box.Image");
            color_box.Location = new Point(358, 6);
            color_box.Name = "color_box";
            color_box.Size = new Size(270, 85);
            color_box.SizeMode = PictureBoxSizeMode.StretchImage;
            color_box.TabIndex = 11;
            color_box.TabStop = false;
            color_box.Click += color_box_Click;
            color_box.MouseClick += color_box_MouseClick;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(277, 29);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(32, 32);
            pic_color.TabIndex = 10;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // rectangle_btn
            // 
            rectangle_btn.BackColor = Color.White;
            rectangle_btn.FlatAppearance.BorderColor = Color.Black;
            rectangle_btn.FlatAppearance.BorderSize = 0;
            rectangle_btn.ForeColor = SystemColors.ButtonHighlight;
            rectangle_btn.Image = (Image)resources.GetObject("rectangle_btn.Image");
            rectangle_btn.Location = new Point(904, 6);
            rectangle_btn.Name = "rectangle_btn";
            rectangle_btn.Size = new Size(84, 79);
            rectangle_btn.TabIndex = 8;
            rectangle_btn.UseVisualStyleBackColor = false;
            rectangle_btn.Click += rectangle_btn_Click;
            // 
            // circle_btn
            // 
            circle_btn.BackColor = Color.White;
            circle_btn.FlatAppearance.BorderColor = Color.Black;
            circle_btn.FlatAppearance.BorderSize = 0;
            circle_btn.ForeColor = SystemColors.ButtonHighlight;
            circle_btn.Image = (Image)resources.GetObject("circle_btn.Image");
            circle_btn.Location = new Point(814, 6);
            circle_btn.Name = "circle_btn";
            circle_btn.Size = new Size(84, 79);
            circle_btn.TabIndex = 7;
            circle_btn.UseVisualStyleBackColor = false;
            circle_btn.Click += circle_btn_Click;
            // 
            // line_btn
            // 
            line_btn.BackColor = Color.White;
            line_btn.FlatAppearance.BorderColor = Color.Black;
            line_btn.FlatAppearance.BorderSize = 0;
            line_btn.ForeColor = SystemColors.ButtonHighlight;
            line_btn.Image = (Image)resources.GetObject("line_btn.Image");
            line_btn.Location = new Point(724, 6);
            line_btn.Name = "line_btn";
            line_btn.Size = new Size(84, 79);
            line_btn.TabIndex = 6;
            line_btn.UseVisualStyleBackColor = false;
            line_btn.Click += line_btn_Click;
            // 
            // fill_btn
            // 
            fill_btn.BackColor = Color.White;
            fill_btn.FlatAppearance.BorderColor = Color.Black;
            fill_btn.FlatAppearance.BorderSize = 0;
            fill_btn.ForeColor = SystemColors.ButtonHighlight;
            fill_btn.Image = (Image)resources.GetObject("fill_btn.Image");
            fill_btn.Location = new Point(634, 6);
            fill_btn.Name = "fill_btn";
            fill_btn.Size = new Size(84, 79);
            fill_btn.TabIndex = 5;
            fill_btn.UseVisualStyleBackColor = false;
            fill_btn.Click += fill_btn_Click;
            // 
            // color_btn
            // 
            color_btn.BackColor = Color.White;
            color_btn.FlatAppearance.BorderColor = Color.Black;
            color_btn.FlatAppearance.BorderSize = 0;
            color_btn.ForeColor = SystemColors.ButtonHighlight;
            color_btn.Image = (Image)resources.GetObject("color_btn.Image");
            color_btn.Location = new Point(187, 6);
            color_btn.Name = "color_btn";
            color_btn.Size = new Size(84, 79);
            color_btn.TabIndex = 4;
            color_btn.UseVisualStyleBackColor = false;
            color_btn.Click += color_btn_Click;
            // 
            // erase_btn
            // 
            erase_btn.BackColor = Color.White;
            erase_btn.FlatAppearance.BorderColor = Color.Black;
            erase_btn.FlatAppearance.BorderSize = 0;
            erase_btn.ForeColor = SystemColors.ButtonHighlight;
            erase_btn.Image = (Image)resources.GetObject("erase_btn.Image");
            erase_btn.Location = new Point(97, 6);
            erase_btn.Name = "erase_btn";
            erase_btn.Size = new Size(84, 79);
            erase_btn.TabIndex = 2;
            erase_btn.UseVisualStyleBackColor = false;
            erase_btn.Click += erase_btn_Click;
            // 
            // draw_btn
            // 
            draw_btn.BackColor = Color.White;
            draw_btn.FlatAppearance.BorderColor = Color.Black;
            draw_btn.FlatAppearance.BorderSize = 0;
            draw_btn.ForeColor = SystemColors.ButtonHighlight;
            draw_btn.Image = (Image)resources.GetObject("draw_btn.Image");
            draw_btn.Location = new Point(7, 6);
            draw_btn.Name = "draw_btn";
            draw_btn.Size = new Size(84, 79);
            draw_btn.TabIndex = 0;
            draw_btn.UseVisualStyleBackColor = false;
            draw_btn.Click += draw_btn_Click;
            // 
            // Clear_btn
            // 
            Clear_btn.BackColor = Color.FromArgb(192, 0, 0);
            Clear_btn.Location = new Point(997, 48);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(64, 43);
            Clear_btn.TabIndex = 1;
            Clear_btn.Text = "Clear";
            Clear_btn.UseVisualStyleBackColor = false;
            Clear_btn.Click += Clear_btn_Click;
            // 
            // Save_btn
            // 
            Save_btn.BackColor = Color.FromArgb(0, 192, 192);
            Save_btn.Location = new Point(997, 3);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(64, 43);
            Save_btn.TabIndex = 0;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = false;
            Save_btn.Click += button1_Click;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1077, 741);
            pic.TabIndex = 1;
            pic.TabStop = false;
            pic.Click += pic_Click;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 741);
            Controls.Add(buttons);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(1094, 705);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel buttons;
        private Button Save_btn;
        private Button Clear_btn;
        private Button draw_btn;
        private Button erase_btn;
        private PictureBox pic;
        private Button color_btn;
        private Button rectangle_btn;
        private Button circle_btn;
        private Button line_btn;
        private Button fill_btn;
        private Button pic_color;
        private PictureBox color_box;
    }
}
