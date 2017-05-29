﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using XBee.Frames.AtCommands;
using XBee.Utility.ViewModels;

namespace XBee.Utility
{
    public class HardwareVersionTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CellularDataTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item == null)
            {
                return null;
            }

            var hardware = (IHardware) item;

            switch (hardware.HardwareVersion)
            {
                case HardwareVersion.XBeeCellular:
                {
                    return CellularDataTemplate;
                }
                default:
                {
                    return base.SelectTemplateCore(item, container);
                }
            }
        }
    }
}
