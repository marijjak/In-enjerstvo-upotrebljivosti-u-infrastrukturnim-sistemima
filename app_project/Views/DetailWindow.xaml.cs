using app_project.Models;
using System;
using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace app_project.Views
{
    public partial class DetailWindow : Window
    {
        public DetailWindow(IconicMoment moment)
        {
            InitializeComponent();
            PopulateFields(moment);
        }

        private void PopulateFields(IconicMoment moment)
        {
            this.Title = moment.Title;
            TitleValue.Text = moment.Title;
            YearValue.Text = moment.Year.ToString();
            DateValue.Text = moment.DateAdded.ToString("dd MMMM yyyy",
      System.Globalization.CultureInfo.InvariantCulture);

            // Slika
            if (File.Exists(moment.ImagePath))
            {
                MomentImage.Source = new System.Windows.Media.Imaging
                    .BitmapImage(new Uri(
                        Path.GetFullPath(moment.ImagePath)));
            }

            // RTF sadrzaj
            // RTF sadrzaj
            if (File.Exists(moment.RtfFilePath))
            {
                using var fs = new FileStream(moment.RtfFilePath, FileMode.Open);
                var doc = new FlowDocument();
                var range = new TextRange(doc.ContentStart, doc.ContentEnd);
                range.Load(fs, DataFormats.Rtf);
                doc.Background = System.Windows.Media.Brushes.Transparent;
                doc.Foreground = new System.Windows.Media.SolidColorBrush(
                    (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#D4C5A9"));
                doc.FontFamily = new System.Windows.Media.FontFamily("Georgia");
                doc.FontSize = 13;
                doc.PagePadding = new Thickness(0);
                DescriptionViewer.Document = doc;
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseLeftButtonDown(object sender,
    System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}