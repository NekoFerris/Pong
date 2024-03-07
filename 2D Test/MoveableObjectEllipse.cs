﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _2D_Test
{
    internal class MoveableObjectEllipse : MoveableObject
    {
        public MoveableObjectEllipse(bool focusable, double CanvasWidth, double CanvasHeight) : base(focusable)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = R.Next(20, 81);
            ellipse.Height = R.Next(20, 81);
            ellipse.Fill = new SolidColorBrush(Color.FromRgb((byte)R.Next(0, 255), (byte)R.Next(0, 255), (byte)R.Next(0, 255)));
            double x = R.Next(0, (int)(CanvasWidth - ellipse.Width));
            double y = R.Next(0, (int)(CanvasHeight - ellipse.Height));
            ellipse.StrokeThickness = 1;
            Canvas.SetLeft(ellipse, x);
            Canvas.SetTop(ellipse, y);
            UIElement = ellipse;
        }
    }
}