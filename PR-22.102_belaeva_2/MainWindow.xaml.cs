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

namespace PR_22._102_belaeva_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = tBox.Text;
           
            for (int k = 0; k < a.Length; k++) {
                if ((a[k] < 'A' || a[k] > 'z') || (a[k] > 'Z' && a[k] < 'a') || a[k]==' ')
                {
                    MessageBox.Show("нужно вводить только английские буквы", "ошибка", MessageBoxButton.OK);
                    break;
                }
                else
                {
                    char[] b = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                    int c = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        for (int j = 0; j < b.Length; j++)
                        {
                            if (a[i] == b[j])
                                c++;

                        }

                    }
                    tBlock.Text = "Количество содержащихся в строке английских гласных: " + c.ToString();
                    string[] aa = a.Split(' ', ',', '.');
                    string bb = "";
                    foreach (string str in aa)
                    {
                        if (str.Length > bb.Length)
                        {
                            bb = str;
                        }
                    }
                    tBlock.Text += "\nСамое длинное слово: " + bb;
                }
            }
            
        }
    }
}
