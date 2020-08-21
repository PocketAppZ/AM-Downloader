﻿using AMDownloader.ObjectModel;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace AMDownloader
{
    class ProgressBarValueColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DownloadStatus status = (DownloadStatus)value;
            switch (status)
            {
                case DownloadStatus.Finished:
                case DownloadStatus.Error:
                    return Application.Current.Resources["ProgressBarValueLightColor"];
            }
            return Application.Current.Resources["ProgressBarValueDarkColor"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}