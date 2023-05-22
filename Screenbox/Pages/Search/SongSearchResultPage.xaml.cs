﻿#nullable enable

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using CommunityToolkit.Mvvm.DependencyInjection;
using Screenbox.Core.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Screenbox.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SongSearchResultPage : Page
    {
        internal SearchResultPageViewModel? ViewModel { get; set; }

        internal CommonViewModel Common { get; }

        public SongSearchResultPage()
        {
            this.InitializeComponent();
            Common = Ioc.Default.GetRequiredService<CommonViewModel>();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is SearchResultPageViewModel vm)
            {
                ViewModel = vm;
            }
        }
    }
}
