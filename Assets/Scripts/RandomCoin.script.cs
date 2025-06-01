using TheAdventure.Scripting;
using System;
using TheAdventure;

public class RandomCoin : IScript
{
    DateTimeOffset _nextCoinTimestamp;

    public void Initialize()
    {
        _nextCoinTimestamp = DateTimeOffset.UtcNow.AddSeconds(Random.Shared.Next(2, 5));
    }

    public void Execute(Engine engine)
    {
        if (_nextCoinTimestamp < DateTimeOffset.UtcNow)
        {
            _nextCoinTimestamp = DateTimeOffset.UtcNow.AddSeconds(Random.Shared.Next(2, 5));

            var playerPos = engine.GetPlayerPosition();
            var coinPosX = playerPos.X + Random.Shared.Next(-100, 100);
            var coinPosY = playerPos.Y + Random.Shared.Next(-100, 100);

            engine.AddCoin(coinPosX, coinPosY, false);
        }
    }
}
