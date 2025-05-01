using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

const string separatorColor = "#0000FF";

Document.Create(container =>
{
    container
    .Page(page =>
    {
        page.Size(PageSizes.A4);
        page.Margin(1, Unit.Centimetre);
        page.PageColor(Colors.White);
        page.MarginTop(0);

        page.DefaultTextStyle(TextStyle
            .Default
            .FontFamily(Fonts.Calibri));

        page.Header().Element(Header);
        page.Content().Element(Body);
    });
}).GeneratePdfAndShow();


void Header(IContainer header)
{
    header
        .PaddingTop(1f, Unit.Centimetre)
        .PaddingBottom(.6f, Unit.Centimetre)
        .Column(column =>
        {
            column.Spacing(5);

            column.Item().AlignCenter().Text("Maxime Gras").FontSize(25);
        });
}

void Body(IContainer obj)
{
    obj
       .PaddingVertical(.3f, Unit.Centimetre)
       .Column(column =>
       {
           column.Spacing(5);

           column.Item().Element(x => APropos(x));
           column.Item().Element(x => TechnicalSkill(x));
           column.Item().Element(x => WorkExperience(x));
           column.Item().Element(x => Education(x));
           column.Item().Element(x => PastProject(x));
       });
}

void APropos(IContainer container)
{
    container.Column
        (column =>
        {
            column.Item().AlignLeft().Text("Résumé professionnel").FontSize(15);
            column.Item().PaddingVertical(0.1f).LineHorizontal(1).LineColor(Color.FromHex(separatorColor));

            column.Item().PaddingVertical(0.1f).AlignLeft()
            .Text("Développeur C# .Net passionné avec près de 4 années d'expériences dans la conception et le développement d'applications logicielles et mobiles, je suis à la recherche de nouveaux défis pour améliorer mes compétences techniques et contribuer à la réussite de mes projets futurs.")
            .FontSize(12);
        });
}

void TechnicalSkill(IContainer container)
{
    container.Column
       (column =>
       {
           column.Item().AlignLeft().Text("Compétences techniques").FontSize(15);
           column.Item().PaddingVertical(0.1f).LineHorizontal(1).LineColor(Color.FromHex(separatorColor));

           column.Item().AlignLeft().Text("Langages de programmation :").FontSize(12);
           column.Item().AlignLeft().Text("Bases de données :").FontSize(12);
           column.Item().AlignLeft().Text("Technologies et outils :").FontSize(12);
           column.Item().AlignLeft().Text("Autres compétences :").FontSize(12);
       });
}

void WorkExperience(IContainer container)
{
    container.Column
       (column =>
       {
           column.Item().AlignLeft().Text("Expériences professionnelles").FontSize(15);
           column.Item().PaddingVertical(0.1f).LineHorizontal(1).LineColor(Color.FromHex(separatorColor));

           column.Item().AlignLeft().Text("Développeur C# .NET | IDCONSEILS | Septembre 2021 - Maintenant").FontSize(12);
            column.Item().AlignLeft().PaddingLeft(5).Text(". Conception et réalisation d'applications en C# .NET Blazor").FontSize(10);
            column.Item().AlignLeft().PaddingLeft(5).Text(". Conception et réalisation d'applications mobiles en C# .NET MAUI").FontSize(10);
            column.Item().AlignLeft().PaddingLeft(5).Text(". Réalisation d'API REST ASP .Net Core ").FontSize(10);
           column.Item().AlignLeft().Text("Alternance développement mobile | IDCONSEILS | Septembre 2020 - Septembre 2021").FontSize(12);
            column.Item().AlignLeft().PaddingLeft(5).Text(". Réalisation d'une application mobile de gestion de transport").FontSize(10);
           column.Item().AlignLeft().Text("Stage développement mobile | PROTEOR | Avril 2020 - Juin 2020").FontSize(12);
            column.Item().AlignLeft().PaddingLeft(5).Text(". Réalisation d'une application mobile de compte-rendu médicale pour des scolioses").FontSize(10);
       });
}

void Education(IContainer container)
{
    container.Column
       (column =>
       {
           column.Item()
           .AlignLeft()
           .Text("Formation")
           .FontSize(15);
           column.Item().PaddingVertical(0.1f).LineHorizontal(1).LineColor(Color.FromHex(separatorColor));

       });
}

void PastProject(IContainer container)
{
    container.Column
       (column =>
       {
           column.Item()
           .AlignLeft()
           .Text("Projets")
           .FontSize(15);
           column.Item().PaddingVertical(0.1f).LineHorizontal(1).LineColor(Color.FromHex(separatorColor));

       });
}