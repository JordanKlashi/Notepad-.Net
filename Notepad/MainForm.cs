using Notepad.Controls;
using Notepad.Objects;
using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class MainForm : Form
    {
        public RichTextBox CurrentRtb { get; private set; }
        public TextFile CurrentFile { get; private set; }
        public TabControl MainTabControl { get; private set; }
        public Session Session { get; private set; }
        public MainForm()
        {
            InitializeComponent();

            var menuStrip = new MainMenuStrip();

            MainTabControl = new MainTabControl();
            Session = new Session();

            Controls.AddRange(new Control[] { MainTabControl, menuStrip });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
