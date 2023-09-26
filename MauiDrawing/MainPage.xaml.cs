using MauiDrawing.ViewModels;

namespace MauiDrawing
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _mainViewModel;

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _mainViewModel = mainViewModel;
            BindingContext = _mainViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            if(MaskBorder.HeightRequest == 0) 
            {
                var animation = new Animation(x => { MaskBorder.HeightRequest = x; }, 0, 50);
                animation.Commit(this, "HideAnimation", 16, 250, Easing.Linear, finished:async (d, b) =>
                {
                    await myPath.ScaleTo(1, 500, Easing.Linear);
                });
                
            }
            else
            {
                var animation = new Animation(x => { MaskBorder.HeightRequest = x; }, 50, 0);
                animation.Commit(this, "RevealAnimation", 16, 250, Easing.Linear, finished:async (d, b) =>
                {
                    await myPath.ScaleTo(1.5, 250, Easing.Linear);
                    await myPath.ScaleTo(1, 250, Easing.Linear);
                });
                
            }
            
        }
    }

}
