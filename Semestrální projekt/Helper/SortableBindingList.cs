using System.ComponentModel;

namespace Semestrální_projekt {
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection;
        private PropertyDescriptor? _sortProperty;

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => _isSorted;
        protected override ListSortDirection SortDirectionCore => _sortDirection;
        protected override PropertyDescriptor? SortPropertyCore => _sortProperty;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var list = (List<T>)Items;
            list.Sort((x, y) =>
            {
                var a = prop.GetValue(x);
                var b = prop.GetValue(y);
                int result = Comparer<object>.Default.Compare(a, b);
                return direction == ListSortDirection.Ascending ? result : -result;
            });

            _isSorted = true;
            _sortDirection = direction;
            _sortProperty = prop;
            ResetBindings();
        }

        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortProperty = null;
            ResetBindings();
        }
    }
}