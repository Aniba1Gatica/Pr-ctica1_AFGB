using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Práctica1_AFGB
{
    public partial class Form1 : Form
    {
        Mat m = new Mat();
        VideoCapture captura = null;
        IBackgroundSubtractor backgroundSubtractor;
        int minArea = 7000;//El área minima a tomar en consideración para hacer el rectángulo al rededor del objeto o figura
        string fechas;
        string hora;
        int contador = 1;
        bool Pausa = false;
        int X = 0;//Coordenada X
        int Y = 0;//Coordenada Y
        int dif = 0; //Variable que almacena la diferencia de posiciones en X


        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Camera_Click(object sender, EventArgs e)//Acción del botón Iniciar cámara
        {
            if (captura == null)
            {
                captura = new Emgu.CV.VideoCapture(0);//Crea la instancia captura en caso que sea null

            }
            Start_Camera.Text = "Iniciar Cámara";
            Start_Camera.BackColor = Color.Lime;
            captura.ImageGrabbed += Captura_ImageGrabbed;//Logra tomar la imagen a través de la función que esta más abajo
            captura.Start();
            temporizador.Start();
            capturaImagen();
        }

        private void Captura_ImageGrabbed(object sender, EventArgs e)
        {
            if (captura != null)
            {
                try
                {
                    captura.Retrieve(m);//Toma la captura
                    pictureBox1.Image = m.ToBitmap();//La muestra en la caja de imagen "Video en vivo"
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guardar_Click(object sender, EventArgs e)//Acción del botón Guardar
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName + " .txt", richTextBox1.Lines);//Crea un archivo .txt con los datos de la caja de texto
            }
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("HH:mm:ss");
            fechas = DateTime.Now.ToString("dddd/MMM/yyyy");

            dif = X - dif;//Cálculo para ver la diferencia de posiciones en X
            if (dif < 0)
            {
                dif *= (-1);//Cálculo para convertir la diferencia en un valor positivo en caso que sea negativo
            }

            if (fechas.Length > 0 && hora.Length > 0)
            {
                richTextBox1.Text += ("Captura #") + contador + "\n";
                richTextBox1.Text += ("Fecha: ") + fechas + "\n";
                richTextBox1.Text += ("Hora: ") + hora + "\n";
                richTextBox1.Text += ("Posición X: ") + X + "\n";
                richTextBox1.Text += ("Posición Y: ") + Y + "\n";
                richTextBox1.Text += ("Diferencia de posiciones en X: ") + dif + "\n";
                richTextBox1.Text += ("-------------------------------------------------------- \n");
                contador++;
            }
        }

        //Funciones

        public void capturaImagen()//Función para capturar y procesar las imágenes de la cámara
        {
            backgroundSubtractor = new BackgroundSubtractorMOG2();
            //backgroundSubtractor = new Emgu.CV.BgSegm.BackgroundSubtractorCNT();
            Application.Idle += Application_Idle;

        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if (captura != null)
            {
                
                Pausa = !Pausa;
                if (!Pausa)
                {
                    try
                    {
                        Image<Gray, byte> imgOutput = m.ToImage<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255));
                        Mat frame = captura.QueryFrame();
                        if (frame.IsEmpty)
                        {
                            Application.Idle -= Application_Idle;
                            return;
                        }



                        Mat framessuaves = new Mat();
                        CvInvoke.GaussianBlur(imgOutput, framessuaves, new Size(3, 3), 1);//Suaviza los frames

                        Mat fondoExtraccion = new Mat();
                        backgroundSubtractor.Apply(framessuaves, fondoExtraccion);//Se aplica la extracción del fondo de la imagen

                        //Proceso para limpiar el fondo de frames residuales
                        CvInvoke.Threshold(framessuaves, framessuaves, 200, 240, ThresholdType.Binary);
                        CvInvoke.MorphologyEx(framessuaves, framessuaves,
                            MorphOp.Close, Mat.Ones(7, 3, DepthType.Cv8U, 1), new Point(-1, -1), 1, BorderType.Reflect, new Emgu.CV.Structure.MCvScalar(0));

                        //Detecta los contornos de los objetos o figuras en la imagen
                        VectorOfVectorOfPoint contornos = new VectorOfVectorOfPoint();
                        CvInvoke.FindContourTree(framessuaves, contornos, ChainApproxMethod.ChainApproxSimple, new Point(-1, -1));

                        for (int i = 0; i < contornos.Size; i++)
                        {
                            var bbox = CvInvoke.BoundingRectangle(contornos[i]);
                            var area = bbox.Width * bbox.Height;
                            var ar = (float)bbox.Height / bbox.Width;

                            if (area > minArea && ar < 1.0)
                            {
                                CvInvoke.Rectangle(frame, bbox, new Emgu.CV.Structure.MCvScalar(0, 0, 255), 2);
                                X = bbox.Width;
                                Y = bbox.Height;
                            }
                        }


                        pictureBox2.Image = frame.ToBitmap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    Pausa = !Pausa;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            captura = null;
            temporizador.Stop();
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            temporizador.Stop();
            temporizador.Start();
        }
    }
}
