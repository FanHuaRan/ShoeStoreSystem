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
        #region Data Fields
        private ObservableCollection<ShoeItem> shoeItems=null;
        private ObservableCollection<string> shoeStyles =null;
        private ObservableCollection<float> shoeSizes =null;
        private ObservableCollection<string> seasons = null;
        private ObservableCollection<string> colors = null;
        private string selectShoeStyle = null;
        private float? selectShoeSize = null;
        private string selectSeason = null;
        private string selectColor = null;
        #endregion

        #region Service Component
        private IShoeItemQueryService shoeItemQueryService = new ShoeItemServiceClass(new ShoeItemManager());
        private IShoeItemService shoeItemService = new ShoeItemServiceClass(new ShoeItemManager());
        private IShoeService shoeService = new ShoeService(new ShoeManager());
        #endregion
        // Default ctor
        public ShoeItemMananageViewModel() {
           
        }

        // TODO: Add properties using the mvvmprop code snippet
        #region Propertys
        public ObservableCollection<ShoeItem> ShoeItems
        {
            get { return this.shoeItems; }
            set
            {
                if (this.shoeItems != value)
                {
                    this.shoeItems = value; 
                    NotifyPropertyChanged(p => p.ShoeItems);
                }
            }
        }
        public ObservableCollection<string> ShoeStyles
        {
            get { return this.shoeStyles; }
            set
            {
                if (this.shoeStyles != value)
                {
                    this.shoeStyles = value;
                    NotifyPropertyChanged(p => p.ShoeStyles);
                }
            }
        }
        public ObservableCollection<float> ShoeSizes
        {
            get { return this.shoeSizes; }
            set
            {
                if (this.ShoeSizes != value)
                {
                    this.shoeSizes = value;
                    NotifyPropertyChanged(p => p.ShoeSizes);
                }
            }
        }
        public ObservableCollection<string> Seasons
        {
            get { return seasons; }
            set
            {
                if (this.seasons != value)
                {
                    this.seasons = value; 
                    NotifyPropertyChanged(p => p.Seasons);
                }
            }
        }
        public ObservableCollection<string> Colors
        {
            get { return colors; }
            set
            {
                if (this.colors != value)
                {
                    colors = value; 
                    NotifyPropertyChanged(p => p.Colors);
                }
            }
        }
        public string SelectShoeStyle
        {
            get { return selectShoeStyle; }
            set
            {
                if (this.SelectShoeStyle != value)
                {
                    selectShoeStyle = value;
                    NotifyPropertyChanged(p => p.SelectShoeStyle);
                }
            }
        }
        public float? SelectShoeSize
        {
            get { return selectShoeSize; }
            set
            {
                if (this.SelectShoeSize != value)
                {
                    selectShoeSize = value;
                    NotifyPropertyChanged(p => p.SelectShoeSize);
                }
            }
        }
        public string SelectSeason
        {
            get { return selectSeason; }
            set
            {
                if (this.SelectSeason != value)
                {
                    selectSeason = value;
                    NotifyPropertyChanged(p => p.SelectSeason);
                }
            }
        }
        public string SelectColor
        {
            get { return selectColor; }
            set
            {
                if (this.selectColor != value)
                {
                    selectColor = value;
                    NotifyPropertyChanged(p => p.SelectColor);
                }
            }
        }
        #endregion
        #region Commands
        public ICommand LoadCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var tempShoeItems = shoeItemQueryService.FindAllShoeItems();
                    this.ShoeItems = new ObservableCollection<ShoeItem>(tempShoeItems);
                    this.ShoeSizes = new ObservableCollection<float>(shoeItemService.FindShoeItemSizes(tempShoeItems));
                    this.Colors = new ObservableCollection<string>(shoeItemService.FindShoeItemColors(tempShoeItems));
                    this.ShoeStyles = new ObservableCollection<string>(shoeService.FindShoeTypes());
                    this.Seasons = new ObservableCollection<string>(this.shoeService.FindSeansons());
                });
            }
        }
        #endregion
        // TODO: Add methods that will be called by the view

        // TODO: Optionally add callback methods for async calls to the service agent
        
        //错误处理
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }
    }
}