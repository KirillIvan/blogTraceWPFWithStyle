using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace blogTraceWPFWithStyle
{
    /// <summary>
    /// Логика взаимодействия для Blog.xaml
    /// </summary>
    public partial class Blog : Window
    {
        bool[] isNull = new bool[7] { false,false,false,false,false,false,false };
        Users users;
        XmlSerializer serializerUsers = new XmlSerializer(typeof(Users));
        public static User user;
        CurrentEvents currentEvents;
        XmlSerializer serializerNews = new XmlSerializer(typeof(CurrentEvents));
        List<StackPanel> stackPanels = new List<StackPanel> { };
        Style expanderStyle = new Style();
        Trigger triggerIsMouseOver = new Trigger { Property = UIElement.IsMouseOverProperty, Value = true };
        SolidColorBrush btnDefaultBgColor = new SolidColorBrush(Color.FromRgb(154, 206, 235));
        SolidColorBrush btnCheckedBgColor = new SolidColorBrush(Color.FromRgb(66, 161, 215));

        public Blog()
        {
            InitializeComponent();
            using (Stream stream = File.Open("Users.xml", FileMode.OpenOrCreate))
            {
                users = ((Users)serializerUsers.Deserialize(stream));
            }
            triggerIsMouseOver.Setters.Add(new Setter { Property = Control.ForegroundProperty, Value = new SolidColorBrush(Colors.Red) });
            expanderStyle.Setters.Add(new Setter { Property = Control.FontFamilyProperty, Value = new FontFamily("Segoe Print") });
            expanderStyle.Setters.Add(new Setter { Property = Control.ForegroundProperty, Value = new SolidColorBrush(Color.FromRgb(165, 177, 189)) });
            expanderStyle.Triggers.Add(triggerIsMouseOver);
            using (Stream streamNews = File.Open("News.xml", FileMode.OpenOrCreate))
                currentEvents = (CurrentEvents)serializerNews.Deserialize(streamNews);
            UpdateNews();
        }

        public void UpdateNews()
        {
            
            foreach (var item in currentEvents.news)
            {
                StackPanel stackPanel = new StackPanel() { Background = new SolidColorBrush(Colors.WhiteSmoke), Margin= new Thickness(10) };
                stackPanel.Children.Add(new Expander() { Header = item.Headline, Content = (new TextBlock() { Text = item.Content, Foreground = new SolidColorBrush(Colors.Black), TextWrapping = TextWrapping.Wrap }), Style = (expanderStyle), FontSize = 14, Margin = new Thickness(10) });
                stackPanel.Children.Add(new TextBlock() { Text = (item.Data + ", " + item.NameUser), Margin = new Thickness(10) });
                newsPanel.Children.Add(stackPanel);
            }
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            sbPanel.Visibility = Visibility.Visible;
            userCardPanel.Visibility = newArticlePanel.Visibility = Visibility.Collapsed;
            newArticle.Background = userCard.Background = btnDefaultBgColor;
            userCard.Style = newArticle.Style = null;
            if (((Button)sender).Background == btnDefaultBgColor)
                UpdateNews();
            news.Background = btnCheckedBgColor;
            news.Style = (Style)btnStyle.FindResource("btnMouse");
        }

        private void UserCard_Click(object sender, RoutedEventArgs e)
        {
            userCardPanel.Visibility = Visibility.Visible;
            sbPanel.Visibility = newArticlePanel.Visibility = Visibility.Collapsed;
            newArticle.Background = news.Background = btnDefaultBgColor;
            newArticle.Style = news.Style = null;
            userCard.Background = btnCheckedBgColor;
            userCard.Style = (Style)btnStyle.FindResource("btnMouse");
            newsPanel.Children.Clear();
            UserCardPanel_Update();
        }

        private void UserCardPanel_Update()
        {
            nameBox.Text = user.Name;
            surnameBox.Text = user.Surname;
            cityBox.Text = user.City;
            ageBox.Text = user.Age;
            loginBox.Text = user.Login;
            pswdBox.Text = user.Password;
        }

        private void BtnTransform_Click(object sender, RoutedEventArgs e)
        {
            if (user.Name != nameBox.Text || user.Surname != surnameBox.Text || user.City != cityBox.Text || user.Age != ageBox.Text || user.Login != loginBox.Text || user.Password != pswdBox.Text)
            {
                users.items.Remove(user);
                user = new User(nameBox.Text, surnameBox.Text, cityBox.Text, ageBox.Text, loginBox.Text, pswdBox.Text, user.Admin);
                users.items.Add(user);
            }
        }

        private void IsNullTextBox(string name, bool isNullElem, string text)
        {
            switch (name)
            {
                case "nameBox":
                    if (text != "Имя")
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
                textBox.BorderBrush = new SolidColorBrush(Color.FromRgb(239, 247, 254));
                IsNullTextBox(textBox.Name, false, textBox.Text);
            }
        }

        private void BtnNewArticle_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(headLineBox.Text) && !String.IsNullOrWhiteSpace(articleBox.Text) && articleBox.Text != "Текст статьи" && headLineBox.Text != "Заголовок")
            {
                currentEvents.news.Add(new News(headLineBox.Text, articleBox.Text, DateTime.Now.ToString(), user.Name + " " + user.Surname));
                NewArticlePanel_Update();
                News_Click(news, new RoutedEventArgs());
                using (FileStream fileStream = new FileStream("News.xml", FileMode.Create))
                {
                    serializerNews.Serialize(fileStream, currentEvents);
                }
            }
            else
                MessageBox.Show("Не все поля заполнены", "Статья не добавлена", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void NewArticle_Click(object sender, RoutedEventArgs e)
        {
            newArticlePanel.Visibility = Visibility.Visible;
            sbPanel.Visibility = userCardPanel.Visibility = Visibility.Collapsed;
            userCard.Background = news.Background = btnDefaultBgColor;
            userCard.Style = news.Style = null;
            newArticle.Background = btnCheckedBgColor;
            newArticle.Style = (Style)btnStyle.FindResource("btnMouse");
            newsPanel.Children.Clear();
            NewArticlePanel_Update();
        }

        private void NewArticlePanel_Update()
        {
            headLineBox.Text = "Заголовок";
            articleBox.Text = "Текст статьи";
        }

        private void HeadLineBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (headLineBox.Text == "Заголовок")
                headLineBox.Text = "";
        }

        private void ArticleBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (articleBox.Text == "Текст статьи")
                articleBox.Text = "";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("Users.xml", FileMode.Create))
            {
                serializerUsers.Serialize(fileStream, users);
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            sbPanel.Height = this.Height - 75;
        }
    }
}
