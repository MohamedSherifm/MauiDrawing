using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDrawing.Models;
using System.Collections.ObjectModel;


namespace MauiDrawing.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Item> items= new();

        public MainViewModel()
        {
            Items.Add(new()
            {
                Name = "In literary theory, a text is any object that can be read, whether this object is a work of literature, a street sign, an arrangement of buildings on a city block, or styles of clothing. It is a coherent set of signs that transmits some kind of informative message."
            });

            Items.Add(new()
            {
                Name = "In literary theory, a text is any object that can be read, whether this object is a work of literature, a street sign, an arrangement of buildings on a city block, or styles of clothing. It is a coherent set of signs that transmits some kind of informative message."
            });

            Items.Add(new()
            {
                Name = "In literary theory, a text is any object that can be read, whether this object is a work of literature, a street sign, an arrangement of buildings on a city block, or styles of clothing. It is a coherent set of signs that transmits some kind of informative message."
            });

            Items.Add(new()
            {
                Name = "In literary theory, a text is any object that can be read, whether this object is a work of literature, a street sign, an arrangement of buildings on a city block, or styles of clothing. It is a coherent set of signs that transmits some kind of informative message."
            });
        }

        [RelayCommand]
        public void AddItem() 
        {
            Items.Add(new()
            {
                Name = "Added Items"
            });
        }
    }
}
