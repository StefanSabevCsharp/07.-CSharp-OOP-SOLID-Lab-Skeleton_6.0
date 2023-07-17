namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            var graphicEditor = new GraphicEditor();
            var shape = new Rectangle();
            graphicEditor.DrawShape(shape);
        }
    }
}
