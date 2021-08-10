using System;


namespace ClassLibrary
{
    public class Circle
    {
        
            /// <summary>
            /// X Koordinate
            /// </summary>
            public double XCoordinate { get; set; }

            /// <summary>
            /// Y-Koordinate
            /// </summary>
            public double YCoordiante { get; set; }

            /// <summary>
            /// Radius
            /// </summary>
            private int _radius;

            /// <summary>
            /// Radius
            /// </summary>
            public int Radius
            {
                get { return _radius; }
                set
                {
                    if (value >= 0)
                        _radius = value;
                    else
                        throw new Exception($"Radius ist falsch. {value}");
                }
            }

            /// <summary>
            /// Ctor
            /// </summary>
            public Circle()
            {
                Radius = 0;
                XCoordinate = 0;
                YCoordiante = 0;
            }

            /// <summary>
            /// Ctor
            /// </summary>
            /// <param name="radius">Kreisradius</param>
            public Circle(int radius)
                : this()
            {
                Radius = radius;
            }

            /// <summary>
            /// Ctor
            /// </summary>
            /// <param name="radius">Radius</param>
            /// <param name="xCoordinate">X-Koordinate</param>
            /// <param name="yCoordinate">Y-Koordinate</param>
            public Circle(int radius, double xCoordinate, double yCoordinate)
                : this(radius)
            {
                XCoordinate = xCoordinate;
                YCoordiante = yCoordinate;
            }

            /// <summary>
            /// Kreisfläche berechnen
            /// </summary>
            /// <returns>Kreisfläche</returns>
            public double GetArea()
            {
                return Math.Pow(Radius, 2) * Math.PI;
            }

            /// <summary>
            /// Kreisumfang berechnen
            /// </summary>
            /// <returns>Kreisumfang</returns>
            public double GetCircumference()
            {
                return 2 * Radius * Math.PI;
            }

            /// <summary>
            /// Positionierung
            /// </summary>
            /// <param name="dx">Delta X</param>
            /// <param name="dy">Delta Y</param>
            public void Move(double dx, double dy)
            {
                XCoordinate += dx;
                YCoordiante += dy;
            }

            /// <summary>
            /// Positionierung
            /// </summary>
            /// <param name="dx">Delta X</param>
            /// <param name="dy">Delta Y</param>
            /// <param name="dRadius">Delta Radius</param>
            public void Move(double dx, double dy, int dRadius)
            {
                Move(dx, dy);
                Radius += dRadius;
            }
        }
   } 
