namespace KnittieApp.Pages.Components.KnittingRecipe
{
    public class LoopRow
    {
        public int RowIndex { get; set; }
        public string Description { get; set; } = String.Empty;
        public List<Loop>? Loops  { get; set; } = null;

        public LoopRow(int rowIndex, string description, List<Loop>? loops)
        {
            RowIndex    = rowIndex;
            Description = description;
            Loops       = loops;
        }
    }
}
