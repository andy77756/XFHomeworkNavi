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
    public class BackgroundPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public DelegateCommand GotoMainCommand { get; set; }

        private readonly INavigationService navigationService;

        public BackgroundPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            GotoMainCommand = new DelegateCommand(() =>
            {
                navigationService.NavigateAsync("/NavigationPage/MainPage");
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
