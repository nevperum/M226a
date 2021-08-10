using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    /// <summary>
    /// Kreisklasse
    /// </summary>
    /// <remarks>
    /// Übung aus dem Buch
    /// </remarks>
    public class Circle
    {

        /// <summary>
        /// X-Koordinate
        /// </summary>


        private double _xCoordinate;
        /// <summary>
        /// X-Koordinate
        /// </summary>
        public double XCoordinate
        {
            get { return _xCoordinate; }
            set { _xCoordinate = value; }
        }
        /// <summary>
        /// Y-Koordinate
        /// </summary>
        private double _yCoordinate;
        /// <summary>
        /// Y-Koordinate
        /// </summary>
        public double YCoordinate
        {
            get { return _yCoordinate; }
            set { _yCoordinate = value; }
        }
        /// <summary>
        /// Radius
        /// </summary>
        private int _radius;
        /// <summary>
        ///  Radius
        /// </summary>
        public int Radius
        {
            get { return _radius; }
            set { 
                if (value >= 0) 
                { _radius = value; } 
                else
                {
                    throw new Exception ()
                }

            }
        }
        /// <summary>
        /// Konstruktor (Ctor)
        /// </summary>
        public Circle()
        {
            Radius = 0;
            XCoordinate = 0;
            YCoordinate = 0;

        }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="radius"></param>
        public Circle(int radius)
            : this()
        {
            Radius = radius;
        }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Circle(int radius, double x, double y)
            : this(radius)
        {
            Radius = radius;

            XCoordinate = x;

            YCoordinate = y;

        }
        /// <summary>
        /// Berechnet die Fläche des Kreises
        /// </summary>
        /// <returns>Gibt mir Kreisflache zurück</returns>
        public double GetArea()
        {
            return _radius * _radius * Math.PI;

        }
        /// <summary>
        /// berechnet den Umfang des Kreises
        /// </summary>
        /// <returns>Gibt mir den Kreisumpfang zurcück</returns>
        public double GetCircumference()
        {
            return Math.PI * _radius * 2;

        }
        /// <summary>
        /// Positionierung
        /// </summary>
        /// <param name="dx">Delta X</param>
        /// <param name="dy">Delta Y</param>
        public void Move(double dx, double dy)
        {
         XCoordinate =  dx + XCoordinate;
         YCoordinate =  dy + YCoordinate;

            
        }
        /// <summary>
        /// Positzonierung und Veränderung des Radius
        /// </summary>
        /// <param name="dx">Delta X</param>
        /// <param name="dy">Delta Y</param>
        /// <param name="dRadius">Delta Radius</param>
        public void Move(int dRadius , double dx, double dy)
        {
            Move(dx, dy);

            Radius += dRadius;


        }


    } 
}    
