using System;
using Common;
using MyNinjectModules;
using Ninject;

namespace WithNinject
{
    class Program
    {
        static void Main()
        {
            SimpleBusinessEngine businessEngine;
            IKernel kernel;

            #region Example 1

//            kernel = new StandardKernel(new DistributedLoggingModule());
//
//            businessEngine = kernel.Get<SimpleBusinessEngine>();
//            businessEngine.RunProcess();

            #endregion

            #region Example 2

//            var kernelOne = new StandardKernel(new ConditionalLoggingModule(true));
//            var kernelTwo = new StandardKernel(new ConditionalLoggingModule(false));
//
//            businessEngine = kernelOne.Get<SimpleBusinessEngine>();
//            businessEngine.RunProcess();
//            businessEngine = kernelTwo.Get<SimpleBusinessEngine>();
//            businessEngine.RunProcess();

            #endregion

            #region Example 3

//            kernel = new StandardKernel(new CtorAndMethodModule());
//
//            var ctorEngine = kernel.Get<CtorEndMethodEngine>();
//
//            ctorEngine.RunProcess();
            
            #endregion

            #region Example 4

            kernel = new StandardKernel(new NamedDependencyModule());

            var namedEngine = kernel.Get<NamedLoggerEngine>();
            namedEngine.RunProcess();

            #endregion

            #region Example 5

//            kernel = new StandardKernel(new DuplexLoggingModule());
//
//            businessEngine = kernel.Get<DoubleLoggingEngine>();
//            businessEngine.RunProcess();

            #endregion

            Console.ReadKey();
        }
    }
}
