namespace BossDeathCounter.State
{
    public static class StaticAccessor
    {
        public static GameState GameState { get; set; } = new();
    }
}