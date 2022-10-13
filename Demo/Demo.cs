using Figurer;

Ellipse ellipse = new(7, 5);
Console.WriteLine(ellipse.Areal());
Console.WriteLine(ellipse.Omkreds());
Console.WriteLine(ellipse.Info(""));

Cirkel cirkel = new(3);
Console.WriteLine(cirkel.Areal());
Console.WriteLine(cirkel.Omkreds());
Console.WriteLine(cirkel.Info(""));

Rektangel rektangel = new(2, 4);
Console.WriteLine(rektangel.Areal());
Console.WriteLine(rektangel.Omkreds());
Console.WriteLine(rektangel.Info(""));

Trekant trekant = new(10.35, 11.79, 40.94);
Console.WriteLine(trekant.Areal());
Console.WriteLine(trekant.Omkreds());

trekant = new RetvinkletTrekant(3, 4);
Console.WriteLine(trekant.Areal());
Console.WriteLine(trekant.Omkreds());

trekant = new LigebenetTrekant(3, 45);
Console.WriteLine(trekant.Areal());
Console.WriteLine(trekant.Omkreds());

trekant = new LigesidetTrekant(3);
Console.WriteLine(trekant.Areal());
Console.WriteLine(trekant.Omkreds());
