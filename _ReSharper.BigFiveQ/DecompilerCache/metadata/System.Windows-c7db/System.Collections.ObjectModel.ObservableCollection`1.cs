// Type: System.Collections.ObjectModel.ObservableCollection`1
// Assembly: System.Windows, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// Assembly location: C:\Program Files\Reference Assemblies\Microsoft\Framework\Silverlight\v4.0\System.Windows.dll

using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace System.Collections.ObjectModel
{
    public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public ObservableCollection();
        public ObservableCollection(IEnumerable<T> collection);
        public ObservableCollection(List<T> list);

        #region INotifyCollectionChanged Members

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        #endregion

        #region INotifyPropertyChanged Members

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged;

        #endregion

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e);
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
        protected override void ClearItems();
        protected override void RemoveItem(int index);
        protected override void InsertItem(int index, T item);
        protected override void SetItem(int index, T item);
        protected event PropertyChangedEventHandler PropertyChanged;
    }
}
