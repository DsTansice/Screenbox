﻿#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Microsoft.Extensions.DependencyInjection;
using Screenbox.ViewModels;
using NavigationView = Microsoft.UI.Xaml.Controls.NavigationView;
using NavigationViewSelectionChangedEventArgs = Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Screenbox.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MusicPage : Page, IContentFrame
    {
        public object? FrameContent => ContentFrame;
        public Type ContentSourcePageType => ContentFrame.SourcePageType;
        public bool CanGoBack => ContentFrame.CanGoBack;

        internal MusicPageViewModel ViewModel => (MusicPageViewModel)DataContext;

        internal CommonViewModel Common { get; }

        private readonly Dictionary<string, Type> _pages;

        public MusicPage()
        {
            this.InitializeComponent();
            DataContext = App.Services.GetRequiredService<MusicPageViewModel>();
            Common = App.Services.GetRequiredService<CommonViewModel>();

            _pages = new Dictionary<string, Type>
            {
                { "songs", typeof(SongsPage) },
                { "artists", typeof(ArtistsPage) },
                { "albums", typeof(AlbumsPage) }
            };

            ViewModel.PropertyChanged += ViewModelOnPropertyChanged;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            LibraryNavView.SelectedItem = LibraryNavView.MenuItems[0];
            if (!ViewModel.IsLoaded)
            {
                await ViewModel.FetchSongsAsync();
            }

            VisualStateManager.GoToState(this, ViewModel.Count > 0 ? "Normal" : "NoMusic", false);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            ViewModel.PropertyChanged -= ViewModelOnPropertyChanged;
        }

        public void GoBack()
        {
            ContentFrame.GoBack();
        }

        public void NavigateContent(Type pageType, object? parameter)
        {
            ContentFrame.Navigate(pageType, parameter);
        }

        private void ViewModelOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ViewModel.IsLoading) && !ViewModel.IsLoading)
            {
                VisualStateManager.GoToState(this, ViewModel.Count > 0 ? "Normal" : "NoMusic", false);
            }
        }

        private void LibraryNavView_OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItemContainer != null)
            {
                string navItemTag = args.SelectedItemContainer.Tag.ToString();
                NavView_Navigate(navItemTag);
            }
        }

        private void NavView_Navigate(string navItemTag)
        {
            Type pageType = _pages.GetValueOrDefault(navItemTag);
            // Get the page type before navigation so you can prevent duplicate
            // entries in the backstack.
            Type? preNavPageType = ContentFrame.CurrentSourcePageType;

            // Only navigate if the selected page isn't currently loaded.
            if (!(pageType is null) && !Type.Equals(preNavPageType, pageType))
            {
                ContentFrame.Navigate(pageType, null, new SuppressNavigationTransitionInfo());
            }
        }

        private void ContentFrame_OnNavigated(object sender, NavigationEventArgs e)
        {
            if (e.SourcePageType != null)
            {
                KeyValuePair<string, Type> item = _pages.FirstOrDefault(p => p.Value == e.SourcePageType);

                Microsoft.UI.Xaml.Controls.NavigationViewItem? selectedItem = LibraryNavView.MenuItems
                    .OfType<Microsoft.UI.Xaml.Controls.NavigationViewItem>()
                    .FirstOrDefault(n => n.Tag.Equals(item.Key));

                LibraryNavView.SelectedItem = selectedItem;
            }
        }
    }
}
