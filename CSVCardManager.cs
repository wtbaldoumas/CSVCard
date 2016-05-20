using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CSVCard
{
    static class CSVCardManager
    {
        private static List<VCard> _vcards = new List<VCard>();
        private static string _path = string.Empty;
        private static string _filename = string.Empty;
        private static bool _dataLoaded = false;

        public static List<VCard> VCards
        {
            get { return _vcards; }
            set { _vcards = value; }
        }

        public static string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        public static bool DataLoaded
        {
            get { return _dataLoaded; }
            set { _dataLoaded = value; }
        }

        public static bool Open(bool header, int[] fieldOrder)
        {
            _vcards.Clear();

            string line = string.Empty;

            using (StreamReader streamReader = new StreamReader(_filename))
            {
                if (header)
                {
                    line = streamReader.ReadLine();
                }

                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    VCard vcard = new VCard();

                    for (int i = 0; i < values.Length - 1; ++i)
                    {
                        switch (fieldOrder[i])
                        {
                            case 0:
                                vcard.FirstName = values[i];
                                break;
                            case 1:
                                vcard.LastName = values[i];
                                break;
                            case 2:
                                vcard.Email = values[i];
                                break;
                            case 3:
                                vcard.PhoneNumber = values[i];
                                break;
                        }
                    }

                    _vcards.Add(vcard);
                }

                return true;
            }
        }

        public static void SingleSave()
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _path += "\\VCard Contacts\\";
            string filepath = string.Empty;
            int count = 0;
            DirectoryInfo VCFDirectory = Directory.CreateDirectory(_path);

            foreach (VCard vcard in _vcards)
            {
                ++count;
                filepath = _path + vcard.FirstName + " " + vcard.LastName + ".vcf";
                using (var writer = new StreamWriter(filepath))
                {
                    writer.Write(vcard.ToString());
                }
            }

            Process.Start(_path);
        }

        public static void MergeSave()
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _path += "\\VCard Contacts\\";
            string filepath = string.Empty;
            string filename = string.Format("{0}.vcf", Path.GetFileNameWithoutExtension(_filename));
            DirectoryInfo VCFDirectory = Directory.CreateDirectory(_path);


            filepath = string.Format("{0}{1}", _path, filename);
            using (var writer = new StreamWriter(filepath))
            {
                foreach (VCard vcard in _vcards)
                {
                    writer.Write(vcard.ToString());
                }
            }

            Process.Start(_path);
        }
    }
}
