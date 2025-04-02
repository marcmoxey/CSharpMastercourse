

using System.Diagnostics;

System.Console.WriteLine("Welcome to the Game Character Abilities Program!");
System.Console.WriteLine("Choose a character type to see their abilities:");
System.Console.WriteLine("1. Warrior");
System.Console.WriteLine("2. Mage");
System.Console.WriteLine("3. Archer");
System.Console.WriteLine("4. Healer");
System.Console.Write("Enter your choice (1-4): ");
int choice = int.Parse(Console.ReadLine());


switch (choice) {
    case 1:
        Warrior warrior = new Warrior();
        warrior.Attack();
        warrior.Defend();
        break;
    case 2:
        Mage mage = new Mage();
        mage.Attack();
        mage.Defend();
        break;
    case 3:
        Archer archer = new Archer();
        archer.Attack();
        archer.Defend();
        break;
    case 4:
        Healer healer = new Healer();
        healer.Heal();
        break;
    default:
        Console.WriteLine("Invalid choice. Please select a valid character type.");
        break;
}

Console.ReadLine();

public interface IAttackable {
    void Attack();
    void Defend();
}

public class Warrior : IAttackable {
    public void Attack() {
        Console.WriteLine("Warrior attacks with sword!");
    }

    public void Defend() {
        Console.WriteLine("Warrior defends with shield!");
    }
}

public class Mage : IAttackable {
    public void Attack() {
        Console.WriteLine("Mage casts a fireball!");
    }

    public void Defend() {
        Console.WriteLine("Mage conjures a magic barrier!");
    }
}   

public class Archer : IAttackable {
    public void Attack() {
        Console.WriteLine("Archer shoots an arrow!");
    }

    public void Defend() {
        Console.WriteLine("Archer dodges the attack!");
    }
}

public interface IHealable {
    void Heal();
}

public class Healer : IHealable {
    public void Heal() {
        Console.WriteLine("Healer casts a healing spell!");
    }
}
