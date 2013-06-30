public class VacuumWorldBuilder : XmasWorldBuilder
{
	//This explains to the engine how to construct the world we just made
	protected override XmasWorld ConstructWorld()
	{
		return new VacuumWorld();
	}
}