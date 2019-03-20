using System;

namespace Facade
{
    public interface IFacade
    {
        void ExecuteFacade(Action action);
        void ExecuteFacade<T>(Action<T> action, T arg);
        TResult ExecuteFacade<TResult>(Func<TResult> func);
        TResult ExecuteFacade<T, TResult>(Func<T, TResult> func, T arg);
    }
}
