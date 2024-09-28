using DesafioPOO.Models;

//Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia(numero: "15988097551", modelo: "NokiaC21", imei: "222222222", memoria: 16);
Console.WriteLine("Nokia");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone Ip = new Iphone(numero: "15988097551", modelo: "Iphone13", imei: "222222222", memoria: 16);
Ip.Ligar();
Ip.ReceberLigacao();
Ip.InstalarAplicativo("Instagram");