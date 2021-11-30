﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Model;
using DashboardFrontend.ViewModels;

namespace DashboardFrontend.DetachedWindows
{
    public partial class ValidationReportDetached
    {
        public ValidationReportDetached(ValidationReportViewModel validationReportViewModel)
        {
            InitializeComponent();
            ViewModel = validationReportViewModel;
            DataContext = ViewModel;
        }
        
        public ValidationReportViewModel ViewModel { get; set; }

        /// <summary>
        /// Called once a TreeViewItem is expanded. Gets the item's ManagerValidationsWrapper, and adds the manager name to a list of expanded TreeViewItems in the Validation Report viewmodel.
        /// </summary>
        /// <remarks>This ensures that the items stay expanded when the data is updated/refreshed.</remarks>
        private void TreeViewValidations_Expanded(object sender, RoutedEventArgs e)
        {
            TreeView tree = (TreeView)sender;
            TreeViewItem item = (TreeViewItem)e.OriginalSource;
            var wrapper = (ManagerValidationsWrapper)tree.ItemContainerGenerator.ItemFromContainer(item);
            if (!ViewModel.ExpandedManagerNames.Contains(wrapper.ManagerName))
            {
                ViewModel.ExpandedManagerNames.Add(wrapper.ManagerName);
            }
        }

        /// <summary>
        /// Called once a TreeViewItem is collapsed. Gets the item's ManagerValidationsWrapper, and removes the manager name to a list of expanded TreeViewItems in the Validation Report viewmodel.
        /// </summary>
        private void TreeViewValidations_Collapsed(object sender, RoutedEventArgs e)
        {
            TreeView tree = (TreeView)sender;
            TreeViewItem item = (TreeViewItem)e.OriginalSource;
            var wrapper = (ManagerValidationsWrapper)tree.ItemContainerGenerator.ItemFromContainer(item);
            ViewModel.ExpandedManagerNames.Remove(wrapper.ManagerName);
        }

        private void CopySrcSql_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            if (button.DataContext is ValidationTest test)
            {
                Clipboard.SetText(test.SrcSql);
            }
        }

        private void CopyDestSql_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            if (button.DataContext is ValidationTest test)
            {
                Clipboard.SetText(test.DstSql);
            }
        }
    }
}


