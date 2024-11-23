Console.Clear();

Console.WriteLine("Digite aqui sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade <= 67)
{
    Console.WriteLine("Pode doar Sangue!");

}
else{
    Console.WriteLine("Não pode Doar Sangue!");
}