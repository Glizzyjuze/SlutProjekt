using Raylib_cs;
using SlutProjekt;

Raylib.InitWindow(1920, 1080, "Doom 1983");
Raylib.SetTargetFPS(60);
Raylib.ToggleFullscreen();

Player player = new();
Enemy enemy = new();

while (!Raylib.WindowShouldClose())
{
    Raylib.ClearBackground(Color.Beige);

    player.Draw();
    player.Update();

    enemy.Draw();
    enemy.Update();

    Raylib.EndDrawing();
}