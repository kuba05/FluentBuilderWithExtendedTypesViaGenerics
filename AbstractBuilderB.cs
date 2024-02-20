abstract public class AbstractBuilderB<T, S>: AbstractBuilderA<T,S> where T: AbstractBuilderB<T,S> where S: B, new() {
    //T is the builder type,
    //S is type of the buildtarget

    public T setSecond(int value) {
        target.second = value;
        return getMe();
    }
}