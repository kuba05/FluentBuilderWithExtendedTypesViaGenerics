public class BuilderA : AbstractBuilderA<BuilderA, A>
{

    protected override BuilderA getMe()
    {
        return this;
    }
}