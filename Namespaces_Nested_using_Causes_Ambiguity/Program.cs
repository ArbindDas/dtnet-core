﻿using System;

namespace Game
{
    using Characters = RPG.Characters;  // Alias for RPG.Characters

    namespace RPG
    {
        public class Characters
        {
            public void Attack() => Console.WriteLine("RPG Character Attack");
        }
    }

    namespace FPS
    {
        public class Characters
        {
            public void Shoot() => Console.WriteLine("FPS Character Shoot");
        }
    }
s
    public class Test
    {
        public void Run()
        {
            // This would cause a compilation error due to ambiguity
            // var rpgChar = new Characters(); // ❌ ERROR: Ambiguous (RPG.Characters or FPS.Characters?)

            // Correct ways to resolve the ambiguity:
            var rpgChar = new RPG.Characters();  // Fully qualified name
            rpgChar.Attack();

            var fpsChar = new FPS.Characters();  // Fully qualified name
            fpsChar.Shoot();

            // Or using the alias we defined
            var aliasChar = new Characters();    // Uses RPG.Characters via alias
            aliasChar.Attack();
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Demonstrating namespace ambiguity and resolution:");

        var test = new Game.Test();
        test.Run();


              /* Output:
        Demonstrating namespace ambiguity and resolution:
        RPG Character Attack
        FPS Character Shoot
        RPG Character Attack
        */
    }
}