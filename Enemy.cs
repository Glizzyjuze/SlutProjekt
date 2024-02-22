using System.Numerics;
using Raylib_cs;

public class Enemy
{
    public Player player;

    public Rectangle enemyRec;
    public Vector2 enemyVel;

    public Enemy()
    {
        CreateEnemy();
    }

    public void CreateEnemy()
    {
        enemyRec = new Rectangle(400, 400, 70, 70);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(enemyRec, Color.Green);
    }

    public void Update()
    {
        
    }
}
