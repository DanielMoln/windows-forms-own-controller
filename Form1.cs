namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int lastTopX = 12;
        int lastTopY = 40;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Klik");
        }

        private void gomb1_Click(object sender, EventArgs e)
        {
            Button btn2 = new Button();

            btn2.Text = "Gomb";
            btn2.Location = new Point(new Random().Next(this.Width - 200), new Random().Next(this.Height - 60));
            btn2.Size = new Size(50, 30);

            this.Controls.Add(btn2);
        }

        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            MyListControl ctrl = new MyListControl(new MyData()
            {
                Title = "Pál utcai fiúk",
                SubTitle = "Valamilyen szöveg"
            });

            ctrl.Location = new Point(lastTopX, lastTopY);
            lastTopY += ctrl.Height + 10;

            this.Controls.Add(ctrl);
        }
    }
}