using System;
using System.Windows.Forms;
using System.IO;

using Microsoft.Xna.Framework;

namespace MonoGameBase
{
    public partial class MainFrm : Form
    {
        private readonly string KAssetDir;

        public MainFrm()
        {
            InitializeComponent();

            KAssetDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/asset/";

            Surface = new MGSurface(KAssetDir)
            {
                Parent = this,
                BackgroundColor = new Color(0.4f, 0.8f, 1.0f, 1.0f),
                Dock = DockStyle.Fill
            };

            
        }

        public MGSurface Surface { get; }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Surface.AddTextureFromFile("grass_64x64.png");
        }
    }
}
