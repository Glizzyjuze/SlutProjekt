using System.Numerics;
using Raylib_cs;

public class EnemySpawner
{
    public void Spawner()
    {
        Random generator = new Random();

        int randomX = Random.Shared.Next(1);
        int randomY = Random.Shared.Next(1);

        Vector2 spawnPos = new(0, 0);

        if (randomX == 0)
        {
            spawnPos.X = Raylib.GetScreenWidth() + 100;
        }

        if (randomX == 1)
        {
            spawnPos.X = -100;
        }

        if (randomY == 0)
        {
            spawnPos.Y = Raylib.GetScreenHeight() + 100;
        }

        if (randomY == 1)
        {
            spawnPos.Y = -100;
        }
    }
}
