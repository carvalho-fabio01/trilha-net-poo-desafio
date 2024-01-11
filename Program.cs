using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987540000", modelo: "LumiaZYX", imei: "1234567890", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp Business");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "987540000", modelo: "LumiaZYX", imei: "1234567890", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");