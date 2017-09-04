namespace WpfMvvmTemplate.IoC
{
    using ViewModel;

    public class ViewModelLocator
    {
        public MainViewModel MainViewModel => IocKernel.Get<MainViewModel>();
        public HomeViewModel HomeViewModel => IocKernel.Get<HomeViewModel>();
        public SettingsViewModel SettingsViewModel => IocKernel.Get<SettingsViewModel>();
    }
}