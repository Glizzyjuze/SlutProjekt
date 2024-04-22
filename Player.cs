using System.Numerics;
using Raylib_cs;
using SlutProjekt;


public class Player : GameObject
{
    public override void Draw()
    {
        base.Draw();
    }

    public void Update()
    {
        rect.X = pos.X;
        rect.Y = pos.Y;

        if (Raylib.IsKeyDown(KeyboardKey.W))
        {
            pos.Y -= speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.S))
        {
            pos.Y += speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            pos.X -= speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            pos.X += speed;
        }
    }
}