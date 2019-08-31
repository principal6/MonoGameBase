using System;
using System.Windows.Forms;
using System.IO;

namespace DirectX11TutorialLevelEditor
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
                Dock = DockStyle.Fill
            };
        }

        public MGSurface Surface { get; }
    }
}
