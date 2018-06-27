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

namespace _123
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 宣告隨機物件
            Random end = new Random();
            // 宣告陣列
            string[] food = { "A", "B", "C", "D", "E","F" };
            // 隨機洗牌開始
            for (int i = 0; i < food.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = food[i];

                // 將第隨機個元素放到目前位置（交換)
                int r = end.Next(0, food.Length);
                food[i] = food[r];

                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                food[r] = temp;
            }
            for (int i = 0; i < food.Length; i++)
            {
                END.Text = food[i].ToString();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void END_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
