double lado = 5;
double altura = 10;
double d = 4;
double D = 6;
double perimetro = Application.Figura261E12.Perimetro(lado);
double area = Application.Figura261E12.Area(d, D);
double volumen = Application.Figura261E12.Volumen(area, altura);

// ToDo

Console.WriteLine($"El perímetro de un rombo de {lado}cm por lado es {perimetro}cm");
Console.WriteLine($"El área de un rombo con la diagonal corta = {d}cm y diagonal larga = {D}cm es {area}cm2");
Console.WriteLine($"El volumen de un rombo de área {area}cm2 y altura {altura}cm es {volumen}cm3");
