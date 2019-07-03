using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Serialization;

namespace blogTraceWPFWithStyle
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        bool[] isNull = new bool[7] { true, true, true, true, true, true, true};
        Users users;
        XmlSerializer serializer = new XmlSerializer(typeof(Users));
        public Registration()
        {
            InitializeComponent();
            using (Stream stream = File.Open("Users.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    users = ((Users)serializer.Deserialize(stream));
                }
                catch
                {
                    users = new Users();
                }
            }
        }

        private void NameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (nameBox.Text == "Имя")
                nameBox.Text = "";
        }

        private void SurnameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (surnameBox.Text == "Фамилия")
                surnameBox.Text = "";
        }

        private void CityBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (cityBox.Text == "Город")
                cityBox.Text = "";
        }

        private void AgeBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ageBox.Text == "Возраст")
                ageBox.Text = "";
        }

        private void LogoBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (logoBox.Text == "Логин")
                logoBox.Text = "";
        }

        private void PswdBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pswdBox.Text == "Пароль")
                pswdBox.Text = "";
        }

        private void DPswdBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (dPswdBox.Text == "Повторите")
                dPswdBox.Text = "";
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            bool tempBool = true, doubleLogin = false;
            foreach (var item in isNull)
            {
                if(item == true)
                {
                    tempBool = false;
                    break;
                }
            }
            foreach (var item in users.items)
            {
                if(item.Login == logoBox.Text)
                {
                    doubleLogin = true;
                    break;
                }
            }
            if (tempBool && !doubleLogin)
            {
                User user = new User(nameBox.Text, surnameBox.Text, cityBox.Text, ageBox.Text, logoBox.Text, pswdBox.Text, false);
                users.items.Add(user);
                using (FileStream fileStream = new FileStream("Users.xml", FileMode.Create))
                {
                    serializer.Serialize(fileStream, users);
                }
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                if (doubleLogin)
                {
                    MessageBox.Show("Данный логин уже используется", "Регистрация не произошла", MessageBoxButton.OK, MessageBoxImage.Error);
                    logoBox.Text = "";
                }
                else
                    MessageBox.Show("Не все поля заполнены", "Регистрация не произошла", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void IsNullTextBox(string name, bool isNullElem, string text)
        {
            switch (name)
            {
                case "nameBox":
                    if(text != "Имя")
                        isNull[0] = isNullElem;
                    break;
                case "surnameBox":
                    if (text != "Фамилия")
                        isNull[1] = isNullElem;
                    break;
                case "cityBox":
                    if (text != "Город")
                        isNull[2] = isNullElem;
                    break;
                case "ageBox":
                    if (text != "Возраст")
                        isNull[3] = isNullElem;
                    break;
                case "logoBox":
                    if (text != "Логин")
                        isNull[4] = isNullElem;
                    break;
                case "pswdBox":
                    if (text != "Пароль")
                        isNull[5] = isNullElem;
                    break;
                case "dPswdBox":
                    if (text != "Повторите")
                        isNull[6] = isNullElem;
                    break;
            }
        }

        private void NameBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BorderBrush = new SolidColorBrush(Colors.Red);
                IsNullTextBox(textBox.Name, true, "");
            }
            else
            {
                textBox.BorderBrush = new SolidColorBrush(Color.FromRgb(239,247,254));
                IsNullTextBox(textBox.Name, false, textBox.Text);
            }
        }

        
    }
}
