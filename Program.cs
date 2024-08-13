using DesafioPOO.Models;

Iphone i1 = new Iphone("558420203128", "a23", "IMEI.info: 356303489648129",28);
i1.InstalarAplicativo("Pou");
i1.Ligar();
i1.ReceberLigacao();

Nokia n1 = new Nokia("558420203128", "n23", "IMEI.info: 356303489648129",25);
n1.InstalarAplicativo("Pet play");
n1.Ligar();
n1.ReceberLigacao();