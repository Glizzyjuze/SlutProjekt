using System.Numerics;
using Raylib_cs;
using SlutProjekt;

Raylib.InitWindow(1920, 1080, "Eratic Square");
Raylib.SetTargetFPS(60);
Raylib.ToggleFullscreen();

Player player = new();
Enemy enemy = new();
GameObject gameObject = new();

string currentScene = "menu";
int time = 0;

while (!Raylib.WindowShouldClose())
{
    if (currentScene == "menu")
    {
        Raylib.ClearBackground(Color.Black);

        Raylib.DrawText("WELCOME TO ERATIC SQUARE", 100, 600, 80, Color.Red);
        Raylib.DrawText("PRESS ENTER TO BEGIN", 100, 700, 80, Color.Red);

        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            currentScene = "game";
        }

        Raylib.EndDrawing();
    }

    if (currentScene == "game")
    {
        time++; 

        Raylib.ClearBackground(Color.Beige);

        player.Draw();
        player.Update();

        enemy.Draw();
        enemy.Update();

        if (Raylib.CheckCollisionRecs(player.rect, enemy.rect))
        {
            currentScene = "lose";
        }

        Raylib.EndDrawing();
    }
    
    if (currentScene == "lose")
    {
        Raylib.ClearBackground(Color.Black);

        Raylib.DrawText("You lose", 100, 600, 80, Color.Red);
        Raylib.DrawText($"Your time: {time / 60}s", 100, 700, 40, Color.Red);
        Raylib.DrawText("Press R to play again", 100, 800, 40, Color.Red);
        

        if (Raylib.IsKeyPressed(KeyboardKey.R))
        {
            currentScene = "game";
            player.pos = new Vector2(Raylib.GetScreenWidth() / 2 - 70 / 2, Raylib.GetScreenHeight() / 2 - 70 / 2);
            enemy.pos = new Vector2(1400, 540 - 150 / 2);
            time = 0;
        }

        Raylib.EndDrawing();
    }
}