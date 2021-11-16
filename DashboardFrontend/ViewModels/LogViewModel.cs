﻿using DashboardBackend;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static Model.LogMessage;

namespace DashboardFrontend.ViewModels
{
    public class LogViewModel : BaseViewModel
    {
        public LogViewModel(Log log)
        {
            _log = log;
            log.Messages = DataUtilities.GetLogMessages().TakeLast(1000).ToList();
            UpdateCounters();
            UpdateData();
        }

        private Log _log;
        /*        private List<LogMessage> _messages = new();
        */
        private ObservableCollection<LogMessage> _messages;
        public ObservableCollection<LogMessage> Messages { 
            get 
            {
                return _messages;
            } 
            set 
            { 
                _messages = value;
                OnPropertyChanged(nameof(Messages));
            } 
        }

        private int _infoCount;
        public int InfoCount
        {
            get => _infoCount;
            set
            {
                _infoCount = value;
                OnPropertyChanged(nameof(InfoCount));
            }
        }
        private int _warnCount;
        public int WarnCount
        {
            get => _warnCount;
            set
            {
                _warnCount = value;
                OnPropertyChanged(nameof(WarnCount));
            }
        }
        private int _errorCount;
        public int ErrorCount
        {
            get => _errorCount;
            set
            {
                _errorCount = value;
                OnPropertyChanged(nameof(ErrorCount));
            }
        }
        private int _fatalCount;
        public int FatalCount
        {
            get => _fatalCount;
            set
            {
                _fatalCount = value;
                OnPropertyChanged(nameof(FatalCount));
            }
        }
        private int _validationCount;
        public int ValidationCount
        {
            get => _validationCount;
            set
            {
                _validationCount = value;
                OnPropertyChanged(nameof(ValidationCount));
            }
        }
        private bool _showInfo = true;
        public bool ShowInfo
        {
            get => _showInfo;
            set
            {
                _showInfo = value;
                OnPropertyChanged(nameof(ShowInfo));
            }
        }
        private bool _showWarn = true;
        public bool ShowWarn
        {
            get => _showWarn;
            set
            {
                _showWarn = value;
                OnPropertyChanged(nameof(ShowWarn));
            }
        }
        private bool _showError = true;
        public bool ShowError
        {
            get => _showError;
            set
            {
                _showError = value;
                OnPropertyChanged(nameof(ShowError));
            }
        }
        private bool _showFatal = true;
        public bool ShowFatal
        {
            get => _showFatal;
            set
            {
                _showFatal = value;
                OnPropertyChanged(nameof(ShowFatal));
            }
        }
        private bool _showValidation = true;
        public bool ShowValidation
        {
            get => _showValidation;
            set
            {
                _showValidation = value;
                OnPropertyChanged(nameof(ShowValidation));
            }
        }

        /// <summary>
        /// Updates the actual data of the view-model, for use whenever a query has been executed and parsed
        /// </summary>
        public void UpdateData()
        {
            Messages = new(_log.Messages);
        }

        /// <summary>
        /// Increments the counter property that corresponds to the LogMessageType of the given LogMessage
        /// </summary>
        /// <param name="msg">LogMessage whose type counter should be updated</param>
        private void UpdateCounters()
        {
            foreach(var msg in _log.Messages)
            switch (msg.Type)
            {
                case LogMessageType.INFO:
                    InfoCount++;
                    break;
                case LogMessageType.WARNING:
                    WarnCount++;
                    break;
                case LogMessageType.ERROR:
                    ErrorCount++;
                    break;
                case LogMessageType.FATAL:
                    FatalCount++;
                    break;
                case LogMessageType.VALIDATION:
                    ValidationCount++;
                    break;
                default:
                    break;
            }
        }
    }
}
