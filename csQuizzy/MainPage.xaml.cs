using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace csQuizzy
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public void testing()
        {
            QuestionOptions question1 = new QuestionOptions();
            question1.text = "It is Jecko";
            question1.status = QuestionOptionStatus.Correct.ToString();

            QuestionOptions question2 = new QuestionOptions();
            question2.text = "They are IO";
            question2.status = QuestionOptionStatus.Wrong.ToString();

            btn1.DataContext = question1;
            btn2.DataContext = question2;
            //btn2.Content = question2.text;

        }

        private async void btn_Click(object sender, RoutedEventArgs e)
        {
            Button selectBtn = sender as Button;
            QuestionOptions classItem = (QuestionOptions)selectBtn.DataContext;
            string msg = "question: " + classItem.text + "\r" + "question: " + classItem.status;
            txtxStatus.Text = msg;
            //MessageDialog ms = new MessageDialog(msg);
            //await ms.ShowAsync();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            testing();
        }
    }

    public class QuestionOptions
    {
        public string text { get; set; }
        public string status { get; set; }
    }

    public enum QuestionOptionStatus
    {
        Correct = 1,
        Wrong = 2,
        fiftyFifty = 3
    }
}
