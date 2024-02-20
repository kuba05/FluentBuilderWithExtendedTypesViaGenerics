abstract public class AbstractBuilderA<T, S> where T: AbstractBuilderA<T,S> where S: A, new() {
    //T is the builder type,
    //S is type of the buildtarget
    
    protected S target;
    public AbstractBuilderA(){
        target = new S();
    }

    //getMe is just a helper to allow us to make the builder fluent
    //we can't return self easiely, as that wouldn't have the required type
    abstract protected T getMe();

    public T setFirst(int value) {
        target.first = value;
        return getMe();
    }

    public S build() {
        return target;
    }
}