double glicemia; 
Console.WriteLine ("Insira o valor do seu teste de glicemia:");

glicemia = Convert.ToDouble (Console.ReadLine ());


if (glicemia <92)
Console.WriteLine ("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");

else if (glicemia > 92 && glicemia < 126) 
Console.WriteLine("Compatível com Diabetes Gestacional");

else if (glicemia > 126)
Console.WriteLine ("Compativel com Diabetes Mellitus na Gravidez");