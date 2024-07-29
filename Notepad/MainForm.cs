using Notepad.Controls;
using Notepad.Objects;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Notepad
{
    public partial class MainForm : Form
    {
        public RichTextBox CurrentRtb;
        public TextFile CurrentFile;
        public TabControl MainTabControl;
        public Session Session;
        public MainForm()
        {
            InitializeComponent();

            Session = new Session();

            var menuStrip = new MainMenuStrip();
            MainTabControl = new MainTabControl();



            Controls.AddRange(new Control[] { MainTabControl, menuStrip });

            InitializeFile();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void InitializeFile()
        {
            if (Session.TextFiles.Count == 0)
            {
                var file = new TextFile("Sans titre 1");

                MainTabControl.TabPages.Add(file.SafeFileName);

                var tabPage = MainTabControl.TabPages[0];
                var rtb = new CustomRichTextBox();
                tabPage.Controls.Add(rtb);
                rtb.Select();

                Session.TextFiles.Add(file);

                CurrentFile = file;
                CurrentRtb = rtb;
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Session.Save();

            foreach (var file in Session.TextFiles)
            {
                var fileIndex = Session.TextFiles.IndexOf(file);
                var rtb = MainTabControl.TabPages[fileIndex].Controls.Find("RtbTextFileContents", true).First();
                //MessageBox.Show(rtb.Text);
                
                if (file.FileName.StartsWith("Sans titre"))
                {
                    file.Contents = rtb.Text;
                    Session.BackupFile(file);
                }
            }
        }
    }
}
