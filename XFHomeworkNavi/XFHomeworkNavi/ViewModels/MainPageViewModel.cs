using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFHomeworkNavi.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public DelegateCommand GotoMainCommand { get; set; }
        public DelegateCommand GotoInfoCommand { get; set; }
        public DelegateCommand GotoBackgroundCommand { get; set; }
        public DelegateCommand LogoutCommand { get; set; }

        private readonly INavigationService navigationService;
        private readonly IPageDialogService dialogService;

        public MainPageViewModel(INavigationService navigationService,IPageDialogService dialogService)
        {
            this.navigationService = navigationService;
            this.dialogService = dialogService;
            LogoutCommand = new DelegateCommand(async() =>
            {
                bool result = await dialogService.DisplayAlertAsync("警告",
                    "請問確定要登出嗎?",
                    "是",
                    "否");
                if (result == true)
                {
                    await navigationService.NavigateAsync("/LoginPage");
                }
                
            });
            GotoBackgroundCommand = new DelegateCommand(() =>
            {
                navigationService.NavigateAsync("SystemPage/PreferPage/BackgroundPage");
            });
            GotoInfoCommand = new DelegateCommand(() =>
            {
                navigationService.NavigateAsync("InfoPage");
            });
            GotoMainCommand = new DelegateCommand(() =>
            {
                
            });

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }

    }
}
