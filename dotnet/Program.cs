int imageWidth = 256;
int imageHeight = 256;

Console.WriteLine($"P3");
Console.WriteLine($"{imageWidth} {imageHeight}");
Console.WriteLine(255);

var standardError = new StreamWriter(Console.OpenStandardError());
standardError.AutoFlush = true;
Console.SetError(standardError);

for (int j = 0; j < imageHeight; j++)
{
    Console.Error.Write($"\rScanlines remaining: {imageHeight - j}");

    for (int i = 0; i < imageWidth; i++)
    {
        double r = Convert.ToDouble(i) / (imageWidth - 1);
        double g = Convert.ToDouble(j) / (imageHeight - 1);
        double b = 0.0;

        int ir = Convert.ToInt32(255.999 * r);
        int ig = Convert.ToInt32(255.999 * g);
        int ib = Convert.ToInt32(255.999 * b);

        Console.WriteLine("{0} {1} {2}", ir, ig, ib);
    }
}

Console.Error.Write("\rDone.                            ");
