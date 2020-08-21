using System.Media;
using System.Threading.Tasks;
using System.Windows;

namespace RetroEncabulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PlaySoundThenQuit();
        }
        public async void PlaySoundThenQuit()
        {
            await Task.Run(() => {
                SoundPlayer sp = new SoundPlayer()
                {
                    Stream = Properties.Resources.sound
                };
                sp.PlaySync();
            });
            Close();
        }
    }
}
