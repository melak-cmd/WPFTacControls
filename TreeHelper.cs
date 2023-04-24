using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
using Microsoft.Surface.Presentation.Controls;

namespace AFTERMOUSE
{
    public class TreeHelper
    {
        public static DependencyObject getItemParent(DependencyObject source, Type type)
        {
            DependencyObject parent = source;
            while (parent != null && parent.GetType() != type)
            {
                parent = VisualTreeHelper.GetParent((DependencyObject)parent);
                if (parent == null)
                {
                    return null;
                }
            }
            if (parent.GetType() == type)
            {
                return parent;
            }
            return null;
        }
    }
}
