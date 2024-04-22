using System.Numerics;

public static class Game
{
	public static int TICKS_PER_SECOND;
	public static double SECONDS_PER_TICK;
	static List<Object> Objects = new List<Object>(100);

	public static void Start()
	{
		Objects.Add(new Player(new Vector2(0, 0)));

		for (int i = 0; i < Objects.Count; i++)
		{
			Objects.ElementAt(i).Start();
		}
	}

	public static void Update(float deltaTime)
	{
		for (int i = 0; i < Objects.Count; i++)
		{
			Objects.ElementAt(i).Update(deltaTime);
		}
	}

	public static void Tick(float deltaTime)
	{
		for (int i = 0; i < Objects.Count; i++)
		{
			Objects.ElementAt(i).Tick(deltaTime);
		}
	}

	public static void Draw()
	{
		for (int i = 0; i < Objects.Count; i++)
		{
			Objects.ElementAt(i).Draw();
		}
	}
}
