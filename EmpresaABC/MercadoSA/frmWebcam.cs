using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace MercadoSA
{
    public partial class frmWebcam : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;

        public frmWebcam()
        {
            InitializeComponent();
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pctCapturarImagem.Image = img;
        }

        private void frmWebcam_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cbbDispositivos.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cbbDispositivos.Items.Add(device.Name);
                }
                cbbDispositivos.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cbbDispositivos.Items.Add("Nenhum dispositivo encontrado!");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text == "Capturar")
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cbbDispositivos.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                    btnCapturar.Text = "Gravar";
                }
                else
                {
                    MessageBox.Show("Nenhum dispositivo encontrado!");
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;

                            //Salvar imagem
                            sfdSalvarImagem.Filter = "JPEG(*.jpg;*.jpeg;*.jpeg;*.jfif)|*.jpg;*.jpeg;*.jpeg;*.jfif";
                            DialogResult res = sfdSalvarImagem.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                pctCapturarImagem.Image.Save(sfdSalvarImagem.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                            
                        }
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarIMG = new OpenFileDialog();
            buscarIMG.InitialDirectory = ("c:\\imagens\\");
            buscarIMG.FileName = "Imagem";
            buscarIMG.Title = "Procurar Imagem";
            buscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            buscarIMG.ShowDialog();
            pctCapturarImagem.ImageLocation = (buscarIMG.FileName);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pctCapturarImagem.Image = null;
        }
    }
}
