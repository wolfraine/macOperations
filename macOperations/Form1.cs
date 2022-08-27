namespace macOperations
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        
        public Form1()
        {
            InitializeComponent();
            t.Interval = 2000;
            t.Tick += T_Tick;
        }
        private void T_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer _t = sender as System.Windows.Forms.Timer;
            statusLabel1.Text = "";
            _t.Stop();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string case1 = inputBox.Text;
            case1 = case1.Replace(" ", "");
            var list = Enumerable.Range(0, case1.Length / 2).Select(i => case1.Substring(i * 2, 2));
            var case2 = string.Join(":", list);
            outputBox.Text = case2;
            statusLabel1.Text = "Done";
            t.Start();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string case1 = inputBox.Text;
            case1 = case1.Replace(" ", "");
            case1 = case1.Replace(":", "");
            outputBox.Text = case1;
            statusLabel1.Text = "Done";
            t.Start();
        }

        private void btn_reverse_Click(object sender, EventArgs e)
        {
            string case1 = inputBox.Text;
            case1 = case1.Replace(" ", "");
            case1 = case1.Replace(":", "");
            char[] charArray = case1.ToCharArray();
            Array.Reverse(charArray);
            outputBox.Text =  new string(charArray);
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "About Program";
            string message = "Program to do simple operations\nwith MAC address";
            MessageBox.Show(message, title);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            inputBox.Clear();
            outputBox.Clear();
        }
    }
}