namespace WpfMvvmTemplate.IoC
{
    using ViewModel;
    using System.Collections.Generic;
    using NLog;

    public class Constants
    {
        public static IList<ILogger> Loggers => IocKernel.Get<IList<ILogger>>();

        public static IList<BaseViewModel> Modules => IocKernel.Get<IList<BaseViewModel>>();
    }
}