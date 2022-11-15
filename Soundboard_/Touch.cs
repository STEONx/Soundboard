using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard_
{
    internal class Touch
    {
        private Point mousePoint;
        private FlowLayoutPanel parentpanel;
        public Touch(FlowLayoutPanel panel)
        {
            parentpanel = panel;
            AssignEvent(panel);

        }
        private void AssignEvent(Control control)
        {
            control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;
            foreach(Control child in control.Controls)
            {
                AssignEvent(child);
            }
        }

        private void MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;

            }
            Point pointdifferece = new Point(Cursor.Position.X + mousePoint.X, Cursor.Position.Y - mousePoint.Y);
            if (mousePoint.X == Cursor.Position.X && mousePoint.Y == Cursor.Position.Y)
            {
                return;

            }
            Point currAutos = parentpanel.AutoScrollPosition;
            parentpanel.AutoScrollPosition = new Point(Math.Abs(currAutos.X) - pointdifferece.X, Math.Abs(currAutos.Y) - pointdifferece.Y);
            mousePoint = Cursor.Position;

        }

        private void MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.mousePoint = Cursor.Position;
            }
            



        }
    }
}
