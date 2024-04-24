using System.Numerics;
using Raylib_cs;
using SlutProjekt;

public class Enemy : GameObject
{
    public Enemy()
    {
        speed = 20f;

        size = new Vector2(150, 150);
        pos = new Vector2(1400, 540 - size.Y / 2);

        color = Color.Red;
        rect = new Rectangle(pos, size);
    }

    public override void Draw()
    {
        base.Draw();
    }

    int moveDownTime = 10;
    int moveTime = 30;

    Vector2 direction;
    Vector2 movement;

    int newPosX = Random.Shared.Next(1920);
    int newPosY = Random.Shared.Next(1080);

    public void Update()
    {
        if (moveDownTime > 0)
        {
            moveDownTime -= 1;
        }

        rect.X = pos.X;
        rect.Y = pos.Y;

        Vector2 destination = new Vector2(newPosX, newPosY);
        Vector2 diff = destination - pos;
        direction = Vector2.Normalize(diff);
        movement = direction * speed;   
        
        if (moveDownTime == 0 && moveTime > 0)
        {
            pos.X += movement.X;
            pos.Y += movement.Y;

            moveTime -= 1;

            if (moveTime == 0)
            {
                moveDownTime = 10;
                moveTime = 30;

                newPosX = Random.Shared.Next(1920);
                newPosY = Random.Shared.Next(1080);
            }
        }
    }
}
