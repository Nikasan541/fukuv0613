namespace fukuv0613
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx; 
            label1.Top += vy;
            // �ϐ�mpos��錾���āA�}�E�X�̃��j�^�[���W�����o��

            var mpos = MousePosition;

            var fpos = PointToClient(mpos);

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            else if(label1.Left  >ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            else if (label1.Top > ClientSize.Width)
            {
                vy = -Math.Abs(vy);
            }
            if (label1.Left < fpos.X && label1.Right > fpos.X && label1.Top < fpos.Y && label1.Bottom > fpos.Y)
            {
                timer1.Enabled = false;
                label1.Text = "nikaido yuki";
            }
        }
    }
}
