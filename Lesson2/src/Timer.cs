using System;

namespace Lesson2
{
    public class Timer
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isStarted;
        
        public void Start()
        {
            _startTime = DateTime.Now;
            _isStarted = true;
        }

        public TimeSpan GetTime()
        {
            return _stopTime - _startTime;
        }

        public TimeSpan Stop()
        {
            if (_isStarted == false)
            {
                return GetTime();
            }
            
            _stopTime = DateTime.Now;
            _isStarted = false;

            return _stopTime - _startTime;
        }
    }
}