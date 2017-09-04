namespace WpfMvvmTemplate.IoC
{
    using Ninject;
    using Ninject.Modules;
    using System.Collections.Generic;
    using ViewModel;

    public static class IocKernel
    {
        private static StandardKernel _kernel;

        public static T Get<T>()
        {
            return _kernel.Get<T>();
        }

        public static void Initialize(params INinjectModule[] modules)
        {
            if (_kernel != null) return;
            _kernel = new StandardKernel(modules);
            var views = new List<BaseViewModel> { Get<HomeViewModel>(), Get<SettingsViewModel>() };
            _kernel.Bind<IList<BaseViewModel>>().ToConstant(views);
        }
    }
}