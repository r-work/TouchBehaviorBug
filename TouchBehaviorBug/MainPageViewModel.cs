using CommunityToolkit.Mvvm.Input;

namespace TouchBehaviorBug
{
    public partial class MainPageViewModel
    {
        public List<Item> Items { get; set; } = new List<Item>()
        {
            new Item { Name = "Item 1", Description = "This is item 1" },
            new Item { Name = "Item 2", Description = "This is item 2" },
        };

        [RelayCommand]
        public void ItemClicked(Item item)
        {
        }
    }
}
