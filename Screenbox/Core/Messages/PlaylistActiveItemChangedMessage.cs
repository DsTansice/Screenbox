﻿#nullable enable

using CommunityToolkit.Mvvm.Messaging.Messages;
using Screenbox.ViewModels;

namespace Screenbox.Core.Messages
{
    internal class PlaylistActiveItemChangedMessage : ValueChangedMessage<MediaViewModel?>
    {
        public PlaylistActiveItemChangedMessage(MediaViewModel? value) : base(value)
        {
        }
    }
}