using BigFiveQ.Controls.ExamenBfqUi;

namespace BigFiveQ.Controls
{
    public class SelectableItem : ViewModel, ISelectableItem
    {
        public SelectableItem()
        {

        }

        /// <summary>
        /// Initializes a new instance of the SelectableItem class.
        /// </summary>
        /// <param name="isSelected"></param>
        /// <param name="text"></param>
        public SelectableItem(bool isSelected, string text) : this(isSelected, text, text)
        {

        }

        /// <summary>
        /// Initializes a new instance of the SelectableItemViewModel class.
        /// </summary>
        /// <param name="isSelected"></param>
        /// <param name="text"></param>
        /// <param name="value"></param>
        public SelectableItem(bool isSelected, string text, string value)
        {
            m_isSelected = isSelected;
            m_text = text;
            m_value = value;
        }

        private const string IsSelectedPropertyName = "IsSelected";

        private bool m_isSelected;
        public bool IsSelected
        {
            get
            {
                return m_isSelected;
            }
            set
            {
                m_isSelected = value;
                
                NotifyPropertyChanged(IsSelectedPropertyName);
            }
        }

        private const string TextPropertyName = "Text";

        private string m_text;
        public string Text
        {
            get
            {
                return m_text;
            }
            set
            {
                m_text = value;
                NotifyPropertyChanged(TextPropertyName);
            }
        }

        private const string ValuePropertyName = "Value";

        private string m_value;
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
                NotifyPropertyChanged(ValuePropertyName);
            }
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
