using System;

using EasyNetQ;

namespace Microservice
{
    public interface IMicroservice
    {
        ISubscriptionResult Subscribe<T>(Action<T> onMessage)
            where T : class;

        IDisposable Respond<TRequest, TResponse>(Func<TRequest, TResponse> responder)
          where TRequest : class
          where TResponse : class;
    }
}