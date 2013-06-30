public class VacuumVision : Percept
{
	//Property that tells if dirt is located at the vacuum cleaner's position
	public bool ContainsDirt { get; set; }

	//Property that tells the position of the vacuum cleaner
	public VacuumPosition VacuumCleanerPosition {get; set;}

	public VacuumVision(bool containsDirt, VacuumPosition position)
	{
		this.ContainsDirt = containsDirt;
		this.VacuumCleanerPosition = position;
	}
}