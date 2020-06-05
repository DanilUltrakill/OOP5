using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для PersonInfo.xaml
    /// </summary>
    public partial class PersonInfo : UserControl
    {
        public PersonInfo()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty FNameProperty = DependencyProperty.Register(
                                                 "name", // имя параметра в разметке
                                                 typeof(string), // тип данных параметра
                                                 typeof(PersonInfo), // тип данных элемента управления
                                                 new PropertyMetadata(string.Empty, NameChanged));

        public string FName
        {
            get { return (string)GetValue(FNameProperty); }
            set { SetValue(FNameProperty, value); }
        }

        private static void NameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonInfo;
            loginForm.name.Text = loginForm.FName.ToString();
        }

        public static readonly DependencyProperty SurNameProperty = DependencyProperty.Register(
                                               "surname", // имя параметра в разметке
                                               typeof(string), // тип данных параметра
                                               typeof(PersonInfo), // тип данных элемента управления
                                               new PropertyMetadata(string.Empty, SurNameChanged));

        public string SurName
        {
            get { return (string)GetValue(SurNameProperty); }
            set { SetValue(SurNameProperty, value); }
        }

        private static void SurNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonInfo;
            loginForm.surname.Text = loginForm.SurName.ToString();
        }

        public static readonly DependencyProperty AgeProperty = DependencyProperty.Register(
                                               "age", // имя параметра в разметке
                                               typeof(string), // тип данных параметра
                                               typeof(PersonInfo), // тип данных элемента управления
                                               new PropertyMetadata(string.Empty, AgeChanged));

        public string Age
        {
            get { return (string)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        private static void AgeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonInfo;
            loginForm.age.Text = loginForm.Age.ToString();
        }

        public static readonly DependencyProperty StateProperty = DependencyProperty.Register(
                                               "state", // имя параметра в разметке
                                               typeof(string), // тип данных параметра
                                               typeof(PersonInfo), // тип данных элемента управления
                                               new PropertyMetadata(string.Empty, StateChanged));

        public string State
        {
            get { return (string)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        private static void StateChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonInfo;
            loginForm.state.Text = loginForm.State.ToString();
        }





        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register(
                                               "photo", // имя параметра в разметке
                                               typeof(string), // тип данных параметра
                                               typeof(PersonInfo), // тип данных элемента управления
                                               new PropertyMetadata(string.Empty, ImageChanged));

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        private static void ImageChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonInfo;
            loginForm.photo.Source = new BitmapImage(new Uri($"pack://application:,,,/{loginForm.Image}"));
        }

        private void write_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Он не хочет с вами общаться");
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удалён");
        }

        private void block_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Очень по-взрослому");
        }
    }
}
