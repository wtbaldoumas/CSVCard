using System.Text;

namespace CSVCard
{
    class VCard
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _phoneNumber = string.Empty;
        private string _email = string.Empty;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("BEGIN:VCARD");
            builder.AppendLine("VERSION:2.1");
            builder.AppendLine("N:" + LastName + ";" + FirstName);
            builder.AppendLine("FN:" + FirstName + " " + LastName);
            builder.AppendLine("TEL;CELL;VOICE:" + PhoneNumber);
            builder.AppendLine("EMAIL;PREF;INTERNET:" + Email);
            builder.AppendLine("END:VCARD");
            return builder.ToString();
        }
    }
}
