﻿using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace CatalogMobileApp.Styles
{
    /// <summary>
    /// Class helps to reduce repetitive markup, and allows an apps appearance to be more easily changed.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioButtonStyles
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Styles" /> class.
        /// </summary>
        public RadioButtonStyles()
        {
            this.InitializeComponent();
        }
    }
}