using System.ComponentModel;

namespace BigFiveQ.Controls
{
    public interface ISelectableItem : INotifyPropertyChanged
    {
        bool IsSelected { get; set; }
        string Text { get; set; }
        string Value { get; set; }
    }
}
