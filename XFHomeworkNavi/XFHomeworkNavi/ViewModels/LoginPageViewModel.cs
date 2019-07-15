using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFHomeworkNavi.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class LoginPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Account { get; set; }
        public string Password { get; set; }
        public DelegateCommand LoginCommand { get; set; }

        private readonly INavigationService navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            LoginCommand = new DelegateCommand(() =>
            {
                MyInfo myInfo = new MyInfo()
                {
                    MyAccount = Account,
                    MyPassword = Password
                };
                NavigationParameters para = new NavigationParameters();
                para.Add("Info", myInfo);

                navigationService.NavigateAsync("NavigationPage/MainPage",para);
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
