using BUS;
using DTO;
using System.Windows;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BUS_NhanVien busNV = new BUS_NhanVien();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // dang nhap  
            DTO_NhanVien dtoNV = new DTO_NhanVien();
            dtoNV.Email = txtEmail.Text;
            dtoNV.MatKhau = busNV.encryption(txtPassword.Text);
            if (busNV.NhanVienDangNhapp(dtoNV))
            {
                MessageBox.Show("Đăng nhập thành công");
                //QLBH_MainFRM.session = 1;
            }
            else
            {
                MessageBox.Show("Đăng nhập ko thành công!");
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }
        }
    }
}
