internal class Program
{
    private static void Main(string[] args)
    {
        string palavra;
        int cont_vogal = 0;
        int cont_consoante = 0;

        Console.WriteLine("DIGITE UMA PALAVRA: ");
        palavra = Console.ReadLine().ToLower();

        Console.Write("QUANTIDADE DE CARACTERES DA PALAVRA " + palavra + " : " + palavra.Length);
        Console.WriteLine();

        QuantidadeDeVogaisConsoante(palavra);
        Console.Write("QUANTIDADE DE VOGAIS: " + cont_vogal);
        Console.WriteLine();
        Console.Write("QUANTIDADE DE CONSOANTES: " + cont_consoante);

        char[] vetor_caracteres = palavra.ToCharArray();

        AlternanciaEntreMaiusculaMinuscula(palavra);
        string resultado = string.Concat(vetor_caracteres);

        Console.WriteLine();
        Console.Write("ALTERNÂNCIA ENTRE MAIUSCULO E MINUSCULO: " + resultado);
        Console.WriteLine();

       
        Espelhamento(palavra);
        resultado = string.Concat(vetor_caracteres);
        Console.Write("A VARIÁVEL ESPELHADA: " + resultado);

        void QuantidadeDeVogaisConsoante(string palavra)
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == 'a' ||
                    palavra[i] == 'e' ||
                    palavra[i] == 'i' ||
                    palavra[i] == 'o' ||
                    palavra[i] == 'u')
                {
                    cont_vogal++;
                }
                else
                {
                    cont_consoante++;
                }
            }
        }

        void AlternanciaEntreMaiusculaMinuscula(string palavra)
        {

            for (int i = 0; i < palavra.Length; i++)
            {
                if (i % 2 == 0)
                {
                    vetor_caracteres[i] = Char.ToUpper(palavra[i]);
                }
                else
                {
                    vetor_caracteres[i] = Char.ToLower(palavra[i]);
                }
            }
        }

        void Espelhamento(string palavra)
        {
            int j = 0;
            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                vetor_caracteres[j] = palavra[i];
                j++;
            }
        }
    }
}