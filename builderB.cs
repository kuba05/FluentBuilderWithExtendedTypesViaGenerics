public class BuilderB : AbstractBuilderB<BuilderB, B>{

    protected override BuilderB getMe()
    {
        return this;
    }
}