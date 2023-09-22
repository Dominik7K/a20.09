namespace a20._09
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void sprawdzMail(object sender, EventArgs e)
        {
            string mail = mailLbl.Text;
            int x = mail.IndexOf('@');
            
            if (x>0 && x<mail.Length-1 && mail.Length>0)
            {
                komunikatLbl.Text = "Git";
            }
            else {
                komunikatLbl.Text = "Żle";
            }
            
            SemanticScreenReader.Announce(komunikatLbl.Text);
        }
    }
}