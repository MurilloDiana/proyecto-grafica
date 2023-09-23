using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace ProGrafica
{
    internal class Cuarto
    {

        public double[] centro = new double[3]; // Array para almacenar las coordenadas del centro

        public Cuarto(double[] centro)
        {
            this.centro = centro;
        }

        public Double theta = 0;
        public void thetaInc()
        {
            if (theta == 360)
            {
                theta = 0;
            }
            else
            {
                theta += 1;
            }
        }







        private void DrawCircle(double x, double y, double z, double radius, double rotationAngleDegrees, double[] centro)
        {
            GL.PushMatrix(); // Save the current modelview matrix
            GL.Translate(x + centro[0], y + centro[1], z + centro[2]); // Translate to the circle's position with centro offset
            GL.Rotate(rotationAngleDegrees, 0.0, 1.0, 0.0); // Apply the rotation to the circle

            GL.Begin(PrimitiveType.Polygon);
            int numSegments = 180;

            GL.Color4(Color.Black);

            for (int i = 0; i < numSegments; i++)
            {
                double angle = 2 * Math.PI * i / numSegments;
                double xPos = radius * Math.Cos(angle);
                double yPos = radius * Math.Sin(angle);

                GL.Vertex3(xPos, yPos, 0.0);
            }

            GL.End();

            GL.PopMatrix(); // Restore the previous modelview matrix
        }

        public void DrawCar(double[] centro)
        {
            GL.Begin(PrimitiveType.Quads); //vidrio delantero
            GL.Color3(Color.FromArgb(1, 170, 51, 51));
            GL.Vertex3(-0.4f + centro[0], 0.5f + centro[1], 1.25f + centro[2]);
            GL.Vertex3(-0.4f + centro[0], 0.75f + centro[1], 1.25f + centro[2]);
            GL.Vertex3(-0.2f + centro[0], 0.75f + centro[1], 1.25f + centro[2]);
            GL.Vertex3(-0.2f + centro[0], 0.5f + centro[1], 1.25f + centro[2]);
            GL.End();

            GL.Begin(PrimitiveType.Quads); //vidrio trasero
            GL.Color3(Color.FromArgb(1, 170, 51, 51));
            GL.Vertex3(-0.4 + centro[0], 0.75 + centro[1], 0.75 + centro[2]);
            GL.Vertex3(-0.4 + centro[0], 0.5 + centro[1], 0.75 + centro[2]);
            GL.Vertex3(-0.2 + centro[0], 0.5 + centro[1], 0.75 + centro[2]);
            GL.Vertex3(-0.2 + centro[0], 0.75 + centro[1], 0.75 + centro[2]);
            GL.End();

            GL.Begin(PrimitiveType.Quads); //techo
            GL.Color3(Color.FromArgb(1, 170, 51, 51));
            GL.Vertex3(-0.4 + centro[0], 0.75 + centro[1], 0.75 + centro[2]);
            GL.Vertex3(-0.4 + centro[0], 0.75 + centro[1], 1.25 + centro[2]);
            GL.Vertex3(-0.2 + centro[0], 0.75 + centro[1], 1.25 + centro[2]);
            GL.Vertex3(-0.2 + centro[0], 0.75 + centro[1], 0.75 + centro[2]);
            GL.End();

            GL.Begin(PrimitiveType.Quads); //cabina izq
            GL.Color3(Color.FromArgb(1, 170, 51, 51));
            GL.Vertex3(-0.4 + centro[0], 0.75 + centro[1], 1.25 + centro[2]);
            GL.Vertex3(-0.4 + centro[0], 0.5 + centro[1], 1.25 + centro[2]);
            GL.Vertex3(-0.4 + centro[0], 0.5 + centro[1], 0.50 + centro[2]);
            GL.Vertex3(-0.4 + centro[0], 0.75 + centro[1], 0.75 + centro[2]);
            GL.End();

            GL.Begin(PrimitiveType.Quads); //cabina der
            GL.Color3(Color.FromArgb(1, 170, 51, 51));
            GL.Vertex3(-0.2 + centro[0], 0.75 + centro[1], 1.25 + centro[2]);
            GL.Vertex3(-0.2 + centro[0], 0.5 + centro[1], 1.25 + centro[2]);
            GL.Vertex3(-0.2 + centro[0], 0.5 + centro[1], 0.50 + centro[2]);
            GL.Vertex3(-0.2 + centro[0], 0.75 + centro[1], 0.75 + centro[2]);
            GL.End();

            GL.Begin(PrimitiveType.Quads); //parachoque delantero
            GL.Color3(Color.FromArgb(1, 170, 51, 51));
            GL.Vertex3(-0.40 + centro[0], 0.5 + centro[1], 1.5 + centro[2]);
            GL.Vertex3(-0.40 + centro[0], 0.2 + centro[1], 1.5 + centro[2]);
            GL.Vertex3(-0.20 + centro[0], 0.2 + centro[1], 1.5 + centro[2]);
            GL.Vertex3(-0.20 + centro[0], 0.5 + centro[1], 1.5 + centro[2]);
            GL.End();

            GL.Begin(PrimitiveType.Quads); //puertas izq
            GL.Color3(Color.FromArgb(1, 170, 51, 51));
            GL.Vertex3(-0.40 + centro[0], 0.5 + centro[1], 1.5 + centro[2]);
            GL.Vertex3(-0.40 + centro[0], 0.2 + centro[1], 1.5 + centro[2]);
            GL.Vertex3(-0.40 + centro[0], 0.2 + centro[1], 0.5 + centro[2]);
            GL.Vertex3(-0.40 + centro[0], 0.5 + centro[1], 0.5 + centro[2]);
            GL.End();

            GL.Begin(PrimitiveType.Quads); //puertas back
            GL.Color3(Color.FromArgb(1, 170, 51, 51));
            GL.Vertex3(-0.40f + centro[0], 0.5f + centro[1], 0.5f + centro[2]);
            GL.Vertex3(-0.40f + centro[0], 0.2f + centro[1], 0.5f + centro[2]);
            GL.Vertex3(-0.20f + centro[0], 0.2f + centro[1], 0.5f + centro[2]);
            GL.Vertex3(-0.20f + centro[0], 0.5f + centro[1], 0.5f + centro[2]);
            GL.End();

            GL.Begin(PrimitiveType.Quads); //puertas derecha
            GL.Color3(Color.FromArgb(1, 170, 51, 51));
            GL.Vertex3(-0.20 + centro[0], 0.5 + centro[1], 1.5 + centro[2]);
            GL.Vertex3(-0.20 + centro[0], 0.2 + centro[1], 1.5 + centro[2]);
            GL.Vertex3(-0.20 + centro[0], 0.2 + centro[1], 0.5 + centro[2]);
            GL.Vertex3(-0.20 + centro[0], 0.5 + centro[1], 0.5 + centro[2]);
            GL.End();

            DrawCircle(-0.41 + centro[0], 0.25 + centro[1], 0.8 + centro[2], 0.15, 90.0, centro); //izquierda trasera
            DrawCircle(-0.19 + centro[0], 0.25 + centro[1], 0.8 + centro[2], 0.15, 90.0, centro); //derecha trasera
            DrawCircle(-0.19 + centro[0], 0.25 + centro[1], 1.2 + centro[2], 0.15, 90.0, centro); //derecha delantera
            DrawCircle(-0.41 + centro[0], 0.25 + centro[1], 1.2 + centro[2], 0.15, 90.0, centro); //rueda izquierda delantera
        }


        public static void DrawFloor(double[] centro)
        {
            //Dibujo de la pared
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(255.0f, 165.0f, 0.0f);

            GL.Vertex3(-2.0f + centro[0], -2.0f + centro[1], 0.0f + centro[2]);
            GL.Vertex3(2.0f + centro[0], -2.0f + centro[1], 0.0f + centro[2]);
            GL.Vertex3(2.0f + centro[0], 2.0f + centro[1], 0.0f + centro[2]);
            GL.Vertex3(-2.0f + centro[0], 2.0f + centro[1], 0.0f + centro[2]);

            GL.End();
           
        }



        public void DrawRepisa(double[] centro)
        {
            GL.Begin(PrimitiveType.Quads); // Dibujar la repisa
            GL.Color3(Color.FromArgb(101, 56, 24)); // Plataforma repisa

            GL.Vertex3(-1.0 + centro[0], 0.04 + centro[1], 0.01 + centro[2]);
            GL.Vertex3(-1.0 + centro[0], 0.04 + centro[1], 2.0 + centro[2]);
            GL.Vertex3(1.0 + centro[0], 0.04 + centro[1], 2.0 + centro[2]);
            GL.Vertex3(1.0 + centro[0], 0.04 + centro[1], 0.01 + centro[2]);

            GL.End();
            GL.Begin(PrimitiveType.Quads); // Repisa lado izq
            GL.Vertex3(-1.0 + centro[0], 0.04 + centro[1], 0.01 + centro[2]);
            GL.Vertex3(-1.0 + centro[0], -0.04 + centro[1], 0.01 + centro[2]);
            GL.Vertex3(-1.0 + centro[0], -0.04 + centro[1], 2.0 + centro[2]);
            GL.Vertex3(-1.0 + centro[0], 0.04 + centro[1], 2.0 + centro[2]);
            GL.End();
            GL.Begin(PrimitiveType.Quads); // Repisa lado derecho
            GL.Vertex3(1.0 + centro[0], 0.04 + centro[1], 0.01 + centro[2]);
            GL.Vertex3(1.0 + centro[0], -0.04 + centro[1], 0.01 + centro[2]);
            GL.Vertex3(1.0 + centro[0], -0.04 + centro[1], 2.0 + centro[2]);
            GL.Vertex3(1.0 + centro[0], 0.04 + centro[1], 2.0 + centro[2]);
            GL.End();
            GL.Begin(PrimitiveType.Quads); // Repisa frontal
            GL.Vertex3(-1.0 + centro[0], 0.04 + centro[1], 2.0 + centro[2]);
            GL.Vertex3(-1.0 + centro[0], -0.04 + centro[1], 2.0 + centro[2]);
            GL.Vertex3(1.0 + centro[0], -0.04 + centro[1], 2.0 + centro[2]);
            GL.Vertex3(1.0 + centro[0], 0.04 + centro[1], 2.0 + centro[2]);
            GL.End();
        }



    }
}
