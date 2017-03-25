using System;
using System.Windows;
using System.Threading;
using System.Collections.ObjectModel;
using ShoeStoreMvvm.Models;
// Toolkit namespace
using SimpleMvvmToolkit;
using Pers.Fhr.ShoeStoreLib.Service;
using Pers.Fhr.ShoeStoreLib.Service.Impl;
using Pers.Fhr.ShoeStoreLib.EntityManager;
using System.Collections.Generic;

namespace ShoeStoreMvvm.ViewModels
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvmprop</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// </summary>
    public class ShoeItemMananageViewModel : ViewModelBase<ShoeItemMananageViewModel>
    {
        #region Fields
        private ObservableCollection<ShoeItem> shoeItems=new ObservableCollection<ShoeItem>();
        private ObservableCollection<string> shoeStyles = new ObservableCollection<string>();
        private ObservableCollection<float> shoeSizes = new ObservableCollection<float>();
        private IShoeItemQueryService shoeItemQueryService = new ShoeItemServiceClass(new ShoeItemManager());
        #endregion
        // TODO: Add a member for IXxxServiceAgent

        // Default ctor
        public ShoeItemMananageViewModel() {
            List<ShoeItem> tempShoeItems=shoeItemQueryService.FindAllShoeItems();
            //tempShoeItems.
            shoeItems = new ObservableCollection<ShoeItem>(tempShoeItems);
        }

        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        // TODO: Add properties using the mvvmprop code snippet
        public ObservableCollection<ShoeItem> ShoeItems
        {
            get { return this.shoeItems; }
            set { this.shoeItems = value; NotifyPropertyChanged(p => p.ShoeItems); }
        }
        public ObservableCollection<string> ShoeStyles
        {
            get { return this.shoeStyles; }
            set { this.shoeStyles = value; NotifyPropertyChanged(p => p.ShoeStyles); }
        }
        public ObservableCollection<float> ShoeSizes
        {
            get { return this.shoeSizes; }
            set { this.shoeSizes = value; NotifyPropertyChanged(p => p.ShoeSizes); }
        }
        // TODO: Add methods that will be called by the view

        // TODO: Optionally add callback methods for async calls to the service agent
        
        // Helper method to notify View of an error
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }
    }
}