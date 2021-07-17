using System;
using System.Collections.Generic;
using System.Text;

namespace donNetTraining
{
    class Stopwatch
    {
        private bool _isStarted { get; set; }
        private bool _isStop { get; set; }
        
        private DateTime _startDateTime;
        private DateTime _stopDateTime;

        public Stopwatch()
        {
            _isStarted = false;
            _isStop = false;
        }

        public void Start()
        {
            if (_isStarted)
            {
                throw new InvalidOperationException();
            }
            _isStarted = true;
            _startDateTime = DateTime.Now;
            

        }

        public TimeSpan Stop()
        {
            if (_isStop && !_isStarted)
            {
                throw new InvalidOperationException();
            }
            _isStarted = false;
            _isStop = true;
            _stopDateTime = DateTime.Now;
            
            
            var timeSpan = _stopDateTime - _startDateTime;
            
            return timeSpan;
        }
    }
}
