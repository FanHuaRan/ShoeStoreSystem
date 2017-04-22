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
using System.Diagnostics;
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
        private bool isMenCheck = false;
        private bool isWoMenCheck = false;
        private bool isAllMenCheck = true;
        private float? minPrice = null;
        private float? maxPrice = null;
        private bool isSellCheck = false;
        private bool noSellCheck = false;
        private bool isAllSellCheck = true;
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
        public bool IsMenCheck
        {
            get { return isMenCheck; }
            set
            {
                if (isMenCheck != value)
                {
                    isMenCheck = value;
                    NotifyPropertyChanged(p => p.IsMenCheck);
                }
            }
        }
        public bool IsWoMenCheck
        {
            get { return isWoMenCheck; }
            set
            {
                if (isWoMenCheck != value)
                {
                    isWoMenCheck = value;
                    NotifyPropertyChanged(p => p.IsWoMenCheck);
                }
            }
        }
        public bool IsAllMenCheck
        {
            get { return isAllMenCheck; }
            set
            {
                if (isAllMenCheck != value)
                {
                    isAllMenCheck = value;
                    NotifyPropertyChanged(p => p.isAllMenCheck);
                }
            }
        }
        public float? MinPrice
        {
            get { return minPrice; }
            set
            {
                if (minPrice != value)
                {
                    minPrice = value;
                    NotifyPropertyChanged(p => p.MinPrice);
                }
            }
        }
        public float? MaxPrice
        {
            get { return maxPrice; }
            set
            {
                if (maxPrice != value)
                {
                    maxPrice = value;
                    NotifyPropertyChanged(p => p.MaxPrice);
                }
            }
        }
        public bool IsSellCheck
        {
            get { return isSellCheck; }
            set
            {
                if (isSellCheck != value)
                {
                    isSellCheck = value;
                    NotifyPropertyChanged(p => p.IsSellCheck);
                }
            }
        }
        public bool NoSellCheck
        {
            get { return noSellCheck; }
            set
            {
                if (noSellCheck != value)
                {
                    noSellCheck = value;
                    NotifyPropertyChanged(p => p.NoSellCheck);
                }
            }
        }
        public bool IsAllSellCheck
        {
            get { return isAllSellCheck; }
            set
            {
                if (isAllSellCheck != value)
                {
                    isAllSellCheck = value;
                    NotifyPropertyChanged(p => p.IsAllSellCheck);
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
                    this.ShoeItems = new ObservableCollection<ShoeItem>(shoeItemQueryService.FindAllShoeItems());
                    this.ShoeSizes = new ObservableCollection<float>(shoeItemService.FindShoeItemSizes());
                    this.Colors = new ObservableCollection<string>(shoeItemService.FindShoeItemColors());
                    this.ShoeStyles = new ObservableCollection<string>(shoeService.FindShoeTypes());
                    this.Seasons = new ObservableCollection<string>(this.shoeService.FindSeasons());
                });
            }
        }
        public ICommand SearchCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var conditions = new List<Func<ShoeItem, bool>>();
                    if (!string.IsNullOrEmpty(SelectShoeStyle))
                    {
                        conditions.Add(p => p.Shoe.ShoeType == SelectShoeStyle);
                    }
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