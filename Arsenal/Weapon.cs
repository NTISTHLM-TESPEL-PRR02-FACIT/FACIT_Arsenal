using System.Text.Json.Serialization;

public class Weapon
{
  [JsonInclude]
  public string Name;

  [JsonInclude]
  private int DamageMin = 10;

  [JsonInclude]
  private int DamageMax = 20;

  public int Attack()
  {
    return Random.Shared.Next(DamageMin, DamageMax);
  }
}
