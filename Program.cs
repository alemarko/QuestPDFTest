using QuestPDF.Drawing;
using QuestPDF.Previewer;
using QuestPDFTest;

FontManager.RegisterFontType("Liberation Sans Narrow", File.OpenRead(@"C:\Projects\QuestPDFTest\LiberationSansNarrow-Regular.ttf"));
FontManager.RegisterFontType("Liberation Sans Narrow", File.OpenRead(@"C:\Projects\QuestPDFTest\LiberationSansNarrow-Bold.ttf"));
FontManager.RegisterFontType("Liberation Sans Narrow", File.OpenRead(@"C:\Projects\QuestPDFTest\LiberationSansNarrow-Italic.ttf"));
FontManager.RegisterFontType("Liberation Sans Narrow", File.OpenRead(@"C:\Projects\QuestPDFTest\LiberationSansNarrow-BoldItalic.ttf"));

var model = "This is some text to display";
var document = new VerySimpleDocument(model);

document.ShowInPreviewer();
