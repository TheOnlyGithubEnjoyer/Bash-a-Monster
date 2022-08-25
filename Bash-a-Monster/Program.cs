

Warrior aWarrior = new Warrior();
Monster aMonster = new Monster();

System.Console.WriteLine(aWarrior.name + " has the HP of " + aWarrior.HP);

System.Console.ReadLine();

System.Console.WriteLine(aMonster.name + " has the HP of " + aMonster.HP + " and is as fat as " + aMonster.Fatness + " cows");

System.Console.ReadLine();

System.Console.WriteLine("Press Enter to ATTACK!");

aMonster.HP -= aWarrior.damage;

while (aMonster.HP > 0)
{
    aMonster.HP -= aWarrior.damage;
    System.Console.WriteLine(aMonster.name + " HAS " + aMonster.HP + " HP");
    System.Console.WriteLine("AGAIN!");
    System.Console.ReadLine();

}

if (aMonster.HP <= 0)
{
    System.Console.WriteLine("YOU HAVE KILLED " + aMonster.name);
}


System.Console.ReadLine();



