namespace NamespacePrefixPlaceholder.PowerShell.Models
{
    public interface IPropertyTracker
    {
        void TrackProperty(string propertyName);
        bool IsPropertySet(string propertyName);
        T SanitizeValue<T>(object value);
    }
}