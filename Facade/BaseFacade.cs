using System;
using System.Diagnostics.Contracts;

namespace Facade
{
    public abstract class BaseFacade : IFacade
    {
        public void ExecuteFacade(Action action)
        {
            Contract.Requires<ArgumentNullException>(action != null, nameof(action));
            action();
        }

        public void ExecuteFacade<T>(Action<T> action, T arg)
        {
            Contract.Requires<ArgumentNullException>(action != null, nameof(action));
            action(arg);
        }

        public TResult ExecuteFacade<TResult>(Func<TResult> func)
        {
            Contract.Requires<ArgumentNullException>(func != null, nameof(func));
            return func();
        }

        public TResult ExecuteFacade<T, TResult>(Func<T, TResult> func, T arg)
        {
            Contract.Requires<ArgumentNullException>(func != null, nameof(func));
            return func(arg);
        }
    }
}
