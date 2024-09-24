using System.Text.Json;

string contents = File.ReadAllText("weapon.json");

Weapon w = JsonSerializer.Deserialize<Weapon>(contents);

Console.WriteLine("How many attacks to make?");

int numAttacks = 0;
string numAttacksStr = "";

while (!int.TryParse(numAttacksStr, out numAttacks))
{
  numAttacksStr = Console.ReadLine();
}

int damageSum = 0;

Console.ForegroundColor = ConsoleColor.Red;

for (int i = 0; i < numAttacks; i++)
{
  int damage = w.Attack();
  Console.WriteLine($"+{damage}");
  damageSum += damage;
}

Console.ResetColor();

Console.WriteLine($"You did a total of {damageSum} points of damage");

Console.ReadLine();



// Från steg 2:

// Weapon w = new() {
//   Name = "Rubber duck"
// };

// string serialized = JsonSerializer.Serialize(w);

// File.WriteAllText("weapon.json", serialized);