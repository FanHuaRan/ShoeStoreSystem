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
        #region Fiels
        private ObservableCollection<ShoeItem> shoeItems=new ObservableCollection<ShoeItem>();
        private IShoeItemQueryService shoeItemQueryService = new ShoeItemServiceClass(new ShoeItemManager());
        #endregion
        // TODO: Add a member for IXxxServiceAgent

        // Default ctor
        public ShoeItemMananageViewModel() {
            shoeItems = new ObservableCollection<ShoeItem>(shoeItemQueryService.FindAllShoeItems() as List<ShoeItem>);
        }

        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        // TODO: Add properties using the mvvmprop code snippet
        public ObservableCollection<ShoeItem> ShoeItems
        {
            get { return this.shoeItems; }
            set { this.shoeItems = value; NotifyPropertyChanged(p => p.ShoeItems); }
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