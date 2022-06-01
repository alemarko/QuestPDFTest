using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace QuestPDFTest;

public class VerySimpleDocument : IDocument
{
	public string Model { get; }

	public VerySimpleDocument(string model)
	{
		Model = model;
	}

	public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

	public void Compose(IDocumentContainer container)
	{
		container.Page(page => page.Content().Element(ComposeContent));
	}

	void ComposeContent(IContainer container)
	{
		container.PaddingVertical(40).Grid(grid => 
		{
			grid.VerticalSpacing(4);
			grid.HorizontalSpacing(25);
			grid.AlignCenter();
			grid.Columns(2);

			grid.Item().Text("Text");
			grid.Item().Text("Description");

			grid.Item(2).LineHorizontal(1, Unit.Millimetre);
			
			grid.Item().Text(Model);
			grid.Item().Text("no font set (default font)");

			grid.Item().Text(Model).FontFamily("Liberation Sans Narrow");
			grid.Item().Text(".FontFamily(\"Liberation Sans Narrow\")");

			grid.Item().Text(Model).FontFamily("Liberation Sans Narrow").Bold();
			grid.Item().Text(".FontFamily(\"Liberation Sans Narrow\").Bold()");

			grid.Item().Text(Model).FontFamily("Liberation Sans Narrow").Italic();
			grid.Item().Text(".FontFamily(\"Liberation Sans Narrow\").Italic()");

			grid.Item().Text(Model).FontFamily("Liberation Sans Narrow").Bold().Italic();
			grid.Item().Text(".FontFamily(\"Liberation Sans Narrow\").Bold().Italic()");
		});
	}
}
