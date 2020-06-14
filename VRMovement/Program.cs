using System;
using System.Reflection;
using System.Security.Permissions;
using System.Windows;

namespace VRMovement
{
    internal class Program
    {
        public struct Point
        {
            public double x;
            public double y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        private static double toPolar(double x, double y)
        {
            double radians = Math.Atan2(y, x);
            double angle = radians * 180 / Math.PI;
            return angle;
        }

        private static Point toRect(double angle)
        {
            Point p = new Point(Math.Cos(angle), Math.Sin(angle));
            return p;
        }

        private static double newAngle(double controllerAngle, double cameraAngle)
        {
            double offset = 90 - controllerAngle;
            return cameraAngle - offset;
        }

        public static void Main(string[] args)
        {
        }
    }
}