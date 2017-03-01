using System;
using System.Windows;
using System.Threading;
using System.Collections.ObjectModel;

// Toolkit namespace
using SimpleMvvmToolkit;
using ShoeStoreMvvm.Models;
using ShoeStoreMvvm.Services;
using System.Windows.Input;
using System.Windows.Controls;

namespace ShoeStoreMvvm.ViewModels
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvmprop</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// </summary>
    public class SubSystemMenusViewModel : ViewModelBase<SubSystemMenusViewModel>
    {
        #region Fields
        private ObservableCollection<ModuleClass> moduleList;
        private IModuleServiceAgent moduleServiceAgent;
        #endregion
        public SubSystemMenusViewModel() { }
        public SubSystemMenusViewModel(IModuleServiceAgent moduleServiceAgent)
        {
            this.moduleServiceAgent = moduleServiceAgent;
            this.ModuleList = moduleServiceAgent.GetModuleList();
        }
        #region Propertys
        public ObservableCollection<ModuleClass> ModuleList
        {
            get { return this.moduleList; }
            set { this.moduleList = value; NotifyPropertyChanged(p => p.ModuleList); }
        }
        #endregion
        #region Commands
        public ICommand SelectCommand
        {
            get
            {
                return new DelegateCommand<ListBox>((listbox) =>
                {
                    if (listbox.SelectedItem == null)
                    {
                        return;
                    }
                    var module = listbox.SelectedItem as ModuleClass;
                   var userControl= Activator.CreateInstance( module.Type) as UserControl;
                   ChangeView(userControl);
                });
            }
        }
        #endregion
        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        // TODO: Add properties using the mvvmprop code snippet

        // TODO: Add methods that will be called by the view
        private void ChangeView(UserControl control)
        {
            var window = App.Current.MainWindow as MainWindow;
            if (window == null)
            {
                return;
            }
            (window.DataContext as MainPageViewModel).ChangeView(control);
        }
        // TODO: Optionally add callback methods for async calls to the service agent
        
        // Helper method to notify View of an error
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }
    }
}