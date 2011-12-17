using System;

namespace BigFiveQ.Controls.ExamenBfqUi
{
    public class WizardEventArgs : EventArgs
    {
        int _iCurrentPageIndex = 0;
        int _iNewPageIndex = 0;
        WizardAction _eAction;

        public WizardEventArgs(int iCurrentPageIndex, int iNewPageIndex, WizardAction eAction)
        {
            _iCurrentPageIndex = iCurrentPageIndex;
            _iNewPageIndex = iNewPageIndex;
            _eAction = eAction;
            Cancel = false;
        }

        public bool Cancel { get; set; }
        public int CurrentPageIndex { get { return _iCurrentPageIndex; } }
        public int NewPageIndex { get { return _iNewPageIndex; } }
        public WizardAction Action { get { return _eAction; } }
    }
}