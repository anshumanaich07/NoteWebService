using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Client
{
    public partial class NoteLogin : MaterialForm
    {
        public NoteLogin()
        {
            InitializeComponent();

            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(
                Primary.Yellow500, Primary.Yellow400,
                Primary.Yellow500, Accent.Orange100,
                TextShade.BLACK
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void login_Click(object sender, EventArgs e)
        {
            var noteform = new NoteForm(username.Text);
            this.Hide();
            noteform.ShowDialog();
        }
    }
}
