// TravelWindow
// Programer: Rob Garner (rgarner7@cnm.edu)
// Date: 25 May 2016
// User interface that provides user capability to travel
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

namespace MontanoP7
{
    /// <summary>
    /// Window that shows player where they are and provides capability to move from location to location in the map.
    /// </summary>
    public partial class TravelWindow : Window
    {
        /// <summary>
        /// Game object that has map
        /// </summary>
        Map game;
        Player player;
        List<string> status = new List<string>();


        /// <summary>
        /// Initialize the form, the game and call display location to start the form.
        /// </summary>
        public TravelWindow()
        {
            InitializeComponent();
            game = new Map();
            player = new Player(game.Locations[0]);
            DisplayLocation();
        }

        /// <summary>
        /// Tells the player where they are.
        /// </summary>
        private void DisplayLocation()
        {
            txbLocationDescription.Text = player.Location.Description;
            lbTraveOptions.ItemsSource = player.Location.TravelOptions;
            lbItemSearch.ItemsSource = player.Location.Items;

        }

        /// <summary>
        /// Double click a travel option to move to a new location on the map.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbTraveOptions_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           TravelOption to = (TravelOption)lbTraveOptions.SelectedItem;
            player.Location = to.Location;
            status.Add("You travel to: " + to);
            lbGameStatus.ItemsSource = status;
            lbGameStatus.Items.Refresh();
            DisplayLocation();
            
        }

        private void lbItemSearch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Select and option to the right!");
        }

        private void btnTake_Click(object sender, RoutedEventArgs e)
        {
            if (lbItemSearch.SelectedItem is InventoryItem)
            { 
                InventoryItem invI = (InventoryItem)lbItemSearch.SelectedItem;
                player.AddInventoryItem(invI);
                lbPlayerInventory.ItemsSource = player.inventory;
                lbPlayerInventory.Items.Refresh();
                status.Add("You added " + invI + " into your inventory");
                lbGameStatus.ItemsSource = status;
                lbGameStatus.Items.Refresh();
                    
            }
            else if (lbItemSearch.SelectedItem is PortableHidingPlace)
            {
                PortableHidingPlace invI = (PortableHidingPlace)lbItemSearch.SelectedItem;
                MessageBox.Show("This item can also be searched!");
                player.AddInventoryItem(invI);
                lbItemSearch.Items.Refresh();
                lbPlayerInventory.ItemsSource = player.inventory;
                lbPlayerInventory.Items.Refresh();
                status.Add("You added " + invI + " into your inventory");
                lbGameStatus.ItemsSource = status;
                lbGameStatus.Items.Refresh();
            }
            else
            {
                MessageBox.Show("You can not take this item, it is a hiding place");
            }
            
            
            
        }

        private void btnDrop_Click(object sender, RoutedEventArgs e)
        {
            
            InventoryItem invI = (InventoryItem)lbPlayerInventory.SelectedItem;
            player.RemoveInventoryItem(invI);
            lbPlayerInventory.ItemsSource = player.inventory;
            lbPlayerInventory.Items.Refresh();
            status.Add("You dropped " + invI + " from your inventory");
            lbGameStatus.ItemsSource = status;
            lbGameStatus.Items.Refresh();
        }

        
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (lbItemSearch.SelectedItem is HidingPlace)
            {
                
                HidingPlace invI = (HidingPlace)lbItemSearch.SelectedItem;
                invI.Search();
                MessageBox.Show("This is a hiding place! You found " + invI.HiddenObject);
                status.Add("You searched " + invI + " and found " + " a " + invI.HiddenObject);
                player.Location.Items.Add(invI.HiddenObject);
                lbItemSearch.Items.Refresh();
                lbGameStatus.ItemsSource = status;
                lbGameStatus.Items.Refresh();

            }
            else if (lbItemSearch.SelectedItem is PortableHidingPlace)
            {
                
                PortableHidingPlace invI = (PortableHidingPlace)lbItemSearch.SelectedItem;
                invI.Search();
                MessageBox.Show("You searched this item and found " + invI.HiddenObject + " you can also take the item!");
                status.Add("You searched " + invI + " and found " + " a " + invI.HiddenObject);
                player.Location.Items.Add(invI.HiddenObject);
                lbItemSearch.Items.Refresh();
                lbGameStatus.ItemsSource = status;
                lbGameStatus.Items.Refresh();
            }
            else
            {
                MessageBox.Show("This item can be put in you inventory");
            }

        }
    }
}
