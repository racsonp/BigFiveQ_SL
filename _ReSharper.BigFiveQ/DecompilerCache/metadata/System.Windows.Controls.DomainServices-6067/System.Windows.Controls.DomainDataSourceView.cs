// Type: System.Windows.Controls.DomainDataSourceView
// Assembly: System.Windows.Controls.DomainServices, Version=2.0.5.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files\Microsoft SDKs\RIA Services\v1.0\Libraries\Silverlight\System.Windows.Controls.DomainServices.dll

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Controls
{
    public sealed class DomainDataSourceView : ICollectionView, IEnumerable, INotifyCollectionChanged,
                                               IEditableCollectionView, IPagedCollectionView, INotifyPropertyChanged
    {
        public object this[int index] { get; }
        public bool CanAdd { get; }
        public int Count { get; }
        public int PageCount { get; }

        #region ICollectionView Members

        public bool Contains(object item);
        public bool MoveCurrentTo(object item);
        public bool MoveCurrentToFirst();
        public bool MoveCurrentToLast();
        public bool MoveCurrentToNext();
        public bool MoveCurrentToPosition(int position);
        public bool MoveCurrentToPrevious();
        IDisposable ICollectionView.DeferRefresh();
        void ICollectionView.Refresh();
        IEnumerator IEnumerable.GetEnumerator();
        public object CurrentItem { get; }
        public int CurrentPosition { get; }
        public bool IsEmpty { get; }
        bool ICollectionView.CanFilter { get; }
        bool ICollectionView.CanGroup { get; }
        bool ICollectionView.CanSort { get; }
        CultureInfo ICollectionView.Culture { get; set; }
        Predicate<object> ICollectionView.Filter { get; set; }
        ObservableCollection<GroupDescription> ICollectionView.GroupDescriptions { get; }
        ReadOnlyObservableCollection<object> ICollectionView.Groups { get; }
        bool ICollectionView.IsCurrentAfterLast { get; }
        bool ICollectionView.IsCurrentBeforeFirst { get; }
        SortDescriptionCollection ICollectionView.SortDescriptions { get; }
        IEnumerable ICollectionView.SourceCollection { get; }
        public event EventHandler CurrentChanged;
        public event CurrentChangingEventHandler CurrentChanging;
        event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged;

        #endregion

        #region IEditableCollectionView Members

        public void Remove(object item);
        public void RemoveAt(int index);
        object IEditableCollectionView.AddNew();
        void IEditableCollectionView.CancelEdit();
        void IEditableCollectionView.CancelNew();
        void IEditableCollectionView.CommitEdit();
        void IEditableCollectionView.CommitNew();
        void IEditableCollectionView.EditItem(object item);
        public bool CanRemove { get; }
        bool IEditableCollectionView.CanAddNew { get; }
        bool IEditableCollectionView.CanCancelEdit { get; }
        object IEditableCollectionView.CurrentAddItem { get; }
        object IEditableCollectionView.CurrentEditItem { get; }
        bool IEditableCollectionView.IsAddingNew { get; }
        bool IEditableCollectionView.IsEditingItem { get; }
        NewItemPlaceholderPosition IEditableCollectionView.NewItemPlaceholderPosition { get; set; }

        #endregion

        #region INotifyPropertyChanged Members

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged;

        #endregion

        #region IPagedCollectionView Members

        public bool MoveToFirstPage();
        public bool MoveToLastPage();
        public bool MoveToNextPage();
        public bool MoveToPage(int pageIndex);
        public bool MoveToPreviousPage();
        public bool CanChangePage { get; }
        public bool IsPageChanging { get; }
        public int PageIndex { get; }
        public int PageSize { get; set; }
        public int TotalItemCount { get; }
        int IPagedCollectionView.ItemCount { get; }
        public event EventHandler<EventArgs> PageChanged;
        public event EventHandler<PageChangingEventArgs> PageChanging;

        #endregion

        public void Add(object item);
        public object GetItemAt(int index);
        public int IndexOf(object item);
    }
}
