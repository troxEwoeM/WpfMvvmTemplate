namespace WpfMvvmTemplate.ViewModel
{
    using System.Windows.Media;
    using MaterialDesignThemes.Wpf;

    public class SettingsViewModel : BaseViewModel
    {
        public override string MenuCaption { get; } = "Настройки";
        public override PackIconKind MenuIcon { get; } = PackIconKind.Settings;
        public override Brush IconColor { get; } = Brushes.Orange;
    }
}