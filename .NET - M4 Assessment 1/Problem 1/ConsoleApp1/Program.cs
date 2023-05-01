internal abstract class Fighter
{
	internal KickBehavior kickBehavior;

	internal JumpBehavior jumpBehavior;

	public Fighter(KickBehavior kickBehavior, JumpBehavior jumpBehavior)
	{
		this.jumpBehavior = jumpBehavior;
		this.kickBehavior = kickBehavior;
	}

	public virtual void punch()
	{
		System.Console.Out.WriteLine("Default Punch");
	}

	public virtual void kick()
	{
		// delegate to kick behavior
		kickBehavior.kick();
	}

	public virtual void jump()
	{
		// delegate to jump behavior
		jumpBehavior.jump();
	}

	public virtual void roll()
	{
		System.Console.Out.WriteLine("Default Roll");
	}

	public virtual void setKickBehavior(KickBehavior kickBehavior)
	{
		this.kickBehavior = kickBehavior;
	}

	public virtual void setJumpBehavior(JumpBehavior jumpBehavior)
	{
		this.jumpBehavior = jumpBehavior;
	}

	public abstract void display();
}

internal interface KickBehavior
{
	// Encapsulated kick behaviors
	void kick();
}

internal class LightningKick : KickBehavior
{
	public virtual void kick()
	{
		System.Console.Out.WriteLine("Lightning Kick");
	}
}

internal class TornadoKick : KickBehavior
{
	public virtual void kick()
	{
		System.Console.Out.WriteLine("Tornado Kick");
	}
}

internal interface JumpBehavior
{
	// Encapsulated jump behaviors
	void jump();
}

internal class ShortJump : JumpBehavior
{
	public virtual void jump()
	{
		System.Console.Out.WriteLine("Short Jump");
	}
}

internal class LongJump : JumpBehavior
{
	public virtual void jump()
	{
		System.Console.Out.WriteLine("Long Jump");
	}
}

internal class Ryu : Fighter
{
	public Ryu(KickBehavior kickBehavior, JumpBehavior jumpBehavior)
		: base(kickBehavior, jumpBehavior)
	{
	}

	// Characters
	public override void display()
	{
		System.Console.Out.WriteLine("Ryu");
	}
}

internal class Ken : Fighter
{
	public Ken(KickBehavior kickBehavior, JumpBehavior jumpBehavior)
		: base(kickBehavior, jumpBehavior)
	{
	}

	public override void display()
	{
		System.Console.Out.WriteLine("Ken");
	}
}

internal class ChunLi : Fighter
{
	public ChunLi(KickBehavior kickBehavior, JumpBehavior jumpBehavior)
		: base(kickBehavior, jumpBehavior)
	{
	}

	public override void display()
	{
		System.Console.Out.WriteLine("ChunLi");
	}
}

internal class StreetFighter
{
	// Driver class
	public static void Main(string[] args)
	{
		// let us make some behaviors first
		JumpBehavior shortJump = new ShortJump();
		JumpBehavior LongJump = new LongJump();
		KickBehavior tornadoKick = new TornadoKick();
		// Make a fighter with desired behaviors
		Fighter ken = new Ken(tornadoKick, shortJump);
		ken.display();
		// Test behaviors
		ken.punch();
		ken.kick();
		ken.jump();
		// Change behavior dynamically (algorithms are
		// interchangeable)
		ken.setJumpBehavior(LongJump);
		ken.jump();
	}
}