namespace WpfMvvmTemplate.ViewModel
{
    using System.Windows.Media;
    using MaterialDesignThemes.Wpf;

    public class HomeViewModel : BaseViewModel
    {
        public override string MenuCaption { get; } = "Главная";
        public override PackIconKind MenuIcon { get; } = PackIconKind.Home;
        public override Brush IconColor { get; } = Brushes.LightBlue;
    }
}