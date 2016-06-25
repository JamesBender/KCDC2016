using System;
using Common;
using Ninject.Activation;
using Ninject.Modules;

namespace MyNinjectModules
{
    public class ConditionalLoggingModule : NinjectModule
    {
        private readonly bool _isConnected;

        public ConditionalLoggingModule(bool isConnected)
        {
            _isConnected = isConnected;
        }

        public override void Load()
        {
            Bind<ILoggingSink>().To<NormalLoggingSync>();
            
            if (_isConnected)
            {
                Bind<IDomComponent>().To<Logger>();
            }
            else
            {
                Bind<IDomComponent>().ToProvider<OfflineLoggingCompoentProvider>();
            }
            
            Bind<SimpleBusinessEngine>().ToSelf();
        }
    }

    public class OfflineLoggingCompoentProvider : Provider<IDomComponent>
    {
        protected override IDomComponent CreateInstance(Ninject.Activation.IContext context)
        {
            // Complex logic to figure out what gets created goes here
            return new OffLineLoggingComponent();
        }
    }
}