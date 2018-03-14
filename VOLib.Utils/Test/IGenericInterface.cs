namespace VOLib.Utils.Test
{
    public interface IGenericInterface<out T>
    {
        T GimmeSomeData();
    }
}