// File generated automatically by ReswPlus. https://github.com/DotNetPlus/ReswPlus
// The NuGet package ReswPlusLib is necessary to support Pluralization.
using System;
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Data;

namespace Screenbox.Strings{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("DotNetPlus.ReswPlus", "2.1.3")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public static class Resources {
        private static ResourceLoader _resourceLoader;
        static Resources()
        {
            _resourceLoader = ResourceLoader.GetForViewIndependentUse("Resources");
        }

        #region CompactOverlayToggle
        /// <summary>
        ///   Get the variant version of the string similar to: Picture in picture
        /// </summary>
        public static string CompactOverlayToggle(object variantId)
        {
            try
            {
                return CompactOverlayToggle(Convert.ToInt64(variantId));
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        ///   Get the variant version of the string similar to: Picture in picture
        /// </summary>
        public static string CompactOverlayToggle(long variantId)
        {
            return _resourceLoader.GetString("CompactOverlayToggle_Variant" + variantId);
        }
        #endregion

        #region MuteToggle
        /// <summary>
        ///   Get the variant version of the string similar to: Mute
        /// </summary>
        public static string MuteToggle(object variantId)
        {
            try
            {
                return MuteToggle(Convert.ToInt64(variantId));
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        ///   Get the variant version of the string similar to: Mute
        /// </summary>
        public static string MuteToggle(long variantId)
        {
            return _resourceLoader.GetString("MuteToggle_Variant" + variantId);
        }
        #endregion

        #region FullscreenToggle
        /// <summary>
        ///   Get the variant version of the string similar to: Fullscreen
        /// </summary>
        public static string FullscreenToggle(object variantId)
        {
            try
            {
                return FullscreenToggle(Convert.ToInt64(variantId));
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        ///   Get the variant version of the string similar to: Fullscreen
        /// </summary>
        public static string FullscreenToggle(long variantId)
        {
            return _resourceLoader.GetString("FullscreenToggle_Variant" + variantId);
        }
        #endregion

        #region RepeatMode
        /// <summary>
        ///   Get the variant version of the string similar to: Repeat: Off
        /// </summary>
        public static string RepeatMode(object variantId)
        {
            try
            {
                return RepeatMode(Convert.ToInt64(variantId));
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        ///   Get the variant version of the string similar to: Repeat: Off
        /// </summary>
        public static string RepeatMode(long variantId)
        {
            return _resourceLoader.GetString("RepeatMode_Variant" + variantId);
        }
        #endregion

        #region ItemsSelected
        /// <summary>
        ///   Get the pluralized version of the string similar to: {0} item selected
        /// </summary>
        public static string ItemsSelected(int pluralCount)
        {
            return string.Format(ReswPlusLib.ResourceLoaderExtension.GetPlural(_resourceLoader, "ItemsSelected", (double)pluralCount, false), pluralCount);
        }
        #endregion

        #region ItemsCount
        /// <summary>
        ///   Get the pluralized version of the string similar to: {0} item
        /// </summary>
        public static string ItemsCount(double pluralCount)
        {
            return string.Format(ReswPlusLib.ResourceLoaderExtension.GetPlural(_resourceLoader, "ItemsCount", pluralCount, true), pluralCount);
        }
        #endregion

        #region LocationSpecified
        /// <summary>
        ///   Get the pluralized version of the string similar to: {0} location specified
        /// </summary>
        public static string LocationSpecified(int pluralCount)
        {
            return string.Format(ReswPlusLib.ResourceLoaderExtension.GetPlural(_resourceLoader, "LocationSpecified", (double)pluralCount, false), pluralCount);
        }
        #endregion

        #region ShuffleMode
        /// <summary>
        ///   Get the variant version of the string similar to: Shuffle: Off
        /// </summary>
        public static string ShuffleMode(object variantId)
        {
            try
            {
                return ShuffleMode(Convert.ToInt64(variantId));
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        ///   Get the variant version of the string similar to: Shuffle: Off
        /// </summary>
        public static string ShuffleMode(long variantId)
        {
            return _resourceLoader.GetString("ShuffleMode_Variant" + variantId);
        }
        #endregion

        #region ZoomToFit
        /// <summary>
        ///   Looks up a localized string similar to: Zoom to fit
        /// </summary>
        public static string ZoomToFit
        {
            get
            {
                return _resourceLoader.GetString("ZoomToFit");
            }
        }
        #endregion

        #region FrameSavedNotificationTitle
        /// <summary>
        ///   Looks up a localized string similar to: Frame saved
        /// </summary>
        public static string FrameSavedNotificationTitle
        {
            get
            {
                return _resourceLoader.GetString("FrameSavedNotificationTitle");
            }
        }
        #endregion

        #region SaveCurrentFrame
        /// <summary>
        ///   Looks up a localized string similar to: Save current frame
        /// </summary>
        public static string SaveCurrentFrame
        {
            get
            {
                return _resourceLoader.GetString("SaveCurrentFrame");
            }
        }
        #endregion

        #region Loop
        /// <summary>
        ///   Looks up a localized string similar to: Loop
        /// </summary>
        public static string Loop
        {
            get
            {
                return _resourceLoader.GetString("Loop");
            }
        }
        #endregion

        #region PlaybackSpeed
        /// <summary>
        ///   Looks up a localized string similar to: Playback speed
        /// </summary>
        public static string PlaybackSpeed
        {
            get
            {
                return _resourceLoader.GetString("PlaybackSpeed");
            }
        }
        #endregion

        #region VolumeChangeStatusMessage
        /// <summary>
        ///   Looks up a localized string similar to: Volume {0:F0}%
        /// </summary>
        public static string VolumeChangeStatusMessage(double volume)
        {
            return string.Format(_resourceLoader.GetString("VolumeChangeStatusMessage"), volume);
        }
        #endregion

        #region FailedToSaveFrameNotificationTitle
        /// <summary>
        ///   Looks up a localized string similar to: Failed to save frame
        /// </summary>
        public static string FailedToSaveFrameNotificationTitle
        {
            get
            {
                return _resourceLoader.GetString("FailedToSaveFrameNotificationTitle");
            }
        }
        #endregion

        #region ChapterName
        /// <summary>
        ///   Looks up a localized string similar to: Chapter {0}
        /// </summary>
        public static string ChapterName(int chapter)
        {
            return string.Format(_resourceLoader.GetString("ChapterName"), chapter);
        }
        #endregion

        #region FailedToLoadSubtitleNotificationTitle
        /// <summary>
        ///   Looks up a localized string similar to: Failed to load subtitle
        /// </summary>
        public static string FailedToLoadSubtitleNotificationTitle
        {
            get
            {
                return _resourceLoader.GetString("FailedToLoadSubtitleNotificationTitle");
            }
        }
        #endregion

        #region Back
        /// <summary>
        ///   Looks up a localized string similar to: Back
        /// </summary>
        public static string Back
        {
            get
            {
                return _resourceLoader.GetString("Back");
            }
        }
        #endregion

        #region AudioAndCaption
        /// <summary>
        ///   Looks up a localized string similar to: Audio & captions
        /// </summary>
        public static string AudioAndCaption
        {
            get
            {
                return _resourceLoader.GetString("AudioAndCaption");
            }
        }
        #endregion

        #region Volume
        /// <summary>
        ///   Looks up a localized string similar to: Volume
        /// </summary>
        public static string Volume
        {
            get
            {
                return _resourceLoader.GetString("Volume");
            }
        }
        #endregion

        #region Seek
        /// <summary>
        ///   Looks up a localized string similar to: Seek
        /// </summary>
        public static string Seek
        {
            get
            {
                return _resourceLoader.GetString("Seek");
            }
        }
        #endregion

        #region Next
        /// <summary>
        ///   Looks up a localized string similar to: Next
        /// </summary>
        public static string Next
        {
            get
            {
                return _resourceLoader.GetString("Next");
            }
        }
        #endregion

        #region Previous
        /// <summary>
        ///   Looks up a localized string similar to: Previous
        /// </summary>
        public static string Previous
        {
            get
            {
                return _resourceLoader.GetString("Previous");
            }
        }
        #endregion

        #region Play
        /// <summary>
        ///   Looks up a localized string similar to: Play
        /// </summary>
        public static string Play
        {
            get
            {
                return _resourceLoader.GetString("Play");
            }
        }
        #endregion

        #region Pause
        /// <summary>
        ///   Looks up a localized string similar to: Pause
        /// </summary>
        public static string Pause
        {
            get
            {
                return _resourceLoader.GetString("Pause");
            }
        }
        #endregion

        #region More
        /// <summary>
        ///   Looks up a localized string similar to: More
        /// </summary>
        public static string More
        {
            get
            {
                return _resourceLoader.GetString("More");
            }
        }
        #endregion

        #region PlayQueue
        /// <summary>
        ///   Looks up a localized string similar to: Play queue
        /// </summary>
        public static string PlayQueue
        {
            get
            {
                return _resourceLoader.GetString("PlayQueue");
            }
        }
        #endregion

        #region AddToQueue
        /// <summary>
        ///   Looks up a localized string similar to: Add to queue
        /// </summary>
        public static string AddToQueue
        {
            get
            {
                return _resourceLoader.GetString("AddToQueue");
            }
        }
        #endregion

        #region ClearSelection
        /// <summary>
        ///   Looks up a localized string similar to: Clear selection
        /// </summary>
        public static string ClearSelection
        {
            get
            {
                return _resourceLoader.GetString("ClearSelection");
            }
        }
        #endregion

        #region Remove
        /// <summary>
        ///   Looks up a localized string similar to: Remove
        /// </summary>
        public static string Remove
        {
            get
            {
                return _resourceLoader.GetString("Remove");
            }
        }
        #endregion

        #region PlayNext
        /// <summary>
        ///   Looks up a localized string similar to: Play next
        /// </summary>
        public static string PlayNext
        {
            get
            {
                return _resourceLoader.GetString("PlayNext");
            }
        }
        #endregion

        #region MoveUp
        /// <summary>
        ///   Looks up a localized string similar to: Move up
        /// </summary>
        public static string MoveUp
        {
            get
            {
                return _resourceLoader.GetString("MoveUp");
            }
        }
        #endregion

        #region MoveDown
        /// <summary>
        ///   Looks up a localized string similar to: Move down
        /// </summary>
        public static string MoveDown
        {
            get
            {
                return _resourceLoader.GetString("MoveDown");
            }
        }
        #endregion

        #region IsPlaying
        /// <summary>
        ///   Looks up a localized string similar to: Is playing
        /// </summary>
        public static string IsPlaying
        {
            get
            {
                return _resourceLoader.GetString("IsPlaying");
            }
        }
        #endregion

        #region Videos
        /// <summary>
        ///   Looks up a localized string similar to: Videos
        /// </summary>
        public static string Videos
        {
            get
            {
                return _resourceLoader.GetString("Videos");
            }
        }
        #endregion

        #region EmptyFolder
        /// <summary>
        ///   Looks up a localized string similar to: This folder is empty
        /// </summary>
        public static string EmptyFolder
        {
            get
            {
                return _resourceLoader.GetString("EmptyFolder");
            }
        }
        #endregion

        #region RestoreView
        /// <summary>
        ///   Looks up a localized string similar to: Restore video view
        /// </summary>
        public static string RestoreView
        {
            get
            {
                return _resourceLoader.GetString("RestoreView");
            }
        }
        #endregion

        #region Cast
        /// <summary>
        ///   Looks up a localized string similar to: Cast
        /// </summary>
        public static string Cast
        {
            get
            {
                return _resourceLoader.GetString("Cast");
            }
        }
        #endregion

        #region StopCast
        /// <summary>
        ///   Looks up a localized string similar to: Stop casting
        /// </summary>
        public static string StopCast
        {
            get
            {
                return _resourceLoader.GetString("StopCast");
            }
        }
        #endregion

        #region CastingTo
        /// <summary>
        ///   Looks up a localized string similar to: Casting to
        /// </summary>
        public static string CastingTo
        {
            get
            {
                return _resourceLoader.GetString("CastingTo");
            }
        }
        #endregion

        #region CastToDevice
        /// <summary>
        ///   Looks up a localized string similar to: Cast to a device
        /// </summary>
        public static string CastToDevice
        {
            get
            {
                return _resourceLoader.GetString("CastToDevice");
            }
        }
        #endregion

        #region Disable
        /// <summary>
        ///   Looks up a localized string similar to: Disable
        /// </summary>
        public static string Disable
        {
            get
            {
                return _resourceLoader.GetString("Disable");
            }
        }
        #endregion

        #region Music
        /// <summary>
        ///   Looks up a localized string similar to: Music
        /// </summary>
        public static string Music
        {
            get
            {
                return _resourceLoader.GetString("Music");
            }
        }
        #endregion

        #region ShuffleAndPlay
        /// <summary>
        ///   Looks up a localized string similar to: Shuffle and play
        /// </summary>
        public static string ShuffleAndPlay
        {
            get
            {
                return _resourceLoader.GetString("ShuffleAndPlay");
            }
        }
        #endregion

        #region UnknownArtist
        /// <summary>
        ///   Looks up a localized string similar to: Unknown artist
        /// </summary>
        public static string UnknownArtist
        {
            get
            {
                return _resourceLoader.GetString("UnknownArtist");
            }
        }
        #endregion

        #region UnknownAlbum
        /// <summary>
        ///   Looks up a localized string similar to: Unknown album
        /// </summary>
        public static string UnknownAlbum
        {
            get
            {
                return _resourceLoader.GetString("UnknownAlbum");
            }
        }
        #endregion

        #region UnknownGenre
        /// <summary>
        ///   Looks up a localized string similar to: Unknown genre
        /// </summary>
        public static string UnknownGenre
        {
            get
            {
                return _resourceLoader.GetString("UnknownGenre");
            }
        }
        #endregion

        #region AddFolder
        /// <summary>
        ///   Looks up a localized string similar to: Add folder
        /// </summary>
        public static string AddFolder
        {
            get
            {
                return _resourceLoader.GetString("AddFolder");
            }
        }
        #endregion

        #region Clear
        /// <summary>
        ///   Looks up a localized string similar to: Clear
        /// </summary>
        public static string Clear
        {
            get
            {
                return _resourceLoader.GetString("Clear");
            }
        }
        #endregion

        #region Home
        /// <summary>
        ///   Looks up a localized string similar to: Home
        /// </summary>
        public static string Home
        {
            get
            {
                return _resourceLoader.GetString("Home");
            }
        }
        #endregion

        #region Multiselect
        /// <summary>
        ///   Looks up a localized string similar to: Select multiple
        /// </summary>
        public static string Multiselect
        {
            get
            {
                return _resourceLoader.GetString("Multiselect");
            }
        }
        #endregion

        #region NoMusicPanelHeader
        /// <summary>
        ///   Looks up a localized string similar to: We couldn't find any music
        /// </summary>
        public static string NoMusicPanelHeader
        {
            get
            {
                return _resourceLoader.GetString("NoMusicPanelHeader");
            }
        }
        #endregion

        #region NoMusicPanelSubtext
        /// <summary>
        ///   Looks up a localized string similar to: Your music library doesn't contain any music content.
        /// </summary>
        public static string NoMusicPanelSubtext
        {
            get
            {
                return _resourceLoader.GetString("NoMusicPanelSubtext");
            }
        }
        #endregion

        #region OpenFiles
        /// <summary>
        ///   Looks up a localized string similar to: Open file(s)
        /// </summary>
        public static string OpenFiles
        {
            get
            {
                return _resourceLoader.GetString("OpenFiles");
            }
        }
        #endregion

        #region SearchBoxPlaceholderText
        /// <summary>
        ///   Looks up a localized string similar to: Search
        /// </summary>
        public static string SearchBoxPlaceholderText
        {
            get
            {
                return _resourceLoader.GetString("SearchBoxPlaceholderText");
            }
        }
        #endregion

        #region Settings
        /// <summary>
        ///   Looks up a localized string similar to: Settings
        /// </summary>
        public static string Settings
        {
            get
            {
                return _resourceLoader.GetString("Settings");
            }
        }
        #endregion

        #region WelcomePanelHeader
        /// <summary>
        ///   Looks up a localized string similar to: Welcome to Screenbox
        /// </summary>
        public static string WelcomePanelHeader
        {
            get
            {
                return _resourceLoader.GetString("WelcomePanelHeader");
            }
        }
        #endregion

        #region WelcomePanelSubtext
        /// <summary>
        ///   Looks up a localized string similar to: Let's start playing some of your media content to get things going.
        /// </summary>
        public static string WelcomePanelSubtext
        {
            get
            {
                return _resourceLoader.GetString("WelcomePanelSubtext");
            }
        }
        #endregion

        #region Properties
        /// <summary>
        ///   Looks up a localized string similar to: Properties
        /// </summary>
        public static string Properties
        {
            get
            {
                return _resourceLoader.GetString("Properties");
            }
        }
        #endregion

        #region Close
        /// <summary>
        ///   Looks up a localized string similar to: Close
        /// </summary>
        public static string Close
        {
            get
            {
                return _resourceLoader.GetString("Close");
            }
        }
        #endregion

        #region OpenFileLocation
        /// <summary>
        ///   Looks up a localized string similar to: Open file location
        /// </summary>
        public static string OpenFileLocation
        {
            get
            {
                return _resourceLoader.GetString("OpenFileLocation");
            }
        }
        #endregion

        #region PropertyAlbum
        /// <summary>
        ///   Looks up a localized string similar to: Album
        /// </summary>
        public static string PropertyAlbum
        {
            get
            {
                return _resourceLoader.GetString("PropertyAlbum");
            }
        }
        #endregion

        #region PropertyAlbumArtist
        /// <summary>
        ///   Looks up a localized string similar to: Album artist
        /// </summary>
        public static string PropertyAlbumArtist
        {
            get
            {
                return _resourceLoader.GetString("PropertyAlbumArtist");
            }
        }
        #endregion

        #region PropertyBitRate
        /// <summary>
        ///   Looks up a localized string similar to: Bit rate
        /// </summary>
        public static string PropertyBitRate
        {
            get
            {
                return _resourceLoader.GetString("PropertyBitRate");
            }
        }
        #endregion

        #region PropertyContentType
        /// <summary>
        ///   Looks up a localized string similar to: Content type
        /// </summary>
        public static string PropertyContentType
        {
            get
            {
                return _resourceLoader.GetString("PropertyContentType");
            }
        }
        #endregion

        #region PropertyContributingArtists
        /// <summary>
        ///   Looks up a localized string similar to: Contributing artists
        /// </summary>
        public static string PropertyContributingArtists
        {
            get
            {
                return _resourceLoader.GetString("PropertyContributingArtists");
            }
        }
        #endregion

        #region PropertyFileLocation
        /// <summary>
        ///   Looks up a localized string similar to: File location
        /// </summary>
        public static string PropertyFileLocation
        {
            get
            {
                return _resourceLoader.GetString("PropertyFileLocation");
            }
        }
        #endregion

        #region PropertyFileType
        /// <summary>
        ///   Looks up a localized string similar to: File type
        /// </summary>
        public static string PropertyFileType
        {
            get
            {
                return _resourceLoader.GetString("PropertyFileType");
            }
        }
        #endregion

        #region PropertyGenre
        /// <summary>
        ///   Looks up a localized string similar to: Genre
        /// </summary>
        public static string PropertyGenre
        {
            get
            {
                return _resourceLoader.GetString("PropertyGenre");
            }
        }
        #endregion

        #region PropertyLastModified
        /// <summary>
        ///   Looks up a localized string similar to: Last modified
        /// </summary>
        public static string PropertyLastModified
        {
            get
            {
                return _resourceLoader.GetString("PropertyLastModified");
            }
        }
        #endregion

        #region PropertyLength
        /// <summary>
        ///   Looks up a localized string similar to: Length
        /// </summary>
        public static string PropertyLength
        {
            get
            {
                return _resourceLoader.GetString("PropertyLength");
            }
        }
        #endregion

        #region PropertyProducers
        /// <summary>
        ///   Looks up a localized string similar to: Producers
        /// </summary>
        public static string PropertyProducers
        {
            get
            {
                return _resourceLoader.GetString("PropertyProducers");
            }
        }
        #endregion

        #region PropertyResolution
        /// <summary>
        ///   Looks up a localized string similar to: Resolution
        /// </summary>
        public static string PropertyResolution
        {
            get
            {
                return _resourceLoader.GetString("PropertyResolution");
            }
        }
        #endregion

        #region PropertySize
        /// <summary>
        ///   Looks up a localized string similar to: Size
        /// </summary>
        public static string PropertySize
        {
            get
            {
                return _resourceLoader.GetString("PropertySize");
            }
        }
        #endregion

        #region PropertySubtitle
        /// <summary>
        ///   Looks up a localized string similar to: Subtitle
        /// </summary>
        public static string PropertySubtitle
        {
            get
            {
                return _resourceLoader.GetString("PropertySubtitle");
            }
        }
        #endregion

        #region PropertyTitle
        /// <summary>
        ///   Looks up a localized string similar to: Title
        /// </summary>
        public static string PropertyTitle
        {
            get
            {
                return _resourceLoader.GetString("PropertyTitle");
            }
        }
        #endregion

        #region PropertyTrack
        /// <summary>
        ///   Looks up a localized string similar to: Track
        /// </summary>
        public static string PropertyTrack
        {
            get
            {
                return _resourceLoader.GetString("PropertyTrack");
            }
        }
        #endregion

        #region PropertyWriters
        /// <summary>
        ///   Looks up a localized string similar to: Writers
        /// </summary>
        public static string PropertyWriters
        {
            get
            {
                return _resourceLoader.GetString("PropertyWriters");
            }
        }
        #endregion

        #region PropertyYear
        /// <summary>
        ///   Looks up a localized string similar to: Year
        /// </summary>
        public static string PropertyYear
        {
            get
            {
                return _resourceLoader.GetString("PropertyYear");
            }
        }
        #endregion

        #region CustomPlaybackSpeed
        /// <summary>
        ///   Looks up a localized string similar to: Custom
        /// </summary>
        public static string CustomPlaybackSpeed
        {
            get
            {
                return _resourceLoader.GetString("CustomPlaybackSpeed");
            }
        }
        #endregion

        #region Network
        /// <summary>
        ///   Looks up a localized string similar to: Network
        /// </summary>
        public static string Network
        {
            get
            {
                return _resourceLoader.GetString("Network");
            }
        }
        #endregion

        #region NoNetworkDrivePanelHeader
        /// <summary>
        ///   Looks up a localized string similar to: No network device available
        /// </summary>
        public static string NoNetworkDrivePanelHeader
        {
            get
            {
                return _resourceLoader.GetString("NoNetworkDrivePanelHeader");
            }
        }
        #endregion

        #region NoNetworkDrivePanelSubtext
        /// <summary>
        ///   Looks up a localized string similar to: Can't find your media? Make sure your network device is paired in the Windows Settings.
        /// </summary>
        public static string NoNetworkDrivePanelSubtext
        {
            get
            {
                return _resourceLoader.GetString("NoNetworkDrivePanelSubtext");
            }
        }
        #endregion

        #region Recent
        /// <summary>
        ///   Looks up a localized string similar to: Recent
        /// </summary>
        public static string Recent
        {
            get
            {
                return _resourceLoader.GetString("Recent");
            }
        }
        #endregion

        #region VideoSettings
        /// <summary>
        ///   Looks up a localized string similar to: Video settings
        /// </summary>
        public static string VideoSettings
        {
            get
            {
                return _resourceLoader.GetString("VideoSettings");
            }
        }
        #endregion

        #region Open
        /// <summary>
        ///   Looks up a localized string similar to: Open
        /// </summary>
        public static string Open
        {
            get
            {
                return _resourceLoader.GetString("Open");
            }
        }
        #endregion

        #region ResumePositionNotificationTitle
        /// <summary>
        ///   Looks up a localized string similar to: Resume where you left off
        /// </summary>
        public static string ResumePositionNotificationTitle
        {
            get
            {
                return _resourceLoader.GetString("ResumePositionNotificationTitle");
            }
        }
        #endregion

        #region GoToPosition
        /// <summary>
        ///   Looks up a localized string similar to: Go to {0}
        /// </summary>
        public static string GoToPosition(string position)
        {
            return string.Format(_resourceLoader.GetString("GoToPosition"), position);
        }
        #endregion
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("DotNetPlus.ReswPlus", "2.1.3")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [MarkupExtensionReturnType(ReturnType = typeof(string))]
    public class ResourcesExtension: MarkupExtension
    {
        public enum KeyEnum
        {
            __Undefined = 0,
            CompactOverlayToggle,
            MuteToggle,
            FullscreenToggle,
            RepeatMode,
            ItemsSelected,
            ItemsCount,
            LocationSpecified,
            ShuffleMode,
            ZoomToFit,
            FrameSavedNotificationTitle,
            SaveCurrentFrame,
            Loop,
            PlaybackSpeed,
            VolumeChangeStatusMessage,
            FailedToSaveFrameNotificationTitle,
            ChapterName,
            FailedToLoadSubtitleNotificationTitle,
            Back,
            AudioAndCaption,
            Volume,
            Seek,
            Next,
            Previous,
            Play,
            Pause,
            More,
            PlayQueue,
            AddToQueue,
            ClearSelection,
            Remove,
            PlayNext,
            MoveUp,
            MoveDown,
            IsPlaying,
            Videos,
            EmptyFolder,
            RestoreView,
            Cast,
            StopCast,
            CastingTo,
            CastToDevice,
            Disable,
            Music,
            ShuffleAndPlay,
            UnknownArtist,
            UnknownAlbum,
            UnknownGenre,
            AddFolder,
            Clear,
            Home,
            Multiselect,
            NoMusicPanelHeader,
            NoMusicPanelSubtext,
            OpenFiles,
            SearchBoxPlaceholderText,
            Settings,
            WelcomePanelHeader,
            WelcomePanelSubtext,
            Properties,
            Close,
            OpenFileLocation,
            PropertyAlbum,
            PropertyAlbumArtist,
            PropertyBitRate,
            PropertyContentType,
            PropertyContributingArtists,
            PropertyFileLocation,
            PropertyFileType,
            PropertyGenre,
            PropertyLastModified,
            PropertyLength,
            PropertyProducers,
            PropertyResolution,
            PropertySize,
            PropertySubtitle,
            PropertyTitle,
            PropertyTrack,
            PropertyWriters,
            PropertyYear,
            CustomPlaybackSpeed,
            Network,
            NoNetworkDrivePanelHeader,
            NoNetworkDrivePanelSubtext,
            Recent,
            VideoSettings,
            Open,
            ResumePositionNotificationTitle,
            GoToPosition,
        }

        private static ResourceLoader _resourceLoader;
        static ResourcesExtension()
        {
            _resourceLoader = ResourceLoader.GetForViewIndependentUse("Resources");
        }
        public KeyEnum Key { get; set;}
        public IValueConverter Converter { get; set;}
        public object ConverterParameter { get; set;}
        protected override object ProvideValue()
        {
            string res;
            if(Key == KeyEnum.__Undefined)
            {
                res = "";
            }
            else
            {
                res = _resourceLoader.GetString(Key.ToString());
            }
            return Converter == null ? res : Converter.Convert(res, typeof(String), ConverterParameter, null);
        }
    }
} //Screenbox.Strings
