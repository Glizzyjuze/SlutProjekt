using Raylib_cs;
using SlutProjekt;

public class Player : GameObject
{
    //Ritkoden från GameObject-klassen
    public override void Draw()
    {
        base.Draw();
    }

    //Rörelsekod
    public override void Update()
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