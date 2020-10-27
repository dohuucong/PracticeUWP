using Practice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Product> Products;

        private ObservableCollection<Contact> Contacts;

        public MainPage()
        {
            this.InitializeComponent();
            Products = new List<Product>();
            Products.Add(new Product { ProductPath = "Assets/anh1.jpg" });
            Products.Add(new Product { ProductPath = "Assets/anh2.jpg" });
            Products.Add(new Product { ProductPath = "Assets/anh3.jpg" });

            Contacts = new ObservableCollection<Contact>();
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Product)Image.SelectedValue).ProductPath;
            Contacts.Add(new Contact
            {
                Product = ProductTextBox.Text,
                Description = DescriptionTextBox.Text,
                Image = avatar
            });

            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            Image.SelectedIndex = -1;

            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
