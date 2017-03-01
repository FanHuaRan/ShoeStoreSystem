using System;
using System.Windows;
using System.Threading;
using System.Collections.ObjectModel;

// Toolkit namespace
using SimpleMvvmToolkit;

// Toolkit extension methods
using SimpleMvvmToolkit.ModelExtensions;
using System.Windows.Input;
using System.Windows.Controls;
using ShoeStoreMvvm.Views;
using System.Collections.Generic;
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
        #region Fields
        private UserControl rootView = new SubSystemMenusView();
        private Stack<UserControl> viewStack = new Stack<UserControl>();
        #endregion
        #region Initialization and Cleanup

        // Default ctor
        public MainPageViewModel() { }

        #endregion

        #region Notifications

        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        #endregion

        #region Properties


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
        //切换当前控件
        public void ChangeView(UserControl userControl)
        {
            var mainWindow = App.Current.MainWindow as MainWindow;
            if (mainWindow == null)
            {
                return;
            }
            mainWindow.disPlayTopView.Visibility = userControl == rootView ? Visibility.Hidden : Visibility.Visible;
            mainWindow.ViewContiner.Children.Clear();
            mainWindow.ViewContiner.Children.Add(userControl);
            userControl.Focus();
            viewStack.Push(userControl);
        }
        #endregion

        #region Commands
        public ICommand MinWindowCommand
        {
            get
            {
                return new DelegateCommand<Window>((window) =>
                {
                    window.WindowState = WindowState.Minimized;
                });
            }
        }
        public ICommand MaxWindowCommand
        {
            get
            {
                return new DelegateCommand<Window>((window) =>
                {
                    window.WindowState = WindowState.Maximized;
                });
            }
        }
        public ICommand ReturnCommand
        {
            get
            {
                return new DelegateCommand(() => {
                    viewStack.Pop();
                    if (viewStack.Count == 0)
                    {
                        ChangeView(rootView);
                    }
                    else
                    {
                        UserControl currentControl = viewStack.Pop();
                        ChangeView(rootView);
                    }
                });
            }
        }
        public ICommand LoadWindowCommand
        {
            get
            {
                return new DelegateCommand(() => {
                    ChangeView(rootView);
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