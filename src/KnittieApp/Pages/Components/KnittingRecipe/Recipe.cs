namespace KnittieApp.Pages.Components.KnittingRecipe
{
    public class Recipe
    {
        public string Id                  { set; get; } = String.Empty;
        public string Name                { set; get; } = String.Empty;
        public string CreatorId           { set; get; } = String.Empty;
        public string Description         { set; get; } = String.Empty;
        public LoopTable? LoopTable       { get; set; } = null;

        public Recipe(string id, string name, string creatorId, string description, LoopTable? loopTable)
        {
            Id          = id;
            Name        = name;
            CreatorId   = creatorId;
            Description = description;
            LoopTable   = loopTable;
        }
    }
}
