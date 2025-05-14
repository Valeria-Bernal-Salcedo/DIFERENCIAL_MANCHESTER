using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIFERENCIAL_MANCHESTER
{
    public partial class Form1 : Form
    {
        string bits;

        public Form1()
        {
            InitializeComponent();
        }

        private void GRAFICAR_Click(object sender, EventArgs e)
        {

            bits = signal.Text;

            if (!bits.All(c => c == '0' || c == '1'))
            {
                MessageBox.Show("Solo se permiten 0 y 1");
                return;
            }

            difManchester.Paint += Dibujar;
            difManchester.Refresh();

        }

        private void Dibujar(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.Blue, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xInicio = 50; // Donde empieza el dibujo en X
            int yCero = 150; // Coordenada vertical para el nivel 0
            int yUno = 50; // Coordenada vertical para el nivel 1
            int ancho = 50; // Ancho que ocupa 1 bit
            int mitad = ancho / 2;

            // Etiquetas '0' y '1' en el eje Y
            g.DrawString("1", font, Brushes.Black, 20, yUno - 10);
            g.DrawString("0", font, Brushes.Black, 20, yCero - 10);

            // Dibujar líneas verticales de la cuadrícula (1 por cada bit)
            for (int i = 0; i <= bits.Length; i++)
            {
                int x1 = xInicio + i * ancho;
                g.DrawLine(gridPen, x1, yUno, x1, yCero);
            }

            // Dibujar líneas horizontales (nivel 1 y 0)
            g.DrawLine(gridPen, xInicio, yUno, xInicio + bits.Length * ancho, yUno);
            g.DrawLine(gridPen, xInicio, yCero, xInicio + bits.Length * ancho, yCero);

            // Dibujar los bits
            int yActual = bits[0]=='1' ? yUno : yCero; // Nivel inicial
            int x = xInicio;

            for (int i = 0; i < bits.Length; i++)
            {
                char bit = bits[i];

                // Dibujar el numero del bit
                g.DrawString(bits[i].ToString(), font, Brushes.Black, x + 15, yCero + 10);

                bool transicionInicio = (bit == '0');

                /// Parte izquierda (inicio del bit)
                if (transicionInicio)
                {
                    int nuevaY = (yActual == yUno) ? yCero : yUno;
                    g.DrawLine(pen, x, yActual, x, nuevaY); // transición al inicio
                    yActual = nuevaY;
                }

                // Línea horizontal mitad izquierda
                g.DrawLine(pen, x, yActual, x + mitad, yActual);

                int midY = (yActual == yUno) ? yCero : yUno;
                g.DrawLine(pen, x + mitad, yActual, x + mitad, midY);
                yActual = midY;

                // Dibujar línea mitad derecha
                g.DrawLine(pen, x + mitad, yActual, x + ancho, yActual);

                // Preparar siguiente bit
                x += ancho;
            }

            // Dibujar flecha final
            g.DrawLine(pen, x, yActual, x + 10, yActual);
            g.DrawLine(pen, x + 5, yActual - 5, x + 10, yActual);
            g.DrawLine(pen, x + 5, yActual + 5, x + 10, yActual);
        }
    }
}
