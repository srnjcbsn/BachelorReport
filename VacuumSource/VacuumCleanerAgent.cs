public class VacuumCleanerAgent : Agent
{
	public VacuumCleanerAgent(string name)
		: base(name)
	{
		//Register the Vacuum vision module to the agent, to allow it to recieve percepts
		this.RegisterModule(new VacuumVisionModule());
		
	}
}