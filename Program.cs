using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Iphone i7 = new Iphone("123", "7", "1257abc", 128);
i7.Ligar();
i7.ReceberLigacao();
i7.InstalarAplicativo("WhatsApp");

Nokia n3 = new Nokia("523","N5","6985",32);
n3.Ligar();
n3.ReceberLigacao();
n3.InstalarAplicativo("Snake");

