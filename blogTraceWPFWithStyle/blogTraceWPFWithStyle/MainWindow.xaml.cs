using System;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace blogTraceWPFWithStyle
{

    public partial class MainWindow : Window
    {
        Users users;
        public static XmlSerializer serializer = new XmlSerializer(typeof(Users));
        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {



            foreach (var item in users.items)
            {
                if (item.Login == loginBox.Text && item.Password == PswdBox.Password)
                {
                    Blog blog = new Blog();
                    Blog.user = item;
                    blog.Show();
                    this.Close();

                }
            }

            error.Visibility = Visibility.Visible;
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("Users.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fileStream, users);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            using (Stream stream = File.Open("Users.xml", FileMode.OpenOrCreate))
            {
                users = ((Users)serializer.Deserialize(stream));
            }


        }

        private void LoginBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text == "Логин")
                loginBox.Text = "";
        }

        private void PswdBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PswdBox.Password == "Логин")
                PswdBox.Password = "";
        }
    }
}
