using EasyNetQ;

namespace Microservice
{
    public abstract class BaseMicroservice : IMicroservice
    {
        private readonly IBus bus;

        protected BaseMicroservice(IBus bus) =>
            this.bus = bus;
    }
}
