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

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddToDoButton_Click(object sender,RoutedEventArgs e)
        {
            string todoText = ToDoInput.Text;
            if (!string.IsNullOrEmpty(todoText))
            {
                TextBlock todoItem = new TextBlock();
                todoItem.Text = todoText;
                todoItem.Margin = new Thickness(10);
                todoItem.Foreground = new SolidColorBrush(Colors.White);

                ToDoList.Items.Add(todoItem);

                ToDoInput.Clear();
            }
        }

        private void Erase(object sender, RoutedEventArgs e)
        {
            var selectedItems = ToDoList.SelectedItems.Cast<TextBlock>().ToList();

            foreach (var selectedItem in selectedItems)
            {
                ToDoList.Items.Remove(selectedItem);
            }
        }

    }
}
