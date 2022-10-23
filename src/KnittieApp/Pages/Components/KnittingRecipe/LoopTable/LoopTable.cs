namespace KnittieApp.Pages.Components.KnittingRecipe
{
    public class LoopTable
    {
        public int Width  { get; set; } = 50;
        public int Height { get; set; } = 50;
        public List<LoopRow>? Rows { get; set; } = null;

        public LoopTable(int width = 50, int height = 50, List<LoopRow>? rows = null)
        {
            Width  = width;
            Height = height;

            if (rows is not null) {
                Rows = rows;
            } else {
                Rows = new();

                for (var idx = 0; idx < height; idx++) {

                    var loops = new List<Loop>();
                    for (var loopIdx = 0; loopIdx < width; loopIdx++) {
                        loops.Add(new Loop(description: String.Empty, LoopType.NONE));
                    }

                    Rows.Add(
                        new LoopRow(rowIndex: idx, description: String.Empty, loops: loops)
                    );
                }
            }
        }
    }
}
