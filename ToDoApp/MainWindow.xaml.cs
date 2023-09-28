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

                ToDoList.Children.Add(todoItem);

                ToDoInput.Clear();
            }

            
        }

        private void ClearListButton(object sender, RoutedEventArgs e)
        {
                // Create a list to store the TextBlock elements to be removed.
            List<TextBlock> textBlocksToRemove = new List<TextBlock>();

            foreach (UIElement element in ToDoList.Children)
            {
                if (element is TextBlock textblock)
                {
                    // Check if the child element is a TextBlock and add it to the removal list.
                    textBlocksToRemove.Add(textblock);
                }
            }

            // Remove the identified TextBlock elements from the ToDoList.
            foreach (TextBlock textBlockToRemove in textBlocksToRemove)
            {
                ToDoList.Children.Remove(textBlockToRemove);
            }

            MessageBox.Show("Congratulations on completing your TODO List!");
        }
    }
}
