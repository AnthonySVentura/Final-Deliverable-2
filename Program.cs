Console.WriteLine("Good morning and welcome to Tony's buffet! We offer a buffet for $9.99 and charge for water and coffee. We can sit up to six people per party.How many of you will be dining with us?");
string guest = Console.ReadLine();
int g = int.Parse(guest);
            
if (g > 6 == true)
{
    Console.WriteLine("I apoligize but we can sit only up to 6 guest and no more. Have a wonderful day!");
}
else
{
    Console.WriteLine($"Table for {guest}! Sounds great, you can follow me to your table. Our options to drink again were we offer water for free and coffee for $1.99.");

    int totaldrinks = 0;
    for (int person = 1; person <= g; )
    {
        Console.WriteLine($"What could I get person {person} to drink?");
        string drink = Console.ReadLine();
        if (drink == "water")
        {
           totaldrinks++;
           person++;
           Console.WriteLine("water, sounds good");
        }
        else if (drink == "coffee")
        {
           person++;
           Console.WriteLine("okay we will get a coffee for you!");
        }
        else
        {
           Console.WriteLine("We do not offer that!");
        }
                    
    }

    double total = (g * 9.99) + (totaldrinks * 1.99);
    Console.WriteLine($"We have {totaldrinks} coffee and the rest of you with waters. \n Your total will be ${total}");
    Console.Read();

}







