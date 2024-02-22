using System.Numerics;
using Raylib_cs;

public class Player
{
    public Rectangle playerRec;
    
    public float moveSpeed = 10f;

    public Player()
    {
        CreatePlayer();
    }

    public void CreatePlayer()
    {
        playerRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 35, Raylib.GetScreenHeight() / 2 - 35, 70, 70);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(playerRec, Color.Gray);
    }

    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.W))
        {
            playerRec.Y -= moveSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.S))
        {
            playerRec.Y += moveSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            playerRec.X -= moveSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            playerRec.X += moveSpeed;
        }
    }
}
