using QuanLyThiHocKi.Models.EntitiesNew;

namespace QuanLyThiHocKi
{
    public partial class FormXemSX : Form
    {
        private int _id;
        public FormXemSX(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormXemSX_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var lich = context.LichThis.Find(_id);
            int rowcount = lich.Sldk.Value / 6;
            rowcount++;
            if ((lich.Sldk.Value % 6) > 0)
            {
                rowcount++;
            }
            float heightBtn = (float)100 / rowcount;
            // Thiết lập TableLayoutPanel
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.RowCount = rowcount;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < 6; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            }

            for (int i = 0; i < rowcount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, heightBtn));
            }

            // Thêm header "Bảng"
            Label headerLabel = new Label();
            headerLabel.Text = "Bảng";
            headerLabel.BackColor = Color.LightGray;
            headerLabel.BorderStyle = BorderStyle.FixedSingle;
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            headerLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            tableLayoutPanel1.Controls.Add(headerLabel, 0, 0);
            tableLayoutPanel1.SetColumnSpan(headerLabel, 6);
            // if (number > 56) break;
            int lc = lich.Idsx.Value;
            int number = 1;
            switch (lc)
            {
                case 1:
                    for (int row = 1; row < rowcount; row++)
                    {
                        for (int col = 0; col < 6; col++)
                        {
                            if (number > lich.Sldk) break;
                            Button button = new Button();
                            button.Text = number.ToString();
                            button.Dock = DockStyle.Fill;
                            button.TextAlign = ContentAlignment.MiddleCenter;
                            button.Font = new Font("Arial", 12, FontStyle.Regular);
                            number++;
                            tableLayoutPanel1.Controls.Add(button, col, row);
                        }
                    }
                    break;
                case 2:
                    for (int row = rowcount - 1; row >= 1; row--)
                    {
                        for (int col = 0; col < 6; col++)
                        {
                            if (number > lich.Sldk) break;
                            Button button = new Button();
                            button.Text = number.ToString();
                            button.Dock = DockStyle.Fill;
                            button.TextAlign = ContentAlignment.MiddleCenter;
                            button.Font = new Font("Arial", 12, FontStyle.Regular);
                            number++;
                            tableLayoutPanel1.Controls.Add(button, col, row);
                        }
                    }
                    break;
                case 3:
                    for (int row = 1; row < rowcount; row++)
                    {
                        for (int col = 5; col >= 0; col--)
                        {
                            if (number > lich.Sldk) break;
                            Button button = new Button();
                            button.Text = number.ToString();
                            button.Dock = DockStyle.Fill;
                            button.TextAlign = ContentAlignment.MiddleCenter;
                            button.Font = new Font("Arial", 12, FontStyle.Regular);
                            number++;
                            tableLayoutPanel1.Controls.Add(button, col, row);
                        }
                    }
                    break;
                case 4:
                    for (int row = rowcount - 1; row >= 1; row--)
                    {
                        for (int col = 5; col >= 0; col--)
                        {
                            if (number > lich.Sldk) break;
                            Button button = new Button();
                            button.Text = number.ToString();
                            button.Dock = DockStyle.Fill;
                            button.TextAlign = ContentAlignment.MiddleCenter;
                            button.Font = new Font("Arial", 12, FontStyle.Regular);
                            number++;
                            tableLayoutPanel1.Controls.Add(button, col, row);
                        }
                    }
                    break;
                case 5:
                    for (int col = 5; col >= 0; col--)
                    {
                        for (int row = rowcount - 1; row >= 1; row--)
                        {
                            if (number > lich.Sldk)
                                break;

                            Button button = new Button();
                            button.Text = number.ToString();
                            button.Dock = DockStyle.Fill;
                            button.TextAlign = ContentAlignment.MiddleCenter;
                            button.Font = new Font("Arial", 12, FontStyle.Regular);
                            number++;
                            tableLayoutPanel1.Controls.Add(button, col, row);
                        }
                    }
                    break;
                case 6:
                    for (int col = 0; col <= 5; col++)
                    {
                        for (int row = rowcount - 1; row >= 1; row--)
                        {
                            if (number > lich.Sldk)
                                break;

                            Button button = new Button();
                            button.Text = number.ToString();
                            button.Dock = DockStyle.Fill;
                            button.TextAlign = ContentAlignment.MiddleCenter;
                            button.Font = new Font("Arial", 12, FontStyle.Regular);
                            number++;
                            tableLayoutPanel1.Controls.Add(button, col, row);
                        }
                    }
                    break;
                case 7:
                    for (int col = 0; col <= 5; col++)
                    {
                        for (int row = 1; row < rowcount; row++)
                        {
                            if (number > lich.Sldk)
                                break;

                            Button button = new Button();
                            button.Text = number.ToString();
                            button.Dock = DockStyle.Fill;
                            button.TextAlign = ContentAlignment.MiddleCenter;
                            button.Font = new Font("Arial", 12, FontStyle.Regular);
                            number++;
                            tableLayoutPanel1.Controls.Add(button, col, row);
                        }
                    }
                    break;
                case 8:
                    for (int col = 5; col >= 0; col--)
                    {
                        for (int row = 1; row < rowcount; row++)
                        {
                            if (number > lich.Sldk)
                                break;

                            Button button = new Button();
                            button.Text = number.ToString();
                            button.Dock = DockStyle.Fill;
                            button.TextAlign = ContentAlignment.MiddleCenter;
                            button.Font = new Font("Arial", 12, FontStyle.Regular);
                            number++;
                            tableLayoutPanel1.Controls.Add(button, col, row);
                        }
                    }
                    break;
                case 9:
                    for (int row = 1; row < rowcount; row++)
                    {
                        if ((row % 2) == 0)
                        {
                            for (int col = 5; col >= 0; col--)
                            {
                                if (number > lich.Sldk)
                                    break;
                                Button button = new Button();
                                button.Text = number.ToString();
                                button.Dock = DockStyle.Fill;
                                button.TextAlign = ContentAlignment.MiddleCenter;
                                button.Font = new Font("Arial", 12, FontStyle.Regular);
                                number++;
                                tableLayoutPanel1.Controls.Add(button, col, row);
                            }
                        }
                        else
                        {
                            for (int col = 0; col < 6; col++)
                            {
                                if (number > lich.Sldk)
                                    break;

                                Button button = new Button();
                                button.Text = number.ToString();
                                button.Dock = DockStyle.Fill;
                                button.TextAlign = ContentAlignment.MiddleCenter;
                                button.Font = new Font("Arial", 12, FontStyle.Regular);
                                number++;
                                tableLayoutPanel1.Controls.Add(button, col, row);
                            }
                        }
                    }
                    break;
                case 10:
                    for (int row = rowcount - 1; row >= 1; row--)
                    {
                        if ((row % 2) == 0)
                        {
                            for (int col = 5; col >= 0; col--)
                            {
                                if (number > lich.Sldk)
                                    break;
                                Button button = new Button();
                                button.Text = number.ToString();
                                button.Dock = DockStyle.Fill;
                                button.TextAlign = ContentAlignment.MiddleCenter;
                                button.Font = new Font("Arial", 12, FontStyle.Regular);
                                number++;
                                tableLayoutPanel1.Controls.Add(button, col, row);
                            }
                        }
                        else
                        {
                            for (int col = 0; col < 6; col++)
                            {
                                if (number > lich.Sldk)
                                    break;

                                Button button = new Button();
                                button.Text = number.ToString();
                                button.Dock = DockStyle.Fill;
                                button.TextAlign = ContentAlignment.MiddleCenter;
                                button.Font = new Font("Arial", 12, FontStyle.Regular);
                                number++;
                                tableLayoutPanel1.Controls.Add(button, col, row);
                            }
                        }
                    }
                    break;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện Click của Button
            Button button = (Button)sender;
            MessageBox.Show($"You clicked {button.Name}");
        }
        //từ trái qua phải, từ trên xuống dưới
        /*
        int number = 1;
        for (int row = 1; row < 11; row++)
        {
            for (int col = 0; col < 6; col++)
            {
                Button button = new Button();
                button.Text = number.ToString();
                button.Dock = DockStyle.Fill;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Font = new Font("Arial", 12, FontStyle.Regular);
                button.Click += Button_Click;
                number++;
                tableLayoutPanel1.Controls.Add(button, col, row);
            }
        }
         */
        //từ trái qua phải, từ dưới lên trên
        /*
         int number = 60;
            for (int row = 1; row < 11; row++)
            {
                for (int col = 5; col >= 0; col--)
                {
                    Button button = new Button();
                    button.Text = number.ToString();
                    button.Dock = DockStyle.Fill;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Arial", 12, FontStyle.Regular);
                    button.Click += Button_Click;
                    number--;
                    tableLayoutPanel1.Controls.Add(button, col, row);
                }
            }
         */
        //trừ phải qua trái, từ trên xuống dưới
        /*
            int number = 1;
            for (int row = 1; row < 11; row++)
            {
                for (int col = 5; col >= 0; col--)
                {
                    Button button = new Button();
                    button.Text = number.ToString();
                    button.Dock = DockStyle.Fill;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Arial", 12, FontStyle.Regular);
                    button.Click += Button_Click;
                    number++;
                    tableLayoutPanel1.Controls.Add(button, col, row);
                }
            }
         */
        // từ phải qua trái, từ dưới lên
        /*
         int number = 1;
            for (int row = 10; row >= 1; row--)
            {
                for (int col = 5; col >= 0; col--)
                {
                    Button button = new Button();
                    button.Text = number.ToString();
                    button.Dock = DockStyle.Fill;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Arial", 12, FontStyle.Regular);
                    button.Click += Button_Click;
                    number++;
                    tableLayoutPanel1.Controls.Add(button, col, row);
                }
            }
         */
        // từ dưới lên theo chiều dọc, phía bên phải
        /*
         int number = 1;
            for (int col = 5; col >= 0; col--)
            {
                for (int row = 10; row >= 1; row--)
                {
                    if (number > 57)
                        break;

                    Button button = new Button();
                    button.Text = number.ToString();
                    button.Dock = DockStyle.Fill;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Arial", 12, FontStyle.Regular);
                    button.Click += Button_Click;
                    number++;
                    tableLayoutPanel1.Controls.Add(button, col, row);
                }
            }
         */
        // từ dưới lên theo chiều dọc, phía bên trái
        /*
         int number = 1;
            for (int col = 0; col <= 5; col++)
            {
                for (int row = 10; row >= 1; row--)
                {
                    if (number > 60)
                        break;

                    Button button = new Button();
                    button.Text = number.ToString();
                    button.Dock = DockStyle.Fill;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Arial", 12, FontStyle.Regular);
                    button.Click += Button_Click;
                    number++;
                    tableLayoutPanel1.Controls.Add(button, col, row);
                }
            }
         */
        // từ trên xuống theo chiều dọc, phía bên trái
        /*
         int number = 1;
            for (int col = 0; col <= 5; col++)
            {
                for (int row = 1; row < 11; row++)
                {
                    if (number > 60)
                        break;

                    Button button = new Button();
                    button.Text = number.ToString();
                    button.Dock = DockStyle.Fill;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Arial", 12, FontStyle.Regular);
                    button.Click += Button_Click;
                    number++;
                    tableLayoutPanel1.Controls.Add(button, col, row);
                }
            }
         */
        // từ trên xuống theo chiều học, phía bên phải
        /*
         int number = 1;
            for (int col = 5; col >= 0; col--)
            {
                for (int row = 1; row <= 10; row++)
                {
                    if (number > 60)
                        break;

                    Button button = new Button();
                    button.Text = number.ToString();
                    button.Dock = DockStyle.Fill;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Arial", 12, FontStyle.Regular);
                    button.Click += Button_Click;
                    number++;
                    tableLayoutPanel1.Controls.Add(button, col, row);
                }
            }
         */
        // ziczac từ trên xuống 
        /*
         int number = 1;
            for (int row = 1; row < 11; row++)
            {
                if ((row % 2) == 0)
                {
                    for (int col = 5; col >= 0; col--)
                    {
                        Button button = new Button();
                        button.Text = number.ToString();
                        button.Dock = DockStyle.Fill;
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Font = new Font("Arial", 12, FontStyle.Regular);
                        button.Click += Button_Click;
                        number++;
                        tableLayoutPanel1.Controls.Add(button, col, row);
                    }
                }
                else
                {
                    for (int col = 0; col < 6; col++)
                    {
                        if (number > 60)
                            break;

                        Button button = new Button();
                        button.Text = number.ToString();
                        button.Dock = DockStyle.Fill;
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Font = new Font("Arial", 12, FontStyle.Regular);
                        button.Click += Button_Click;
                        number++;
                        tableLayoutPanel1.Controls.Add(button, col, row);
                    }
                }
            }
         */
        // ziczac từ dưới lên
        /*
         int number = 1;
            for (int row = 10; row >= 1; row--)
            {
                if ((row % 2) == 0)
                {
                    for (int col = 5; col >= 0; col--)
                    {
                        Button button = new Button();
                        button.Text = number.ToString();
                        button.Dock = DockStyle.Fill;
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Font = new Font("Arial", 12, FontStyle.Regular);
                        button.Click += Button_Click;
                        number++;
                        tableLayoutPanel1.Controls.Add(button, col, row);
                    }
                }
                else
                {
                    for (int col = 0; col < 6; col++)
                    {
                        if (number > 60)
                            break;

                        Button button = new Button();
                        button.Text = number.ToString();
                        button.Dock = DockStyle.Fill;
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Font = new Font("Arial", 12, FontStyle.Regular);
                        button.Click += Button_Click;
                        number++;
                        tableLayoutPanel1.Controls.Add(button, col, row);
                    }
                }
            }
         */
    }
}
