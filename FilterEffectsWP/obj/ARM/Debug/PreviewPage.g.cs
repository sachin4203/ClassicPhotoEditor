﻿#pragma checksum "C:\wallpaper_app\filter-effects-2.0\FilterEffectsWP80\FilterEffectsWP\PreviewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "36E02F36E95DB1CD806C282E7A18F40F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FilterEffects {
    
    
    public partial class PreviewPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard ShowControlsAnimationStoryBoard;
        
        internal System.Windows.Media.Animation.DoubleAnimation ShowControlsAnimation;
        
        internal System.Windows.Media.Animation.Storyboard HideControlsAnimationStoryBoard;
        
        internal System.Windows.Media.Animation.DoubleAnimation HideControlsAnimation;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot FilterPreviewPivot;
        
        internal System.Windows.Controls.Grid HintText;
        
        internal System.Windows.Shapes.Rectangle HintTextBackground;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton SaveButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FilterEffects;component/PreviewPage.xaml", System.UriKind.Relative));
            this.ShowControlsAnimationStoryBoard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("ShowControlsAnimationStoryBoard")));
            this.ShowControlsAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("ShowControlsAnimation")));
            this.HideControlsAnimationStoryBoard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("HideControlsAnimationStoryBoard")));
            this.HideControlsAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("HideControlsAnimation")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.FilterPreviewPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("FilterPreviewPivot")));
            this.HintText = ((System.Windows.Controls.Grid)(this.FindName("HintText")));
            this.HintTextBackground = ((System.Windows.Shapes.Rectangle)(this.FindName("HintTextBackground")));
            this.SaveButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("SaveButton")));
        }
    }
}

