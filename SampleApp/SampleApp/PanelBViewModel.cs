﻿using FreshMvvm;
using PropertyChanged;

namespace SampleApp
{
    [AddINotifyPropertyChangedInterface]
    public class PanelBViewModel 
    {
        public bool IsVisible { get; set; }
    }
}
