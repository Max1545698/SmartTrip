using System;

using EasyNetQ;

namespace Microservice
{
    public abstract class BaseMicroservice : IMicroservice
    {
        private readonly IBus bus;

        protected BaseMicroservice(IBus bus) =>
            this.bus = bus;

        public ISubscriptionResult Subscribe<T>(Action<T> onMessage) 
            where T : class
            => bus.Subscribe<T>(nameof(T), onMessage);

        public IDisposable Respond<TRequest, TResponse>(Func<TRequest,TResponse> responder)
            where TRequest : class
            where TResponse : class
            => bus.Respond<TRequest, TResponse>(responder);
      
    }
}
