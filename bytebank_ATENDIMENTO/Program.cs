﻿using bytebank_ATENDIMENTO.bytebank.Atendimento;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Array em C#
////int[] idades = new int[5];

////for(int i = 0;i < idades.Length; i++)
////{
////    idades[i] = i;
////    Console.WriteLine(idades[i]);
////}

//// código anterior omitido

//Array amostra = Array.CreateInstance(typeof(double), 5); //Igual a new double[5]
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

////[5,9][1,8][7,1][10][6,9]
//TestaMediana(amostra);

//void TestaMediana(Array array)
//{
//    if ((array == null) || (array.Length == 0))
//    {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
//    }

//    double[] numerosOrdenados = (double[])array.Clone();
//    Array.Sort(numerosOrdenados);
//    //[1,8][5,9][6,9][7,1][10]

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
//                                                             (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
//    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
//}

//int[] valores = { 10, 58, 36, 47 };

//for(int i = 0;i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}


//void TestaArrayDeContasCorrentes()
//{
//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();

//    var contaDoAndre = new ContaCorrente(963, "12345-X");
//    listaDeContas.Adicionar(contaDoAndre); 
//    var contaDoJoao = new ContaCorrente(965, "45-X");
//    listaDeContas.Adicionar(contaDoJoao);

//    //listaDeContas.ExibeLista();
//    //listaDeContas.Remover(contaDoAndre);
//    //Console.WriteLine("-----------------------");
//    //listaDeContas.ExibeLista();

//    for (int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] -- {conta.Conta}/{conta.Numero_agencia}");
//    }
//}

//TestaArrayDeContasCorrentes();
#endregion 

new ByteBankAtendimento().AtendimentoCliente();
