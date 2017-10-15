using System;
using System.Collections.Generic;
using System.Text;
using SegmentDownloader.Core.Extensions;
using System.Windows.Forms;
using SegmentDownloader.Common.UI.Extensions;
using SegmentDownloader.Extension.AntiVirus.UI;

namespace SegmentDownloader.Extension.AntiVirus
{
    public class AntiVirusUIExtension: IUIExtension
    {
        #region IUIExtension Members

        public Control[] CreateSettingsView()
        {
            return new Control[] { new AVOptions() }; 
        }

        public void PersistSettings(Control[] settingsView)
        {
            AVOptions options = (AVOptions)settingsView[0];
            Settings.Default.AVParameter = options.AVParameter;
            Settings.Default.CheckFileWithAV = options.CheckFileWithAV;
            Settings.Default.FileTypes = options.FileTypes;
            Settings.Default.AVFileName = options.AVFileName;
            Settings.Default.Save();
        }

        #endregion
    }
}
