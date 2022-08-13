namespace macOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string case1 = inputBox.Text;
            outputBox.Text = new string((from c in case1 where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c) select c).ToArray());

            var list = Enumerable.Range(0, case1.Length / 2).Select(i => case1.Substring(i * 2, 2));
            var case2 = string.Join(":", list);

            outputBox.Text = case2;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string case1 = inputBox.Text;
            outputBox.Text = new string((from c in case1 where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c) select c).ToArray());
        }

        private void btn_reverse_Click(object sender, EventArgs e)
        {

        }
    }
}