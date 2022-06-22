using System;

namespace Delegate
{
    internal class DateType
    {
        private int v1;
        private int v2;
        private int v3;
        private int v4;
        private int v5;
        private int v6;

        public DateType(int v1, int v2, int v3, int v4, int v5, int v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        internal static bool TryParse(string startDatestr, out DateType startDate)
        {
            throw new NotImplementedException();
        }
    }
}