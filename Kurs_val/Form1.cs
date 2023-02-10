namespace Kurs_val
{
    public partial class Form1 : Form
    {
        private Stack<Panel> navigator = new();
    
        public Form1()
        {
            InitializeComponent();
            SetContent(new LoginForm().panel1);
        }
      
        
        public void SetContent(Panel targetPanel)
        {
            if (navigator.Count > 0)
            {
                navigator.Peek().Parent = null;
            }
            targetPanel.Parent = this;
            navigator.Push(targetPanel);
          
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetContent(new AboutForm().panel1);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GoBack()
        {
            var panel = navigator.Pop();
            panel.Dispose();
            navigator.Peek().Parent = this;
        }
    }
}