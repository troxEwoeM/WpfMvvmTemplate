namespace WpfMvvmTemplate.IoC
{
    using ViewModel;
    using System.Collections.Generic;
    using Ninject.Modules;
    using NLog;

    public class IocConfiguration : NinjectModule
    {
        private const string FileLoggerName = @"file";
        private const string ConsoleLoggerName = @"file";
        public override void Load()
        {
            var fileLogger = LogManager.GetLogger(FileLoggerName);
            var consoleLogger = LogManager.GetLogger(ConsoleLoggerName);
            var loggers = new List<ILogger> { fileLogger, consoleLogger };

            Bind<IList<ILogger>>().ToConstant(loggers);
            Bind<HomeViewModel>().ToSelf().InSingletonScope();
            Bind<SettingsViewModel>().ToSelf().InSingletonScope();
        }
    }
}