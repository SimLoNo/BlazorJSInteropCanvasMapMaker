namespace BlazorJSInteropCanvasMapMaker.Models
{
    public class MapEntity
    {
        public string? Name { get; set; }
        public List<Coordinate> Positions { get; set; } = [];
    }
}
