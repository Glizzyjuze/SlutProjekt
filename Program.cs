using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(1920, 1080, "Doom 1983");
Raylib.SetTargetFPS(60);
Raylib.ToggleFullscreen();

Player player = new();
Enemy enemy = new();

Camera2D camera;
camera.Offset = new Vector2(Raylib.GetScreenWidth() / 2 - 35, Raylib.GetScreenHeight() / 2 - 35);
camera.Rotation = 0f;
camera.Zoom = 1f;

while (!Raylib.WindowShouldClose())
{
    Raylib.ClearBackground(Color.Beige);

    //camera.Target = new Vector2();

    //Raylib.BeginMode2D(camera);

    

    Raylib.EndMode2D();

    Raylib.EndDrawing();
}