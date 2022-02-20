namespace Task03_GenericInterfaces
{
    public interface IEncrypted<T, TU>
    {
        T Encode(TU u);
        TU Decode(T t);
    }

}