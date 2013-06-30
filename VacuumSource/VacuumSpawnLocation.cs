public class VacuumSpawnInformation : EntitySpawnInformation
{
	//Since the vacuum cleaner doesn't require more information upon entering the world this information is empty
	public VacuumSpawnInformation(int spawn) : base(new VacuumPosition(spawn))
	{
		
	}


}