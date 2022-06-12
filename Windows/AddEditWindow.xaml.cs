using Microsoft.Win32;
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

namespace KInderGarten.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditWindow.xaml
    /// </summary>
    public partial class AddEditWindow : Window 
    {
        CHILD child = new CHILD();
        public AddEditWindow(CHILD cHILD)
        {
            InitializeComponent();
            if (cHILD != null)
                child = cHILD;
            DataContext = child;
            GroupComboBox.ItemsSource = Class.entities.GROUP.ToList();
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            var file = new OpenFileDialog();
            file.Filter =
               "Image files (*.JPG, *.PNG)| *jpg; *.png;";
            if (file.ShowDialog() == true)
            {
                Photo.Source = new BitmapImage(new Uri(file.FileName));
                child.IMAGE = File.ReadAllBytes(file.FileName);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (child.ID == 0)
            {
                Class.entities.CHILD.Add(child);
            }

            try
            {
                Class.entities.SaveChanges();
                MessageBox.Show("Информация сохранена!");
                DataContext = null;
                Photo.Source = null;
            }
            catch
            {
            }
        }
    }
}
