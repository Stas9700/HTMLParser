using HTML_Parser.MVVM_Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace HTML_Parser.VIEWMODEL
{
    public class MainWindowViewModel: Model
    {
        public MainWindowViewModel()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://xn--86-plciall0d.xn--p1ai/");
            var text = request.GetResponse();
            string s = new StreamReader(text.GetResponseStream(),Encoding.UTF8).ReadToEnd();
            HTML = (s.Split("<a",StringSplitOptions.None).Count()-1).ToString();
        }

        #region variables
        private string _html;
        #endregion

        #region Properties
        public string HTML
        {
            get => _html;
            set
            {
                _html = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
