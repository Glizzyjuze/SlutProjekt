using System.Numerics;
using Raylib_cs;
using SlutProjekt;

public class Enemy : GameObject
{
    public Enemy()
    {
        speed = 5f;
        hp = 10;

        pos = new Vector2(1400, 700);

        color = Color.Red;
        rect = new Rectangle(pos, size);
    }

    public override void Draw()
    {
        base.Draw();
    }

    Vector2 enemyMovement = new();
    Vector2 destination = new();

    int newPosX = Random.Shared.Next(-250, 250);
    int newPosY = Random.Shared.Next(-250, 250);

    int newPosDownTime = 90;

    public void Update()
    {
        newPosDownTime -= 1;

        Vector2 diff = destination - pos;
        Vector2 Direction = Vector2.Normalize(diff);

        enemyMovement = Direction * speed;

        if (newPosDownTime == 0)
        {
            destination = new Vector2(newPosX, newPosY);
        }
    }
}
