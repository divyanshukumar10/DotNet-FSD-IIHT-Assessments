internal class ATCMediator : IATCMediator
{
	private Flight flight;

	private Runway runway;

	public bool land;

	public virtual void registerRunway(Runway runway)
	{
		this.runway = runway;
	}

	public virtual void registerFlight(Flight flight)
	{
		this.flight = flight;
	}

	public virtual bool isLandingOk()
	{
		return land;
	}

	public virtual void setLandingStatus(bool status)
	{
		land = status;
	}
}

internal interface Command
{
	void land();
}

internal interface IATCMediator
{
	void registerRunway(Runway runway);

	void registerFlight(Flight flight);

	bool isLandingOk();

	void setLandingStatus(bool status);
}

internal class Flight : Command
{
	private IATCMediator atcMediator;

	public Flight(IATCMediator atcMediator)
	{
		this.atcMediator = atcMediator;
	}

	public virtual void land()
	{
		if (atcMediator.isLandingOk())
		{
			System.Console.Out.WriteLine("Successfully Landed.");
			atcMediator.setLandingStatus(true);
		}
		else
		{
			System.Console.Out.WriteLine("Waiting for landing.");
		}
	}

	public virtual void getReady()
	{
		System.Console.Out.WriteLine("Ready for landing.");
	}
}

internal class Runway : Command
{
	private IATCMediator atcMediator;

	public Runway(IATCMediator atcMediator)
	{
		this.atcMediator = atcMediator;
		atcMediator.setLandingStatus(true);
	}

	public virtual void land()
	{
		System.Console.Out.WriteLine("Landing permission granted.");
		atcMediator.setLandingStatus(true);
	}
}

internal class MediatorDesignPattern
{
	public static void Main(string[] args)
	{
		IATCMediator atcMediator = new ATCMediator();
		Flight sparrow101 = new Flight(atcMediator);
		Runway mainRunway = new Runway(atcMediator);
		atcMediator.registerFlight(sparrow101);
		atcMediator.registerRunway(mainRunway);
		sparrow101.getReady();
		mainRunway.land();
		sparrow101.land();
	}
}