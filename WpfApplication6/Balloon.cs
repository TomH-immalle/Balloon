﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication6
{
    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;
        private Ellipse ellipse;

        public Balloon()
        {
            CreateEllipse();
            UpdateEllipse();
        }
        public void MoveRight(int xStep)
        {
            x = x + xStep;
            UpdateEllipse();            
        }
        public void ChangeSize(int change)
        {
            diameter = diameter + change;
            UpdateEllipse();
        }
        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
        }
        private void UpdateEllipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse.StrokeThickness = 2;
        }
    }
}
