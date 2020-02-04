
interface IHoardable
{
    void Collect(params TransferableObject[] objects);

    /// <summary>
    /// Intended to distinguish different instances of IHoardables
    /// </summary>
    object UniqueValue { get; set; }
}
