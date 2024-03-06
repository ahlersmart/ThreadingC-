// See https://aka.ms/new-console-template for more information

using TestApp.Faction;
using TestApp.Faction.Armory;
using TestApp.Faction.Units;
using Range = TestApp.Faction.Armory.Range;

var armory = new Armory();
var melee = new Melee(11, "Buzzer");
var range = new Range(11, "Pew Pew");

armory.addMelee(melee);

foreach (var item in armory.getMelee())
{
    Console.WriteLine(item.getName());
}
Console.WriteLine("hello");

List<Weapon> rangeWeapons = new List<Weapon>();
List<Weapon> meleeWeapons = new List<Weapon>();
rangeWeapons.Add(range);
meleeWeapons.Add(melee);



var faction = new Faction();
var beast = new Beast("Warg", 1, 12, 20, 3, 0, 1, 1, 1, 3, meleeWeapons, rangeWeapons);
var infantry = new Infantry("Orc", 1, 12, 20, 3, 0, 1, 1, 1, 3, meleeWeapons, rangeWeapons);
var vehicle = new Vehicle("Wheels", 1, 12, 20, 3, 0, 1, 1, 1, 3, meleeWeapons, rangeWeapons);

faction.addUnit(vehicle);
faction.addUnit(beast);
faction.addUnit(infantry);

foreach (var item in faction.GetUnits())
{
    Console.WriteLine(item.getName());
}
