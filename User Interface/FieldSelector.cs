using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace CSVCard
{
    public partial class FieldSelector : UserControl
    {
        private static readonly IList<string> _fields = new ReadOnlyCollection<string>(new List<string> { "First Name", "Last Name", "Email", "Phone Number" });

        public FieldSelector()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            foreach (string field in _fields)
            {
                _firstField.Items.Add(field);
                _secondField.Items.Add(field);
                _thirdField.Items.Add(field);
                _fourthField.Items.Add(field);
            }

            _firstField.SelectedIndex = 0;
            _secondField.SelectedIndex = 1;
            _thirdField.SelectedIndex = 2;
            _fourthField.SelectedIndex = 3;
        }

        public int[] FieldOrder()
        {
            int[] fieldOrder = new int[4];

            fieldOrder[0] = _firstField.SelectedIndex;
            fieldOrder[1] = _secondField.SelectedIndex;
            fieldOrder[2] = _thirdField.SelectedIndex;
            fieldOrder[3] = _fourthField.SelectedIndex;

            return fieldOrder;
        }

        public bool HeaderIncluded()
        {
            return _headerCheckBox.Checked;
        }

        public bool SeparateFieldsSelected()
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = i + 1; j < 4; ++j)
                {
                    if (FieldOrder()[i] == FieldOrder()[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
