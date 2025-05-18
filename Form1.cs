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
            Pen pen = new Pen(Color.Purple, 2); // 'Lapiz' azul para la señal
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
            int yActual = yUno; // Nivel inicial
            int x = xInicio;

            bool nivelAlto = true;

            for (int i = 0; i < bits.Length; i++)
            {
                char bit = bits[i];

                // Solo para el primer bit, forzamos transición al inicio para empezar
                if (i == 0)
                {
                    // Dibujar línea vertical inicial desde el opuesto
                    g.DrawLine(pen, x, (nivelAlto ? yCero : yUno), x, (nivelAlto ? yUno : yCero));
                    yActual = nivelAlto ? yUno : yCero;
                }

                // Determinar si hay transición al inicio según el bit
                if (bit == '0')
                {
                    // Cambiar nivel lógico
                    nivelAlto = !nivelAlto;
                    int nuevaY = nivelAlto ? yUno : yCero;

                    // Dibujar transición vertical al inicio del bit
                    g.DrawLine(pen, x, yActual, x, nuevaY);
                    yActual = nuevaY;
                }
                else
                {
                    // Si no hay transición, mantenemos yActual
                    yActual = nivelAlto ? yUno : yCero;
                }

                // Línea horizontal mitad izquierda
                g.DrawLine(pen, x, yActual, x + mitad, yActual);

                // Transición a mitad del bit (siempre ocurre)
                nivelAlto = !nivelAlto;
                int midY = nivelAlto ? yUno : yCero;
                g.DrawLine(pen, x + mitad, yActual, x + mitad, midY);

                // Línea horizontal mitad derecha
                g.DrawLine(pen, x + mitad, midY, x + ancho, midY);

                // Dibuja el número del bit
                g.DrawString(bits[i].ToString(), font, Brushes.Black, x + 15, yCero + 10);

                // Prepara para siguiente iteración
                x += ancho;
                yActual = midY;
            }

            // Dibujar flecha final
            g.DrawLine(pen, x, yActual, x + 10, yActual);
            g.DrawLine(pen, x + 5, yActual - 5, x + 10, yActual);
            g.DrawLine(pen, x + 5, yActual + 5, x + 10, yActual);
        }
    }
}
