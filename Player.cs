using System.Numerics;
using Raylib_cs;

public class Player
{
    public Rectangle playerRec;
    public Vector2 playerPos;
    
    public float moveSpeed = 10f;

    public Player()
    {
        CreatePlayer();
    }

    public void CreatePlayer()
    {
        playerPos = new Vector2(Raylib.GetScreenWidth() / 2 - 35, Raylib.GetScreenHeight() / 2 - 35);
        playerRec = new Rectangle(playerPos.X, playerPos.Y, 70, 70);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(playerRec, Color.Gray);
    }

    public void Update()
    {
        playerRec.X = playerPos.X;
        playerRec.Y = playerPos.Y;

        if (Raylib.IsKeyDown(KeyboardKey.W))
        {
            playerPos.Y -= moveSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.S))
        {
            playerPos.Y += moveSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            playerPos.X -= moveSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            playerPos.X += moveSpeed;
        }
    }
}
