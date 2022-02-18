using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;


namespace MyBut
{
    public class MyButton : Control
    {
        [Description("Будет ли обводка")] 
        public bool Border { get; set; } = false;

        [Description("Цвет обводки")]
        public Color BorderColor { get; set; } = Color.Tomato;

        [Description("Размер обводки")]
        public int BorderWidth { get; set; } = 1;


        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }
        private StringFormat SF = new StringFormat();
        public MyButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(100, 30);

            Font = new Font("Verdana", 8.25F, FontStyle.Regular);

       

            BackColor = Color.Tomato;
           
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;


        }

        protected void CreateBorder()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 2);
            Rectangle rectText = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);

            if (Border)
            {
                Pen Pen = new Pen(BorderColor, BorderWidth);
                graph.DrawRectangle(Pen,rect.X, rect.Y, rect.Width, rect.Height);
            }

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectText, SF);
        }


    }
}
