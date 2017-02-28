using System;
using System.Windows;
using System.Threading;
using System.Collections.ObjectModel;

// Toolkit namespace
using SimpleMvvmToolkit;

// Toolkit extension methods
using SimpleMvvmToolkit.ModelExtensions;
using System.Windows.Input;

namespace ShoeStoreMvvm
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvmprop</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// </summary>
    public class MainPageViewModel : ViewModelBase<MainPageViewModel>
    {
        #region Initialization and Cleanup

        // Default ctor
        public MainPageViewModel() { }

        #endregion

        #region Notifications

        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        #endregion

        #region Properties

        // Add properties using the mvvmprop code snippet

        private string bannerText = "Hello Simple MVVM Toolkit";
        public string BannerText
        {
            get
            {
                if (this.IsInDesignMode()) return "Banner";
                return bannerText;
            }
            set
            {
                bannerText = value;
                NotifyPropertyChanged(m => m.BannerText);
            }
        }

        #endregion

        #region Methods

        // TODO: Add methods that will be called by the view
        public void Exit()
        {
            if (MessageBox.Show("确定退出程序", "提示", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                Environment.Exit(0);
            }
        }
        #endregion

        #region Commands
        public ICommand minWindowCommand
        {
            get
            {
                return new DelegateCommand<Window>((window) =>
                {
                    window.WindowState = WindowState.Minimized;
                });
            }
        }
        public ICommand maxWindowCommand
        {
            get
            {
                return new DelegateCommand<Window>((window) =>
                {
                    window.WindowState = WindowState.Maximized;
                });
            }
        }
        #endregion

        #region Completion Callbacks

        // TODO: Optionally add callback methods for async calls to the service agent

        #endregion

        #region Helpers

        // Helper method to notify View of an error
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }

        #endregion
    }
}