﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeWithVisistorPattern
{
    public class Trapezium: Figure//Часть 3
    {
        private double firstSide;
        private double secondSide;
        private double smallBaseSide;
        private double longBaseSide;
        private double height;

        public double FirstSide
        {
            get => firstSide;

            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    firstSide = value;
            }
        }
        public double SecondSide
        {
            get => secondSide;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    secondSide = value;
            }
        }
        public double SmallBaseSide
        {
            get => smallBaseSide;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    smallBaseSide = value;
            }
        }
        public double LongBaseSide
        {
            get => longBaseSide;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    longBaseSide = value;
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    height = value;
            }
        }

        //Trapezium area
        public double TrapeziumArea { get => ((smallBaseSide + longBaseSide) / 2) * height; }

        //Trapezium perimeter
        public double TrapeziumPerimeter { get => firstSide + secondSide + smallBaseSide + longBaseSide; }

        public Trapezium(double firstside, double secondside, double smallbaseside, double longbaseside, double height)
        {
            FirstSide = firstside;
            SecondSide = secondside;
            SmallBaseSide = smallbaseside;
            LongBaseSide = longbaseside;
            Height = height;
        }

        public override double Visit(IVisitor visitor)
        {
            return visitor.Accept(this);
        }

        //Print the area and perimeter of the Trapezium
        public override void PrintFigureAreaAndPerimeter()
        {
            Console.WriteLine($"The Trapezium's Area is {TrapeziumArea} and Perimeter is {TrapeziumPerimeter}!!!");
        }
    }
}
