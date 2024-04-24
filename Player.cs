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

        if (Raylib.IsKeyDown(KeyboardKey.W) && pos.Y > 0)
        {
            pos.Y -= speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.S) && pos.Y < 1010)
        {
            pos.Y += speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.A) && pos.X > 0)
        {
            pos.X -= speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.D) && pos.X < 1850)
        {
            pos.X += speed;
        }
    }
}