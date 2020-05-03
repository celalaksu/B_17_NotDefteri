using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotDefteri
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string _dosyaAdi = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notlarim.txt");

        public MainPage()
        {
            InitializeComponent();             
            
        }

        void NotKaydet(object sender, EventArgs e)
        {
            string notum = notGirisi.Text;
            File.WriteAllText(_dosyaAdi, notum);
            notGirisi.Text = string.Empty;
        }

        void NotGoster(object sender, EventArgs e)
        {
            if (File.Exists(_dosyaAdi))
            {
                eskiNotlar.Text = File.ReadAllText(_dosyaAdi);
            }
        }

        void NotSil(object sender, EventArgs e)
        {
            if (File.Exists(_dosyaAdi))
            {
                File.Delete(_dosyaAdi);
            }
            eskiNotlar.Text = string.Empty;
        }

        
    }
}
