using System.Numerics;
using Raylib_cs;

public class Enemy
{
    public Player player;

    public Rectangle enemyRec;
    public Vector2 enemyPos;
    public Vector2 enemyVel;

    public Enemy()
    {
        CreateEnemy();
    }

    public void CreateEnemy()
    {
        enemyPos = new Vector2(400, 400);
        enemyRec = new Rectangle(enemyPos.X, enemyPos.Y, 70, 70);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(enemyRec, Color.Green);
    }

    public void Update()
    {
        
    }
}
