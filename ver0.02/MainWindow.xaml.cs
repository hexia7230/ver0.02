
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        // Sample
        private List<Item> inventory = new List<Item>
        {

            //new Item { ID = 1, Name = "Item 1", Quantity = 10, Detail = "Detail 1", Category = "Category 1", Price = 10.99 },
            //new Item { ID = 2, Name = "Item 2", Quantity = 20, Detail = "Detail 2", Category = "Category 2", Price = 20.99 },
            //new Item { ID = 3, Name = "Item 3", Quantity = 30, Detail = "Detail 3", Category = "Category 3", Price = 30.99 }
        };


        public MainWindow()
        {
            InitializeComponent();

            Login_Button.Click += LoginButton_Click;


            Inventory_Button.Click += Inventory_Button_Click;
            Add_button.Click += Addbutton_Click;

            Update.Click += Update_Click;

            AddButton.Click += AddButton_Click;

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Hello," + UID_Box.Text);


            FunGrid.Visibility = Visibility.Visible;
            PasswordBox.Visibility = Visibility.Hidden;
            SubWindow.Visibility = Visibility.Visible;
        }

        private void Inventory_Button_Click(object sender, RoutedEventArgs e)
        {


            AddWindow.Visibility = Visibility.Hidden;
            SubWindow.Visibility = Visibility.Hidden;

            InvWindow.Visibility = Visibility.Visible;
            ShowInventory();
        }

        private void Addbutton_Click(object sender, RoutedEventArgs e)
        {
            InvWindow.Visibility = Visibility.Hidden;
            SubWindow.Visibility = Visibility.Hidden;

            ShowAddItem();
            AddWindow.Visibility = Visibility.Visible;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("YOU ARE NOT MANAGER, GET OFF FOOL!!");
        }


        private void ShowInventory()
        {
            InvWindow.Visibility = Visibility.Visible;
            ItemList.ItemsSource = inventory;
        }


        private void ShowAddItem()
        {
            AddWindow.Visibility = Visibility.Visible;
        }



        private void AddButton_Click(object sender, RoutedEventArgs e) //add new item
        {

            Item newItem = new Item
            {
                ID = Convert.ToInt32(AddID.Text),
                Name = AddItem.Text,
                Quantity = Convert.ToInt32(AddQuantity.Text),
                Detail = AddDetail.Text,
                Category = AddCategory.Text,
                Price = Convert.ToDouble(AddPrice.Text)
            };
            inventory.Add(newItem);

            LogBox.Text += $"\nAdded: {newItem.Name}";
        }

        // item class
        public class Item
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public string Detail { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
        }

    }
}
