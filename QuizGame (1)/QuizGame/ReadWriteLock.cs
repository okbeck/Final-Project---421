using System.Threading;

// Implements a read/write lock for thread-safe operations
namespace QuizGame
{
    public class ReadWriteLock
    {
        private ReaderWriterLockSlim rwLock = new ReaderWriterLockSlim();

        public void ReadLock()
        {
            rwLock.EnterReadLock();
        }

        public void WriteLock()
        {
            rwLock.EnterWriteLock();
        }

        public void Done()
        {
            if (rwLock.IsWriteLockHeld)
                rwLock.ExitWriteLock();
            else if (rwLock.IsReadLockHeld)
                rwLock.ExitReadLock();
        }
    }
}