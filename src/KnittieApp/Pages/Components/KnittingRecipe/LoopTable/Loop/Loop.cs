namespace KnittieApp.Pages.Components.KnittingRecipe
{
    public class Loop
    {
        public string Description { get; set; } = String.Empty;
        public LoopType Type      { get; set; } = LoopType.NONE;

        public Loop(string description, LoopType type)
        {
            Description = description;
            Type        = type;
        }
    }
}
