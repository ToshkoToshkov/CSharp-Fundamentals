using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameHp = new Dictionary<string, int>();
            Dictionary<string, int> nameMp = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            int hpMax = 100;
            int mpMax = 200;

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = cmd[0];
                int hp = int.Parse(cmd[1]);
                int mp = int.Parse(cmd[2]);

                nameHp[name] = hp > hpMax ? hpMax : hp;
                nameMp[name] = mp > mpMax ? mpMax : mp;

            }

            string command = Console.ReadLine();


            while (command != "End")
            {
                string[] currCommand = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string cmd = currCommand[0];
                string heroeName = currCommand[1];

                if (cmd == "CastSpell")
                {
                    int mpNeeded = int.Parse(currCommand[2]);
                    string spellName = currCommand[3];

                    if (nameMp[heroeName] >= mpNeeded)
                    {
                        nameMp[heroeName] -= mpNeeded;
                        Console.WriteLine($"{heroeName} has successfully cast {spellName} and now has {nameMp[heroeName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroeName} does not have enough MP to cast {spellName}!");
                    }

                }
                else if (cmd == "TakeDamage")
                {
                    int damage = int.Parse(currCommand[2]);
                    string attacker = currCommand[3];

                    nameHp[heroeName] -= damage;

                    if (nameHp[heroeName] > 0)
                    {
                        Console.WriteLine($"{heroeName} was hit for {damage} HP by {attacker} and now has {nameHp[heroeName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroeName} has been killed by {attacker}!");
                        nameHp.Remove(heroeName);
                        nameMp.Remove(heroeName);
                    }
                }
                else if (cmd == "Recharge")
                {
                    int amount = int.Parse(currCommand[2]);
                    int mpBefore = nameMp[heroeName];
                    nameMp[heroeName] += amount;

                    if (nameMp[heroeName] > mpMax)
                    {
                        nameMp[heroeName] = mpMax;
                    }

                    int mpAfter = nameMp[heroeName];
                    int totalAmount = mpAfter - mpBefore;

                    Console.WriteLine($"{heroeName} recharged for {totalAmount} MP!");
                }
                else if (cmd == "Heal")
                {
                    int amount = int.Parse(currCommand[2]);
                    int hpBefore = nameHp[heroeName];

                    nameHp[heroeName] += amount;

                    if (nameHp[heroeName] > hpMax)
                    {
                        nameHp[heroeName] = hpMax;
                    }

                    int hpAfter = nameHp[heroeName];
                    int totalAmount = hpAfter - hpBefore;
                    Console.WriteLine($"{heroeName} healed for {totalAmount} HP!");
                }

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                foreach (var hero in nameHp.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{hero.Key}");
                    Console.WriteLine($"HP: {hero.Value}");
                    Console.WriteLine($"MP: {nameMp[hero.Key]}");
                }
            }
        }
    }
}
