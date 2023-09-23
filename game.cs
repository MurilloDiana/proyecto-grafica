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
    class game:GameWindow
    {
        private Double theta = 0;
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
       
        public game(int widht, int height, string title):base(widht, height, GraphicsMode.Default, title)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            //Code goes here
            GL.Enable(EnableCap.DepthTest);
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); //wea de la doc

            GL.Rotate(10.0, 1.0, 0.0, 0.0); //rotar 10 grados en x
            GL.Rotate(theta, 0.0, 1.0, 0.0); //rotar theta grados en y
            Axis axis = new Axis();

            // Llamar a la clase Cuarto y sus métodos de dibujo con el centro deseado
            double[] centro = new double[] { 0.0, 0.0, 0.0 }; // Coordenadas del centro que deseas
            Cuarto cuarto = new Cuarto(centro);
            
       
            cuarto.DrawCar(centro);
          //  cuarto.DrawFloor(centro);
            cuarto.DrawRepisa(centro);


            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            Double escala = 5.0;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-escala, escala, -escala, escala, -escala, escala);//set escala
            GL.MatrixMode(MatrixMode.Modelview);


            base.OnResize(e);
        }
    }
}
