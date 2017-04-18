﻿using System;
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
using System.Windows.Input;
using System.Linq;
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
        private ObservableCollection<ShoeItem> shoeItems=null;
        private ObservableCollection<string> shoeStyles =null;
        private ObservableCollection<float> shoeSizes =null;
        private ObservableCollection<string> seasons = null;
        private ObservableCollection<string> colors = null;
        private IShoeItemQueryService shoeItemQueryService = new ShoeItemServiceClass(new ShoeItemManager());
        private IShoeService shoeService = new ShoeService(new ShoeManager());
        #endregion
        // TODO: Add a member for IXxxServiceAgent

        // Default ctor
        public ShoeItemMananageViewModel() {
           
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
        public ObservableCollection<string> Seasons
        {
            get { return seasons; }
            set { seasons = value; NotifyPropertyChanged(p => p.Seasons); }
        }
        public ObservableCollection<string> Colors
        {
            get { return colors; }
            set { colors = value; NotifyPropertyChanged(p => p.Colors); }
        }
        #region Commands
        public ICommand LoadCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    List<ShoeItem> tempShoeItems = shoeItemQueryService.FindAllShoeItems();
                    this.ShoeItems = new ObservableCollection<ShoeItem>(tempShoeItems);
                    this.ShoeSizes = new ObservableCollection<float>(tempShoeItems.Select(p => p.Size).Distinct());
                    this.Colors = new ObservableCollection<string>(tempShoeItems.Select(p => p.Color).Distinct());
                    this.ShoeStyles = new ObservableCollection<string>(shoeService.FindShoeTypes());
                    this.Seasons = new ObservableCollection<string>(this.shoeService.FindSeansons());
                });
            }
        }
        #endregion
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