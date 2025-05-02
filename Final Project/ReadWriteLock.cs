using System;
using System.Threading;

namespace Final_Project
{
    public class ReadWriteLock
    {
        private int readers = 0;
        private bool writer = false;
        private readonly object lockObj = new object();

        public void ReadLock()
        {
            lock (lockObj)
            {
                while (writer)
                    Monitor.Wait(lockObj);
                readers++;
            }
        }

        public void WriteLock()
        {
            lock (lockObj)
            {
                while (writer || readers > 0)
                    Monitor.Wait(lockObj);
                writer = true;
            }
        }

        public void Done()
        {
            lock (lockObj)
            {
                if (writer)
                {
                    writer = false;
                }
                else
                {
                    readers--;
                }
                Monitor.PulseAll(lockObj);
            }
        }
    }
}
