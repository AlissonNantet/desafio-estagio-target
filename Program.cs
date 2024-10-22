/*
1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
  (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
  ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

-------------------------------

List<int> sequencia = new List<int>{0, 1};
int numero = 4;

  while(sequencia[sequencia.Count - 1] <= numero)
  {
    int novoNum = sequencia[sequencia.Count - 1] + sequencia[sequencia.Count - 2];
    sequencia.Add(novoNum);

      if(sequencia[sequencia.Count - 1] == numero)
      {
        Console.WriteLine("O SEU NUMERO ESTA NA SEQUENCIA DE FIBONACCI");
        break;
      }
        else if (sequencia[sequencia.Count - 1] > numero)
        {
          Console.WriteLine("O SEU NUMERO NAO ESTA NA SEQUENCIA DE FIBONACCI");
        }     
  }
*/

/*
2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, 
além de informar a quantidade de vezes em que ela ocorre.

IMPORTANTE: Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

-------------------------------

string entrada = "Alisson Nantet Rosa";
int n = 0;

    foreach (char c in entrada)
      if(c == 'a'|| c == 'A') n += 1;
    
    if(n > 0)
      Console.WriteLine($"A letra 'a' aparece {n} vezes.");
    else
      Console.WriteLine("A letra 'a' nao aparece.");
*/

/*
3) Observe o trecho de código abaixo: 
int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);

Ao final do processamento, qual será o valor da variável SOMA?

-------------------------------
    
int indice = 12, soma = 0, K = 1;

while (K < indice)
{
  K = K + 1;
  soma = soma + K; 
}

Console.WriteLine(soma);
*/

