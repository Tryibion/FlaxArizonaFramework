using Flax.Build;

public class ArizonaFrameworkTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        Modules.Add("ArizonaFramework");
    }
}
