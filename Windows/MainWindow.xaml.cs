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

namespace KInderGarten
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ChildrenListView.ItemsSource = Class.entities.CHILD.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddEditWindow addEditWindow = new Windows.AddEditWindow(null);
            addEditWindow.Show();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var delete = ChildrenListView.SelectedItems.Cast<CHILD>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {delete.Count()} элементы?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                try
                {
                    Class.entities.CHILD.RemoveRange(delete);
                    Class.entities.SaveChanges();
                    ChildrenListView.ItemsSource = Class.entities.CHILD.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
        }

        private void Source_TextChanged(object sender, TextChangedEventArgs e)
        {
            var sourceChild = Class.entities.CHILD.ToList();
            sourceChild = sourceChild.Where(d => d.NAME.ToLower().Contains(Source.Text.ToLower()) ||
                d.GROUP.NAME.ToLower().Contains(Source.Text.ToLower())).ToList();
            ChildrenListView.ItemsSource = sourceChild;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddEditWindow addEditWindow = new Windows.AddEditWindow((sender as Button).DataContext as CHILD);
            addEditWindow.Show();

        }

        public void Refresh()
        {
            ChildrenListView.ItemsSource = Class.entities.CHILD.ToList();
        }

    }
}
