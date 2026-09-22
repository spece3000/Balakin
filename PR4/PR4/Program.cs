string offer = Console.ReadLine();
char[] offer_split = offer.ToCharArray();

for (int i = 0; i < offer_split.Length; i+= 2)
{
    offer_split[i] = char.ToUpper(offer_split[i]);
}

offer = new string(offer_split);
Console.WriteLine(offer);

int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= number; i++)
{
    Console.WriteLine(i);
}

int[] arr_5 = new int[5];

for (int i = 0; i < arr_5.Length; i++)
{
    arr_5[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = arr_5.Length - 1; i >= 0; i--)
{
    Console.Write(arr_5[i] + " ");
}